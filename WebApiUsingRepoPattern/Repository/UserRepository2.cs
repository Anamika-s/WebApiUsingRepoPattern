using WebApiUsingRepoPattern.IRepository;
using WebApiUsingRepoPattern.Models;

//WRITE ADO.NET LOGIC

namespace WebApiUsingRepoPattern.Repository
{
    public class UserRepository2 : IUserRepository
    {
        public User AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(int id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
