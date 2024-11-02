﻿using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime DateCreated { get; set; }
        public string TargetAudience { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Chapter> Chapters { get; set; }

    }

}
