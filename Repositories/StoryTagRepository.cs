using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace BE_Fan_Fusion.Repositories
{
    public class StoryTagRepository : IStoryTagRepository
    {
         
        private readonly FanFusionDbContext dbContext;

        public StoryTagRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }


        public async Task<Story?> GetStoryWithTagsAsync(int storyId)
        {
            return await dbContext.Stories
                .Include( s=> s.Tags)
                .FirstOrDefaultAsync(s => s.Id == storyId); 
        }
        public async Task<Tag?> GetTagByIdAsync(int tagId)
        {
            return await dbContext.Tags.FirstOrDefaultAsync(s => s.Id == tagId);
        }

        public async Task AddTagAsync( Story story, Tag tag)
        {
            story.Tags.Add(tag);
            await dbContext.SaveChangesAsync();
        }

        public async Task RemoveTagAsync(Story story, Tag tag)
        {
            story.Tags.Remove(tag);
            await dbContext.SaveChangesAsync();
        }
    }
}