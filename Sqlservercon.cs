using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StackoverServiceTestnet.IService1;

namespace StackoverServiceTestnet
{
    public class Sqlservercon
    {
        public UserData Selectuser(string username)
        {
            UserData user = new UserData();
            user.Email = "Test";
            user.Name = "Test";
            user.Password = "Test";
            return user;
        }
        public UserData Adduser(UserData userdata)
        {
            UserData user = new UserData();
            user.Email = "Test";
            user.Name = "Test";
            user.Password = "Test";
            return user;
        }
        public UserData Updateuser(UserData userdata)
        {
            UserData user = new UserData();
            user.Email = "Test";
            user.Name = "Test";
            user.Password = "Test";
            return user;
        }
        public UserData Deleteuser(UserData userdata)
        {
            UserData user = new UserData();
            user.Email = "Test";
            user.Name = "Test";
            user.Password = "Test";
            return user;
        }
    }
}
