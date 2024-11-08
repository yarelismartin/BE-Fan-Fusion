using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using Microsoft.EntityFrameworkCore;



namespace BE_Fan_Fusion.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FanFusionDbContext dbContext;

        public CategoryRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await dbContext.Categories.ToListAsync();
        }
    }
}
