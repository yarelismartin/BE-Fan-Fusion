using System;
using BE_Fan_Fusion.Models;
using Microsoft.EntityFrameworkCore;

namespace BE_Fan_Fusion.Data
{
    public class FanFusionDbContext : DbContext
    {
        public DbSet<Story> Stories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Category> Categories { get; set; }

        public FanFusionDbContext(DbContextOptions<FanFusionDbContext> context) : base(context)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                    // Configures the User entity to have many FavoritedStories
                    .HasMany(u => u.FavoritedStories)
                    // Configures the relationship such that each Story can be favorited by many Users
                    .WithMany(s => s.FavoritedByUsers)
                    // Specifies that the join table won’t have a separate class; instead, it will just store key-value pairs for the foreign keys.
                    .UsingEntity<Dictionary<string, object>>(
                        "UserFavoriteStory", // The name of the join table
                        j => j.HasOne<Story>() // Configures the join entity to reference the Story
                            .WithMany() // Specifies that the Story can have many User favorites
                            .HasForeignKey("StoryId"), // Defines the foreign key for the Story
                        j => j.HasOne<User>() // Configures the join entity to reference the User
                            .WithMany() // Specifies that the User can have many favorited Stories
                            .HasForeignKey("UserId") // Defines the foreign key for the User
                    );

              modelBuilder.Entity<Story>().HasData(StoryData.Stories);

              modelBuilder.Entity<Tag>().HasData(TagData.Tags);

              modelBuilder.Entity<User>().HasData(UserData.Users);

              modelBuilder.Entity<Chapter>().HasData(ChapterData.Chapters);

              modelBuilder.Entity<Comment>().HasData(CommentData.Comments);

              modelBuilder.Entity<Category>().HasData(CategoryData.Categories);

        }


    }
}
