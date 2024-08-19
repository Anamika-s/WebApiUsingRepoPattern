using WebApiUsingRepoPattern.Models;

namespace WebApiUsingRepoPattern.IRepository
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
        public User GetById(int id);    
        public User AddUser(User user);
        public bool UpdateUser(int id, User user);
        public bool DeleteUser(int id);
    }
}
