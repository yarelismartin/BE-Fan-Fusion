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
        public async Task<List<Story>> GetStoriesAsync()
        {
            return await _storyRepository.GetStoriesAsync();
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
        public async Task<List<Story>> GetStoriesByCategoryIdAsync(int categoryId)
        {
            return await _storyRepository.GetStoriesByCategoryIdAsync(categoryId);
        }
    }
}
