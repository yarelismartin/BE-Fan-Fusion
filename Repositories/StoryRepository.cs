using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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
            return await dbContext.Stories.ToListAsync();
        }
        public async Task<Story?> GetStoryByIdAsync(int storyId)
        {
            return await dbContext.Stories
              .Include(s => s.Chapters)
              .Include(s => s.Tags)
              .Include(s => s.User)
              .SingleOrDefaultAsync(s => s.Id == storyId);
        }
        public async Task<Story> CreateStoryAsync(Story story)
        {
            await dbContext.Stories.AddAsync(story);
            await dbContext.SaveChangesAsync();
            return story;
        }
        public async Task<bool> UserExistsAsync(int userId)
        {
            return await dbContext.Users.AnyAsync(user => user.Id == userId);
        }

        public async Task<bool> CategoryExistsAsync(int categoryId)
        {
            return await dbContext.Categories.AnyAsync(category => category.Id == categoryId);
        }
        public async Task<Story?> UpdateStoryAsync(Story story, int storyId)
        {
             var existingStory = await dbContext.Stories.FindAsync(storyId);

             // If the story doesn't exist, return null (or throw an exception based on your preference)
                 if (existingStory == null)
                 {
                     return null; // or throw new NotFoundException("Story not found");
                 }

                // Update the existing story's properties
                existingStory.Title = story.Title;
                existingStory.Description = story.Description;
                existingStory.Image = story.Image;
                existingStory.UserId = story.UserId;
                existingStory.TargetAudience = story.TargetAudience;
                existingStory.CategoryId = story.CategoryId;

                // Save changes to the database
                await dbContext.SaveChangesAsync();

                // Return the updated story
                return existingStory;
                    }

        public async Task<Story?> DeleteStoryAsync(int storyId)
        {
            var story = await dbContext.Stories.SingleOrDefaultAsync(story => story.Id == storyId);

            if (story != null)
            {
                dbContext.Stories.Remove(story);
                await dbContext.SaveChangesAsync();
            }
            return story;
        }
        public async Task<List<Story?>> SearchStoriesAsync(string searchValue)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Story>> GetStoriesByCategoryIdAsync(int categoryId)
        {
            return await dbContext.Stories
                .Where(c => c.CategoryId == categoryId)
                .ToListAsync();
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