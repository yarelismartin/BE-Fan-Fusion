using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using Microsoft.EntityFrameworkCore;

namespace BE_Fan_Fusion.Repositories
{
    public class StoryRepository : IStoryRepository
    {
         
        private readonly FanFusionDbContext dbContext;

        public StoryRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }
        public async Task<List<Story>> GetStoriesAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<Story> GetStoryByIdAsync(int storyId)
        {
            throw new NotImplementedException();
        }
        public async Task<Story> CreateStoryAsync(Story story)
        {
            throw new NotImplementedException();
        }
        public async Task<Story> UpdateStoryAsync(Story story, int storyId)
        {
            throw new NotImplementedException();
        }
        public async Task<Story> DeleteStoryAsync(int storyId)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Story>> SearchStoriesAsync(string searchValue)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Story>> GetStoriesByCategoryIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetUserWithFavoritedStoriesAsync(int userId)
        {
            return await dbContext.Users
                .Include(u => u.FavoritedStories)
                .FirstOrDefaultAsync(u => u.Id == userId);
        }
        public async Task<Story?> GetSingleStoryAsync(int storyId)
        {
            return await dbContext.Stories
                .FirstOrDefaultAsync(s => s.Id == storyId);
        }
        public async Task AddFavoritedStoryAsync(Story story, User user)
        {
            user.FavoritedStories.Add(story);
            await dbContext.SaveChangesAsync();
        }
        public async Task RemoveFavoritedStoryAsync(Story story, User user)
        {
            user.FavoritedStories.Remove(story);
            await dbContext.SaveChangesAsync();

        }
    }
}