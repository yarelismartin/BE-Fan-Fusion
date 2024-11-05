using BE_Fan_Fusion.DTO;
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
        public async Task<List<TagDto>> GetAllTagsAsync()
        {
            var allTags = await _tagRepository.GetAllTagsAsync();
            return allTags.Select(tag => new TagDto(tag)).ToList();
        }
        public async Task<Tag> GetTagByIdAsync(int tagId)
        {
            return await _tagRepository.GetTagByIdAsync(tagId);
        }
    }
}
