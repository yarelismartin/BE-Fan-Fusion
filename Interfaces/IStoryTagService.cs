using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface IStoryTagService
    {
        Task<(bool Success, string Message)> AddTagToStory(int tagId, int storyId);
        Task<(bool Success, string Message)> RemoveTagFromStory(int tagId, int storyId);

    }
}
