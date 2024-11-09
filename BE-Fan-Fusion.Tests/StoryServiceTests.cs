using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using BE_Fan_Fusion.Services;
using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;


namespace BE_Fan_Fusion.Tests
{
    public class StoryServiceTests
    {
        private readonly StoryService _storyService;
        private readonly Mock<IStoryRepository> _mockStoryRepository;

        public StoryServiceTests()
        {
            //Testing saveing 
            // lets us simulate the behavior of the repository without needing a real database.
            _mockStoryRepository = new Mock<IStoryRepository>();
            // initialize StoryService with the mock repository.
            // This way, StoryService will use the mocked methods instead of actual database calls.
            _storyService = new StoryService(_mockStoryRepository.Object);
        }

        [Fact]
        public async Task GetStoriesAsync_WhenCalledOn_ReturnsStoriesAsync()
        {
            int userId = 2;

            // This simulates data that the GetStoriesAsync method would typically retrieve from a database.
            // For testing purposes, we only need basic data to keep it simple.
            var stories = new List<Story>
            {
                new Story
                {
                    Id = 1,
                },
                new Story
                {
                    Id = 2,
                }
            };

            // This line sets up the mock repository to return the sample list of stories when GetStoriesAsync is called.
            _mockStoryRepository.Setup(repo => repo.GetStoriesAsync()).ReturnsAsync(stories);
            //  return a User object with userId and one favorited story. Simulating that the user has favorited the first story in stories.
            _mockStoryRepository.Setup(repo => repo.GetUserWithFavoritedStoriesAsync(userId))
                        .ReturnsAsync(new User { Id = userId, FavoritedStories = new List<Story> { stories[0] } });

            var results = await _storyService.GetStoriesAsync(userId);

            // ensures that results is not null. This verifies that GetStoriesAsync actually returns something instead of null
            Assert.NotNull(results);
            // checks if results contains exactly two items. This confirms that the GetStoriesAsync method returned both stories, as expected.
            Assert.Equal(2, results.Count());
            Assert.True(results.First().IsFavorited);  
            Assert.False(results.Last().IsFavorited);
        }
        [Fact]

        public async Task GetStoryByIdAsync_WhenCalled_ReturnsSingleStoryAsync()
        {
            int storyId = 4;

            var storyItem = new Story { Id = storyId};

            _mockStoryRepository.Setup(repo => repo.GetStoryByIdAsync(storyId)).ReturnsAsync(storyItem);

            var result = await _storyService.GetStoryByIdAsync(storyId);

            Assert.NotNull(result);
            Assert.Equal(storyId, result.Id);

        }

        [Fact]

        public async Task UpdateStoryAsync_WhenCalled_ReturnUpdatedStoryAsync()
        {
            int storyId = 1;

            var storyItem = new Story
            {
                Id = storyId,
                Title = "Updated Title",
                Description = "Updated Description",
                Image = "Updated Image",
                DateCreated = DateTime.Now,
                UserId = 4,
                TargetAudience = "Updated Audience",
                CategoryId = 2,
            };

            //No matter what Story object is passed to UpdateStoryAsync, I’m setting it up to return storyItem
            _mockStoryRepository.Setup(repo => repo.UpdateStoryAsync(It.IsAny<Story>(), storyId)).ReturnsAsync(storyItem);
            _mockStoryRepository.Setup(repo => repo.UserExistsAsync(storyItem.UserId)).ReturnsAsync(true);
            _mockStoryRepository.Setup(repo => repo.CategoryExistsAsync(storyItem.CategoryId)).ReturnsAsync(true);

            var result = await _storyService.UpdateStoryAsync(storyItem, storyId);

            Assert.NotNull(result);
            Assert.Equal(storyId, result.Id);
            Assert.Equal("Updated Title", result.Title);
            Assert.Equal("Updated Description", result.Description);
            Assert.Equal("Updated Image", result.Image);
            Assert.Equal("Updated Audience", result.TargetAudience);
            Assert.Equal(2, result.CategoryId);
        }
    }
}
        // Arrange: to set up the inputs to configure or declare the variables for the test.
        // Act: to do the actions like a method call or controller call.
        // Assert: to evaluate the results