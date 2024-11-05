using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface IChapterService
    {
        Task<Chapter?> GetChapterByIdAsync(int chapterId);
        Task<Chapter> CreateOrUpdateChapterAsync(Chapter chapter);
        Task<Chapter?> DeleteChapterAsync(int chapterId);
    }
}
