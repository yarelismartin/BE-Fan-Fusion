using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;

namespace BE_Fan_Fusion.Repositories
{
    public class ChapterRepository : IChapterRepository
    {
        private readonly FanFusionDbContext dbContext;

        public ChapterRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }

        public async Task<Chapter?> GetChapterByIdAsync(int chapterId)
        {
            return await dbContext.Chapters
             .Include(ch => ch.Story)
             .Include(ch => ch.User)
             .Include(ch => ch.Comments)
             .ThenInclude(comment => comment.User)
             .SingleOrDefaultAsync(ch => ch.Id == chapterId);
        }

        public async Task<bool> UserExistsAsync(int userId)
        {
            return await dbContext.Users.AnyAsync(user => user.Id == userId);
        }

        public async Task<bool> StoryExistsAsync(int storyId)
        {
            return await dbContext.Stories.AnyAsync(story => story.Id == storyId);
        }

        public async Task<Chapter> CreateOrUpdateChapterAsync(Chapter chapter)
        {
            // Find the existing chapter if it exists
            var existingChapter = await dbContext.Chapters.FindAsync(chapter.Id);

            if (existingChapter != null)
            {
                // Update existing chapter by directly modifying properties
                existingChapter.Title = chapter.Title;
                existingChapter.Content = chapter.Content;
                existingChapter.SaveAsDraft = chapter.SaveAsDraft;
                await dbContext.SaveChangesAsync();
                return existingChapter;
            }
            else
            {
             
                // Create new chapter
                Chapter addChapter = new()
                {
                    Title = chapter.Title,
                    Content = chapter.Content,
                    UserId = chapter.UserId,
                    SaveAsDraft = chapter.SaveAsDraft,
                    DateCreated = DateTime.Now,
                    StoryId = chapter.StoryId,
                };

                await dbContext.Chapters.AddAsync(addChapter);
                await dbContext.SaveChangesAsync();
                return addChapter;
            }
        }

        public async Task<Chapter?> DeleteChapterAsync(int chapterId)
        {
            var chapter = await dbContext.Chapters.SingleOrDefaultAsync(chapter => chapter.Id == chapterId);

            if (chapter != null)
            {
                dbContext.Chapters.Remove(chapter);
                await dbContext.SaveChangesAsync();
            }

            return chapter;

        }

    }
}

