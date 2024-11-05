using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using BE_Fan_Fusion.Repositories;

namespace BE_Fan_Fusion.Services
{
    public class StoryTagService : IStoryTagService
    {
        private readonly IStoryTagRepository _storyTagRepository;

        public StoryTagService(IStoryTagRepository storyTagRepository)
        {
            _storyTagRepository = storyTagRepository;
        }
        public async Task<string> AddTagToStory(int tagId, int storyId)
        {
            return await _storyTagRepository.AddTagToStory(tagId, storyId);
        }
        public async Task<string> RemoveTagFromStory(int tagId, int storyId)
        {
            return await _storyTagRepository.RemoveTagFromStory(tagId, storyId);
        }
    }
}
