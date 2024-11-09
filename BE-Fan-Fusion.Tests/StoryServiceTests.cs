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

        [Fact]
        public async Task DeleteStoryAsync_ValidId_ReturnsDeletedStory()
        {
            // Arrange
            var mockRepository = new Mock<IStoryRepository>();
            var storyId = 1;
            var sampleStory = new Story
            {
                Id = 1,
                Title = "A Second Chance at Hogwarts",
                Description = "A time-travel story where Harry returns to his first year to fix everything.",
                Image = "https://images.unsplash.com/photo-1527684651001-731c474bbb5a?q=80&w=2787&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                DateCreated = new DateTime(2024, 10, 01),
                TargetAudience = "Young Adult",
                UserId = 15,
                CategoryId = 3
            };
            mockRepository.Setup(repo => repo.DeleteStoryAsync(storyId)).ReturnsAsync(sampleStory);

            var storyService = new StoryService(mockRepository.Object);

            // Act
            var result = await storyService.DeleteStoryAsync(storyId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(storyId, result.Id);
            Assert.Equal("A Second Chance at Hogwarts", result.Title);

            mockRepository.Verify(repo => repo.DeleteStoryAsync(storyId), Times.Once);
        }

        [Fact]
        public async Task DeleteStoryAsync_InvalidId_ReturnsNull()
        {
            // Arrange
            var mockRepository = new Mock<IStoryRepository>();
            var invalidStoryId = 99;
            mockRepository.Setup(repo => repo.DeleteStoryAsync(invalidStoryId)).ReturnsAsync((Story?)null);

            var storyService = new StoryService(mockRepository.Object);

            // Act
            var result = await storyService.DeleteStoryAsync(invalidStoryId);

            // Assert
            Assert.Null(result);

            mockRepository.Verify(repo => repo.DeleteStoryAsync(invalidStoryId), Times.Once);
        }

        [Fact]
        public async Task CreateStoryAsync_ShouldReturnCreatedStory_WhenInputsAreValid()
        {
            // Arrange
            var newStory = new Story
            {
                Title = "Test Story",
                Description = "Test Description",
                Image = "test.jpg",
                UserId = 1,
                CategoryId = 2,
                TargetAudience = "General",
            };
            var createdStory = new Story
            {
                Id = 1,
                Title = newStory.Title,
                Description = newStory.Description,
                Image = newStory.Image,
                UserId = newStory.UserId,
                CategoryId = newStory.CategoryId,
                TargetAudience = newStory.TargetAudience,
                DateCreated = DateTime.Now
            };

            // Set up mock repository behavior
            _mockStoryRepository.Setup(repo => repo.UserExistsAsync(newStory.UserId))
                .ReturnsAsync(true);
            _mockStoryRepository.Setup(repo => repo.CategoryExistsAsync(newStory.CategoryId))
                .ReturnsAsync(true);
            _mockStoryRepository.Setup(repo => repo.CreateStoryAsync(It.IsAny<Story>()))
                .ReturnsAsync(createdStory);

            // Act
            var result = await _storyService.CreateStoryAsync(newStory);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(createdStory.Id, result.Id);
            Assert.Equal(createdStory.Title, result.Title);
            Assert.Equal(createdStory.Description, result.Description);
            Assert.Equal(createdStory.UserId, result.UserId);

            // Verify repository methods were called
            _mockStoryRepository.Verify(repo => repo.UserExistsAsync(newStory.UserId), Times.Once);
            _mockStoryRepository.Verify(repo => repo.CategoryExistsAsync(newStory.CategoryId), Times.Once);
            _mockStoryRepository.Verify(repo => repo.CreateStoryAsync(It.IsAny<Story>()), Times.Once);
        }

        [Fact]
        public async Task CreateStoryAsync_ShouldThrowArgumentException_WhenUserDoesNotExist()
        {
            // Arrange
            var newStory = new Story { Title = "Test Story", UserId = 1, CategoryId = 2 };
            // Set up mock repository to indicate user doesn't exist
            _mockStoryRepository.Setup(repo => repo.UserExistsAsync(newStory.UserId))
                .ReturnsAsync(false);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(async () =>
               await _storyService.CreateStoryAsync(newStory));

            // Verify that the category check and story creation were never called
            _mockStoryRepository.Verify(repo => repo.CategoryExistsAsync(It.IsAny<int>()), Times.Never);
            _mockStoryRepository.Verify(repo => repo.CreateStoryAsync(It.IsAny<Story>()), Times.Never);
        }

        [Fact]
        public async Task CreateStoryAsync_ShouldThrowArgumentException_WhenCategoryDoesNotExist()
        {
            // Arrange
            var newStory = new Story { Title = "Test Story", UserId = 1, CategoryId = 2 };

            // Set up mock repository to indicate user exists but category does not
            _mockStoryRepository.Setup(repo => repo.UserExistsAsync(newStory.UserId))
                .ReturnsAsync(true);
            _mockStoryRepository.Setup(repo => repo.CategoryExistsAsync(newStory.CategoryId))
                .ReturnsAsync(false);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(async () =>
                await _storyService.CreateStoryAsync(newStory));

            // Verify that the story creation was never called
            _mockStoryRepository.Verify(repo => repo.CreateStoryAsync(It.IsAny<Story>()), Times.Never);
        }

    }
}
    
        // Arrange: to set up the inputs to configure or declare the variables for the test.
        // Act: to do the actions like a method call or controller call.
        // Assert: to evaluate the results