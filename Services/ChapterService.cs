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
        public async Task<Chapter> CreateAndUpdateChapterAsync(Chapter chapter)
        {
            return await _chapterRepository.CreateAndUpdateChapterAsync(chapter);
        }
        public async Task<Chapter> DeleteChapterAsync(int chapterId)
        {
            return await _chapterRepository.DeleteChapterAsync(chapterId);
        }
    }
}
