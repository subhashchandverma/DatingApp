using DatingApp.API.Models;
using System.Threading.Tasks;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string passowrd);
        
        Task<User> Login(string username, string passwrod);

        Task<bool> UserExists(string username);
    }
}
