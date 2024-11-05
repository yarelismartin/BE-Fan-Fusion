using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface IStoryTagRepository
    {
        Task<Story?> GetStoryWithTags(int storyId);
        Task<Tag?> GetTagById(int tagId);
        Task AddTag(Story story, Tag tag);
        Task RemoveTag(Story story, Tag tag);
    }
}
