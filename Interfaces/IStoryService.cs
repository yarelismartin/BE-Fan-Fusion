using BE_Fan_Fusion.DTO;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface IStoryService
    {
        Task<List<StoryDTO>> GetStoriesAsync(int userId);
        Task<Story> GetStoryByIdAsync(int storyId);
        Task<Story> CreateStoryAsync(Story story);
        Task<Story> UpdateStoryAsync(Story story, int storyId);
        Task<Story> DeleteStoryAsync(int storyId);
        Task<List<Story?>> SearchStoriesAsync(string searchValue);
        Task<List<Story?>> GetStoriesByCategoryIdAsync(int categoryId);
        Task<(bool Success, string Message)> ToggleFavoriteStoriesAsync(int storyId, int userId);
    }
}
