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

        /*public async Task<string> AddTagToStory(int tagId, int storyId)
        {
            var story = await dbContext.Stories
                .Include(s => s.Tags)
                .FirstOrDefaultAsync(s => s.Id == storyId);

            if (story == null)
            {
                return ($"There is no story with the following id: {storyId}");
            }

            var tag = await dbContext.Tags.FirstOrDefaultAsync(t => t.Id == tagId);
            if (tag == null)
            {
                return ($"There is no tag with the following id: {tagId}");
            }
            else if (story.Tags.Contains(tag))
            {
                return ("This story already has this tag.");
            }

            story.Tags.Add(tag);
            await dbContext.SaveChangesAsync();

            return "Tag added to the story successfully";

        }*/

        public async Task<Story?> GetStoryWithTags(int storyId)
        {
            return await dbContext.Stories
                .Include( s=> s.Tags)
                .FirstOrDefaultAsync(s => s.Id == storyId); 
        }
        public async Task<Tag?> GetTagById(int tagId)
        {
            return await dbContext.Tags.FirstOrDefaultAsync(s => s.Id == tagId);
        }

        public async Task AddTag( Story story, Tag tag)
        {
            story.Tags.Add(tag);
            await dbContext.SaveChangesAsync();
        }

        public async Task RemoveTag(Story story, Tag tag)
        {
            story.Tags.Remove(tag);
            await dbContext.SaveChangesAsync();
        }
    }
}