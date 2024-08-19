using WebApiUsingRepoPattern.Context;
using WebApiUsingRepoPattern.IRepository;
using WebApiUsingRepoPattern.Models;

namespace WebApiUsingRepoPattern.Repository
{
    public class UserRepository : IUserRepository
    {
        // DI 
        UserDbContext _context;
        public UserRepository(UserDbContext context)
        {
            _context = context;
        }
        public User AddUser(User user)
        {
           _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public bool DeleteUser(int id)
        {
            foreach (var user in _context.Users)
            {
                if (user.UserId == id)
                {
                    _context.Users.Remove(user);
                    break;
                }
            }
            _context.SaveChanges();
            return true;
        }

        public User GetById(int id)
        {
            User temp=null;
            foreach (var user in _context.Users)
            {
                if (user.UserId == id)
                {
                   temp = user;
                    break;
                }
            }
            return temp;
        }

        public List<User> GetUsers()
        {
           return   _context.Users.ToList();
        }

        public bool UpdateUser(int id, User user)
        {
            foreach (var obj in _context.Users)
            {
                if (obj.UserId == id)
                {
                    obj.UserName = user.EMail;
                    break;
                }
            }
            _context.SaveChanges();
            return true;
        }
    }
}
