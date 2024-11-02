using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface IUserRepository
    {
        Task<User> CheckUser(string userUid);
        Task<User> GetUserById(int userId);

    }
}
