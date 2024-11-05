using BE_Fan_Fusion.DTO;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface ITagService
    {
        Task<List<TagDto>> GetAllTagsAsync();
        Task<Tag> GetTagByIdAsync(int tagId);

    }
}
