using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FanFusionDbContext dbContext;

        public CategoryRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }

        public Task<List<Category>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
