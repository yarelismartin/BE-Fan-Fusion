using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using Microsoft.EntityFrameworkCore;

namespace BE_Fan_Fusion.Repositories
{
    public class UserRepository : IUserRepository
    {
         
        private readonly FanFusionDbContext dbContext;

        public UserRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }
        public async Task<User> CheckUserAsync(string userUid)
        {
            return await dbContext.Users.FirstOrDefaultAsync(u => u.Uid == userUid);
        }
        public async Task<User> GetUserByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

    }
}

