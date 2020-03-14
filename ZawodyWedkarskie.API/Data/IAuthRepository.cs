using System.Threading.Tasks;
using ZawodyWedkarskie.API.Models;

namespace ZawodyWedkarskie.API.Data
{
    public interface IAuthRepository
    {
        Task<Uzytkownik> Login(string Login, string Haslo);
        Task<Uzytkownik> Register(Uzytkownik user, string password);
        Task<bool> Exist(string Login);
    }
}