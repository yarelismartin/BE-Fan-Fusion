using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface IStoryTagRepository
    {
        Task<Story?> GetStoryWithTagsAsync(int storyId);
        Task<Tag?> GetTagByIdAsync(int tagId);
        Task AddTagAsync(Story story, Tag tag);
        Task RemoveTagAsync(Story story, Tag tag);
    }
}
