﻿using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> CheckUserAsync(string userUid);
        Task<User?> GetUserByIdAsync(int userId);

    }
}
