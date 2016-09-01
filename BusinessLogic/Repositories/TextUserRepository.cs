using BusinessLogic.DBContextDomain;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repositories
{
    public class TextUserRepository : IUserRepository
    {
        private User user = new User();

        public User GetByUserNameAndPassword(string userName, string password)
        {
            using (var context = new PhoneBookContext())
            {
                user = context.Users.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
            
            };

            return user;
        }

        public User GetById(int id)
        {
            using (var context = new PhoneBookContext())
            {
                user = context.Users.Where(x => x.Id == id).FirstOrDefault();

            };

            return user;
        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            using (var context = new PhoneBookContext())
            {
                users = context.Users.ToList();
            }
            return users;
        }

        public void Add(User item)
        {
            user.UserName = item.UserName;
            user.Password = item.Password;
            user.FirstName = item.FirstName;
            user.LastName = item.LastName;

            using (var context = new PhoneBookContext())
            {
                context.Users.Add(user);
                context.SaveChanges();              
            }
        }

        public void Update(User item)
        {
            user = GetById(item.Id);

            if (user != null)
            {
                user.UserName = item.UserName;
                user.Password = item.Password;
                user.FirstName = item.FirstName;
                user.LastName = item.LastName;
            }
            else
            {
                throw new ArgumentNullException("Please choose user to update");                  
            }

            using (var context = new PhoneBookContext())
            {
                context.Users.Attach(user);
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(User item)
        {
            user = GetById(item.Id);

            if (user == null)
            {
                throw new ArgumentNullException("Please choose user to delete");
            }

            using (var context = new PhoneBookContext())
            {
                context.Users.Attach(user);
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }
    }
}
