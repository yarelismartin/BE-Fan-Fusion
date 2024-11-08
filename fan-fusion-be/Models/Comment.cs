using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public int ChapterId { get; set; }
        public Chapter Chapter { get; set; }


    }


}
