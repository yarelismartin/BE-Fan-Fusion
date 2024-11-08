using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Models
{

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Uid { get; set; }
        public List<Story>? Stories { get; set; }
        public List<Chapter>? Chapters { get; set; }
        public List<Story>? FavoritedStories { get; set; }

    }

}
