using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meetingapp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo(){Id = 1, Name = "Emirhan", Email = "emirhan@gmail.com", Phone = "11111", WillAttend = true});
            _users.Add(new UserInfo(){Id = 2, Name = "Ekrem", Email = "ekrem@gmail.com", Phone = "22222", WillAttend = false});
            _users.Add(new UserInfo(){Id = 3, Name = "Selcuk", Email = "selcuk@gmail.com", Phone = "33333", WillAttend = true});
            _users.Add(new UserInfo(){Id = 4, Name = "Efe", Email = "efe@gmail.com", Phone = "88888", WillAttend = false});
        } 

        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user){
            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}