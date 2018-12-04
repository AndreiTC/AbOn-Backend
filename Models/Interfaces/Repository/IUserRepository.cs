using Entities.Models.UserAggregate;

namespace Entities.Interfaces.Repository
{
    public interface IUserRepository
    {
        User AddUser(User user);
        User Authenticate(string name);
    }
}
