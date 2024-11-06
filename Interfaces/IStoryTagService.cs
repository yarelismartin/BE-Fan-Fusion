using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface IStoryTagService
    {
        Task<(bool Success, string Message)> AddTagToStoryAsync(int tagId, int storyId);
        Task<(bool Success, string Message)> RemoveTagFromStoryAsync(int tagId, int storyId);

    }
}
