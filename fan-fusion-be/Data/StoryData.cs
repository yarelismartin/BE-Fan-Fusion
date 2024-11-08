using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Data
{
    public class StoryData
    {
        public static List<Story> Stories = new()
        {
           new()
            {
                Id = 1,
                Title = "A Second Chance at Hogwarts",
                Description = "A time-travel story where Harry returns to his first year to fix everything.",
                Image = "https://images.unsplash.com/photo-1527684651001-731c474bbb5a?q=80&w=2787&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                DateCreated = new DateTime(2024, 10, 01),
                TargetAudience = "Young Adult",
                UserId = 15,
                CategoryId = 3 // Fantasy
            },
            new()
            {
                Id = 2,
                Title = "Galactic Refuge",
                Description = "Two rival bounty hunters must work together to survive an intergalactic chase.",
                Image = "https://images.unsplash.com/photo-1692800148019-2f17672c1d57?q=80&w=2160&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                DateCreated = new DateTime(2024, 09, 28),
                TargetAudience = "New Adult",
                UserId = 14,
                CategoryId = 4 // Science Fiction
            },
            new()
            {
                Id = 3,
                Title = "Heartstrings",
                Description = "A romance between a concert violinist and the mysterious pianist next door.",
                Image = "https://images.unsplash.com/photo-1624367171718-14026220ee35?q=80&w=2787&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                DateCreated = new DateTime(2024, 10, 05),
                TargetAudience = "Adult",
                UserId = 13,
                CategoryId = 1 // Romance
            },
            new()
            {
                Id = 4,
                Title = "The Laughing Detective",
                Description = "A detective with a love for pranks solves cases with humor.",
                Image = "https://i.pinimg.com/564x/87/ef/aa/87efaa9ba7edde6a0767494276e5e4ed.jpg",
                DateCreated = new DateTime(2024, 10, 07),
                TargetAudience = "Young Adult",
                UserId = 12,
                CategoryId = 11 // Humor
            },
            new()
            {
                Id = 5,
                Title = "Castle of Shadows",
                Description = "An exiled prince returns to reclaim his haunted castle.",
                Image = "https://images.unsplash.com/photo-1680456693517-bebac4b68f54?q=80&w=2788&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                DateCreated = new DateTime(2024, 10, 12),
                TargetAudience = "New Adult",
                UserId = 11,
                CategoryId = 7 // Supernatural
            },
            new()
            {
                Id = 6,
                Title = "Into the Abyss",
                Description = "A group of teenagers discovers a portal to a parallel world.",
                Image = "https://images.unsplash.com/photo-1569008593571-a98b326533a3?w=800&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjN8fHRlZW5zJTIwZmFudGFzeXxlbnwwfHwwfHx8MA%3D%3D",
                DateCreated = new DateTime(2024, 09, 15),
                TargetAudience = "Young Adult",
                UserId = 10,
                CategoryId = 4 // Science Fiction
            },
            new()
            {
                Id = 7,
                Title = "Café Encounters",
                Description = "A series of heartwarming meetings at a small-town coffee shop.",
                Image = "https://images.unsplash.com/photo-1616091216791-a5360b5fc78a?q=80&w=2795&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                DateCreated = new DateTime(2024, 09, 22),
                TargetAudience = "Adult",
                UserId = 1,
                CategoryId = 8 // Slice of Life
            },
            new()
            {
                Id = 8,
                Title = "Whispers in the Dark",
                Description = "A ghost helps a troubled author find peace through her writing.",
                Image = "https://images.unsplash.com/photo-1577081320692-6eff449819c0?w=800&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NDJ8fGdob3N0JTIwbGFkeXxlbnwwfHwwfHx8MA%3D%3D",
                DateCreated = new DateTime(2024, 10, 02),
                TargetAudience = "New Adult",
                UserId = 2,
                CategoryId = 7 // Supernatural
            },
            new()
            {
                Id = 9,
                Title = "Heroes and Villains",
                Description = "A villain falls in love with the hero sworn to defeat them.",
                Image = "https://i.pinimg.com/736x/dc/10/7c/dc107cb9703713233c63c5a2e0d954e2.jpg",
                DateCreated = new DateTime(2024, 09, 30),
                TargetAudience = "Young Adult",
                UserId = 3,
                CategoryId = 14 // Crossover
            },
            new()
            {
                Id = 10,
                Title = "Letters from the Past",
                Description = "Old letters reveal a forgotten love story between two soldiers.",
                Image = "https://i.pinimg.com/564x/89/8d/a6/898da60f9434db2c4bf5f142abe8af67.jpg",
                DateCreated = new DateTime(2024, 09, 18),
                TargetAudience = "Adult",
                UserId = 4,
                CategoryId = 10 // Historical Fiction
            },
            new()
            {
                Id = 11,
                Title = "The Last Stand",
                Description = "A warrior prepares for a final battle, haunted by visions of the future.",
                Image = "https://i.pinimg.com/736x/06/8c/54/068c54bae09a0de9a39ffc2590829b37.jpg",
                DateCreated = new DateTime(2024, 10, 08),
                TargetAudience = "New Adult",
                UserId = 5,
                CategoryId = 3 // Fantasy
            },
            new()
            {
                Id = 12,
                Title = "Comedy of Errors",
                Description = "A mix-up at a royal wedding leads to a cascade of hilarious events.",
                Image = "https://i.pinimg.com/736x/ca/0e/8c/ca0e8c618ae502879f58db63d82c147d.jpg",
                DateCreated = new DateTime(2024, 10, 04),
                TargetAudience = "Young Adult",
                UserId = 6,
                CategoryId = 11 // Humor
            },
            new()
            {
                Id = 13,
                Title = "Between the Lines",
                Description = "Two writers leave coded messages for each other in their novels.",
                Image = "https://i.pinimg.com/564x/24/4c/fa/244cfab30f2497b6b78c91b4065ed3c8.jpg",
                DateCreated = new DateTime(2024, 09, 25),
                TargetAudience = "Adult",
                UserId = 7,
                CategoryId = 12 // Drama
            },
            new()
            {
                Id = 14,
                Title = "The Midnight Express",
                Description = "A secret train only appears to those in need of second chances.",
                Image = "https://i.pinimg.com/736x/63/1c/d7/631cd71a58e19362c662758289e769c8.jpg",
                DateCreated = new DateTime(2024, 10, 03),
                TargetAudience = "Young Adult",
                UserId = 8,
                CategoryId = 7 // Supernatural
            },
            new()
            {
                Id = 15,
                Title = "Parallel Paths",
                Description = "A scientist and an artist explore love across multiple dimensions.",
                Image = "https://i.pinimg.com/736x/62/ae/08/62ae08e882f6c1098dd6a336e7a4508f.jpg",
                DateCreated = new DateTime(2024, 09, 20),
                TargetAudience = "New Adult",
                UserId = 9,
                CategoryId = 4 // Science Fiction
            }
        };

    }
}