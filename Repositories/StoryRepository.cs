using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Repositories
{
    public class StoryRepository : IStoryRepository
    {
         
        private readonly FanFusionDbContext dbContext;

        public StoryRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }
        public Task<List<Story>> GetStoriesAsync()
        {
            throw new NotImplementedException();
        }
        public Task<Story> GetStoryByIdAsync(int storyId)
        {
            throw new NotImplementedException();
        }
        public Task<Story> CreateStoryAsync(Story story)
        {
            throw new NotImplementedException();
        }
        public Task<Story> UpdateStoryAsync(Story story, int storyId)
        {
            throw new NotImplementedException();
        }
        public Task<Story> DeleteStoryAsync(int storyId)
        {
            throw new NotImplementedException();
        }
        public Task<List<Story>> SearchStoriesAsync(string searchValue)
        {
            throw new NotImplementedException();
        }
        public Task<List<Story>> GetStoriesByCategoryIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}

