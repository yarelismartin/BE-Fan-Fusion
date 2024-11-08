using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.DTO
{
    public class StoryDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsFavorited { get; set; }
        public StoryDTO(Story story, bool isFavorited)
        {
            Id = story.Id;
            Title = story.Title;
            Image = story.Image;
            DateCreated = story.DateCreated;
            IsFavorited = isFavorited;
        }
    }
}
