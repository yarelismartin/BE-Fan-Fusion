using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;

namespace BE_Fan_Fusion.Repositories
{
    public class UserRepository : IUserRepository
    {
         {
        private readonly FanFusionDbContext dbContext;

        public UserRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }
    }
}
}
