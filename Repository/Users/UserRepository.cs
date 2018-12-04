using Context;
using Entities.Interfaces.Repository;
using Entities.Models.UserAggregate;
using System.Linq;

namespace Repository.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly AbOnContext _dbContext;
        public UserRepository(AbOnContext dbContext)
        {
                _dbContext = dbContext;
            }

        public User AddUser(User user)
        {
            _dbContext.User.Add(user);
            _dbContext.SaveChanges();
            return user;
        }

        public User Authenticate(string name)
        {
            var toReturn = _dbContext.User.FirstOrDefault(x => x.Name == name);
            return toReturn;
        }
    }
}
