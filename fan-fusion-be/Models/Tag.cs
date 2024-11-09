using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Models
{

    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Story> Stories { get; set; }

    }

}
