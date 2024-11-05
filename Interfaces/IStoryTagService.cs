﻿using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface IStoryTagService
    {
        Task<string> AddTagToStory(int tagId, int storyId);
        Task<string> RemoveTagFromStory(int tagId, int storyId);

    }
}
