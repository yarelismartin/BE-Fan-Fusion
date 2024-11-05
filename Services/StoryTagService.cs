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
        public async Task<(bool Success, string Message)> AddTagToStory(int tagId, int storyId)
        {
            var story = await _storyTagRepository.GetStoryWithTags(storyId);
            if (story == null)
            {
                return (false, $"There is no story with the following id: {storyId}");
            }
            var tag = await _storyTagRepository.GetTagById(tagId);
            if (tag == null)
            {
                return (false, $"There is no tag with the following id: {tagId}");
            }

            if(story.Tags.Contains(tag))
            {
                return (false, "This story already has this tag.");
            }
            await _storyTagRepository.AddTag(story, tag);
            return ( true, "Tag added to the story successfully");

        }
        public async Task<string> RemoveTagFromStory(int tagId, int storyId)
        {
            return await _storyTagRepository.RemoveTagFromStory(tagId, storyId);
        }
    }
}
