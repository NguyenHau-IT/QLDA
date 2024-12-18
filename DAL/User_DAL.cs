using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User_DAL
    {
        public List<User> GetAllUsers()
        {
            using (var context = new Cafe_Context())
            {
                return context.Users.ToList();
            }
        }

        public void AddUser(User user)
        {
            using (var context = new Cafe_Context())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            using (var context = new Cafe_Context())
            {
                var existingUsers = context.Users.Find(user.UserName);
                if (existingUsers != null)
                {
                    existingUsers.UserName = user.UserName;
                    existingUsers.Userpassword = user.Userpassword;
                    existingUsers.FullName = user.FullName;
                    existingUsers.Phone = user.Phone;
                    existingUsers.IdentityCard = user.IdentityCard;
                    existingUsers.RoleID = user.RoleID;
                    context.SaveChanges();
                }
            }
        }

        public void DeleteUser(string username)
        {
            using (var context = new Cafe_Context())
            {
                var user = context.Users.Find(username);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
            }
        }
    }
}
