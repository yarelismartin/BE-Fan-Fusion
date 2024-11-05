using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using BE_Fan_Fusion.Repositories;

namespace BE_Fan_Fusion.Services
{
    public class ChapterService : IChapterService
    {
        private readonly IChapterRepository _chapterRepository;

        public ChapterService(IChapterRepository chapterRepository)
        {
            _chapterRepository = chapterRepository;
        }

        public async Task<Chapter?> GetChapterByIdAsync(int chapterId)
        {
            return await _chapterRepository.GetChapterByIdAsync(chapterId);
        }
        public async Task<Chapter> CreateOrUpdateChapterAsync(Chapter chapter)
        {
            if (!await _chapterRepository.UserExistsAsync(chapter.UserId))
            {
                throw new ArgumentException($"No user found with the following id: {chapter.UserId}");
            }

            if (!await _chapterRepository.StoryExistsAsync(chapter.StoryId))
            {
                throw new ArgumentException($"No story was found with the following id: {chapter.StoryId}");
            }

            return await _chapterRepository.CreateOrUpdateChapterAsync(chapter);
        }
        public async Task<Chapter?> DeleteChapterAsync(int chapterId)
        {
            return await _chapterRepository.DeleteChapterAsync(chapterId);
        }
    }
}
