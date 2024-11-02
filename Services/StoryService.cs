using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using BE_Fan_Fusion.Repositories;

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
            return await _storyRepository.CreateStoryAsync(story);
        }
        public async Task<Story> UpdateStoryAsync(Story story, int storyId)
        {
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
