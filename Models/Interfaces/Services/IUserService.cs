using Entities.Models.UserAggregate;

namespace Entities.Interfaces.Services
{
    public interface IUserService
    {
        User AddUser(User user);
        User Authenticate(string name, string password,string secret);
    }
}
