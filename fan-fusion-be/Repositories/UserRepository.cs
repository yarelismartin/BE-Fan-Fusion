﻿using BE_Fan_Fusion.Data;
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
        public async Task<User?> CheckUserAsync(string userUid)
        {
            return await dbContext.Users.FirstOrDefaultAsync(u => u.Uid == userUid);
        }
        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await dbContext.Users
                .Include(s => s.FavoritedStories)
                .Include(s => s.Stories)
                .Include(s => s.Chapters)
                .SingleOrDefaultAsync(u => u.Id == userId);
        }

    }
}

