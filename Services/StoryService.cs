using BE_Fan_Fusion.DTO;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using BE_Fan_Fusion.Repositories;
using Microsoft.EntityFrameworkCore;


namespace BE_Fan_Fusion.Services
{
    public class StoryService : IStoryService
    {
        private readonly IStoryRepository _storyRepository;

        public StoryService(IStoryRepository storyRepository)
        {
            _storyRepository = storyRepository;
        }
        public async Task<List<StoryDTO>> GetStoriesAsync(int userId)
        {
            var allStories = await _storyRepository.GetStoriesAsync();
            var user = await _storyRepository.GetUserWithFavoritedStoriesAsync(userId);
            if (user == null)
            {
                throw new ArgumentException($"There are no users with Id of: {userId}.");
            }
            return allStories.Select(story => new StoryDTO(story, user.FavoritedStories?.Contains(story) ?? false)).OrderByDescending(story => story.DateCreated).ToList();
        }
        public async Task<Story> GetStoryByIdAsync(int storyId)
        {
            return await _storyRepository.GetStoryByIdAsync(storyId);
        }
        public async Task<Story> CreateStoryAsync(Story story)
        {
            if (!await _storyRepository.UserExistsAsync(story.UserId))
            {
                throw new ArgumentException($"There is no user with the following id: {story.UserId}");
            }

            if (!await _storyRepository.CategoryExistsAsync(story.CategoryId))
            {
                throw new ArgumentException($"There are no categories with the following id: {story.CategoryId}");
            }

            Story newStory = new()
            {
                Title = story.Title,
                Description = story.Description,
                Image = story.Image,
                DateCreated = DateTime.Now,
                UserId = story.UserId,
                TargetAudience = story.TargetAudience,
                CategoryId = story.CategoryId,
            };
            return await _storyRepository.CreateStoryAsync(newStory);
        }
        public async Task<Story> UpdateStoryAsync(Story story, int storyId)
        {
            if (!await _storyRepository.UserExistsAsync(story.UserId))
            {
                throw new ArgumentException($"There is no user with the following id: {story.UserId}");
            }

            if (!await _storyRepository.CategoryExistsAsync(story.CategoryId))
            {
                throw new ArgumentException($"There are no categories with the following id: {story.CategoryId}");
            }

            return await _storyRepository.UpdateStoryAsync(story, storyId);
        
    }
  
        public async Task<Story> DeleteStoryAsync(int storyId)
        {
            return await _storyRepository.DeleteStoryAsync(storyId);
        }
        public async Task<List<Story>> SearchStoriesAsync(string searchValue)
        {
            return await _storyRepository.SearchStoriesAsync(searchValue);
        }
        public async Task<List<StoryDTO>> GetStoriesByCategoryIdAsync(int categoryId, int userId)
        {
            var categoryStories = await _storyRepository.GetStoriesByCategoryIdAsync(categoryId);
            // Check if the category exists
            if (categoryStories == null)
            {
                throw new ArgumentException($"Category with ID {categoryId} not found.");
            }

            var user = await _storyRepository.GetUserWithFavoritedStoriesAsync(userId);
            if (user == null)
            {
                throw new ArgumentException($"There are no users with Id of: {userId}.");
            }
            return categoryStories.Select(story => new StoryDTO(story, user.FavoritedStories?.Contains(story) ?? false)).OrderByDescending(story => story.DateCreated).ToList();
        }
        public async Task<(bool Success, string Message)> ToggleFavoriteStoriesAsync(int storyId, int userId)
        {


            var user =  await _storyRepository.GetUserWithFavoritedStoriesAsync(userId);
            if (user == null)
            {
                return (false, $"There is no user with the following id: {userId}");
            }
            var story = await _storyRepository.GetSingleStoryAsync(storyId);
            if (story == null)
            {
                return (false, $"There is no story with the following id: {storyId}");
            }

            bool IsFavorite;

            if (user.FavoritedStories.Contains(story))
            {
                await _storyRepository.RemoveFavoritedStoryAsync(story, user);
                IsFavorite = false;
            }
            else
            {
                await _storyRepository.AddFavoritedStoryAsync(story, user);
                IsFavorite = true;
            }
            
            return (true, IsFavorite ? "Story added to favorites." : "Story removed from favorites.");


        }

    }
}
