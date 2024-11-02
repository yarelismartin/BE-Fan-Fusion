using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public async Task<List<Tag>> GetAllTagsAsync()
        {
            return await _tagRepository.GetAllTagsAsync();
        }
        public async Task<Tag> GetTagByIdAsync(int tagId)
        {
            return await _tagRepository.GetTagByIdAsync(tagId);
        }
    }
}
