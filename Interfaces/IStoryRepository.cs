using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface IStoryRepository
    {
        Task<List<Story>> GetStoriesAsync();
        Task<Story> GetStoryByIdAsync(int storyId);
        Task<Story> CreateStoryAsync(Story story);
        Task<Story> UpdateStoryAsync(Story story, int storyId);
        Task<Story> DeleteStoryAsync(int storyId);
        Task<List<Story>> SearchStoriesAsync(string searchValue);
        Task<List<Story>> GetStoriesByCategoryIdAsync(int categoryId);
        Task<User?> GetUserWithFavoritedStoriesAsync(int userId);
        Task<Story?> GetSingleStoryAsync(int storyId);
        Task AddFavoritedStoryAsync(Story story, User user);
        Task RemoveFavoritedStoryAsync(Story story, User user);
    }
}
