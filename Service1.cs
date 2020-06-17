using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static StackoverServiceTestnet.IService1;

namespace StackoverServiceTestnet
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
 
        public class Service1 : IService1
        {
            Sqlservercon sqlservercon = new Sqlservercon();

            public Result PostUserData(UserData user)
            {
                Result result = new Result();
                if (GetUserData(user.Name).Code == 400)
                {
                    sqlservercon.Adduser(user);
                    result.Code = 200;
                    result.Stu = user.Name + "Success";
                    result.userData = user;
                    return result;
                }
                else
                {
                    result.Code = 400;
                    result.Stu = user.Name + "fail";
                    return result;
                }
            }

            public Result DeleteUserData(UserData user)
            {
                Result result = new Result();
                if (GetUserData(user.Name).Code == 400)
                {
                    result.Code = 400;
                    result.Stu = user.Name + "fail";
                    return result;
                }
                else
                {
                    sqlservercon.Deleteuser(user);
                    result.Code = 200;
                    result.Stu = user.Name + "Success！";
                    result.userData = user;
                    return result;
                }
            }
            static List<Result> results = new List<Result>();
            public Result GetUserData(string name)
            {
                UserData userData = sqlservercon.Selectuser(name);
                Result result = new Result();
                if (userData.Name != "")
                {
                    result.userData = userData;
                    result.Code = 200;
                    result.Stu = "Success";
                    results.Add(result);
                    Console.WriteLine(results.Count);
                    return result;
                }
                else
                {
                    result.Code = 400;
                    result.Stu = "fail";
                    return result;
                }


            }
            public Result PutUserData(UserData user)
            {
                Result result = new Result();
                if (GetUserData(user.Name).Code == 400)
                {
                    result.Code = 400;
                    result.Stu = user.Name + "fail";
                    return result;
                }
                else
                {
                    sqlservercon.Updateuser(user);
                    result.Code = 200;
                    result.Stu = user.Name + "Success";
                    result.userData = user;
                    return result;
                }
            }
        }
    }

