using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;

namespace BE_Fan_Fusion.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FanFusionDbContext dbContext;

        public CategoryRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }
    }
}
