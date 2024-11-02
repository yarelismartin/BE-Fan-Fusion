using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Repositories
{
    public class UserRepository : IUserRepository
    {
         
        private readonly FanFusionDbContext dbContext;

        public UserRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }
        public Task<User> CheckUserAsync(string userUid)
        {
            throw new NotImplementedException();
        }
        public Task<User> GetUserByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

    }
}

