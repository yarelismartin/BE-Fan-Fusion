using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.DTO
{
    public class TagDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TagDto(Tag tag) 
        {
            Id = tag.Id;
            Name = tag.Name;
        }
    }
}

