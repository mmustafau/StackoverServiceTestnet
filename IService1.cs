using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StackoverServiceTestnet
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.

    
        [ServiceContract]
        [CustContractBehavior]
        public interface IService1
        {
            [OperationContract]
            [WebInvoke(Method = "GET", UriTemplate = "user/{name}", ResponseFormat = WebMessageFormat.Json)]
            Result GetUserData(string name);

            [OperationContract]
            [WebInvoke(Method = "POST", UriTemplate = "user", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            Result PostUserData(UserData user);
            [OperationContract]
            [WebInvoke(Method = "PUT", UriTemplate = "user", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            Result PutUserData(UserData user);
            [OperationContract]
            [WebInvoke(Method = "DELETE", UriTemplate = "user", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            Result DeleteUserData(UserData user);
        }
        [DataContract(Name = "user")]
        public class UserData
        {
            [DataMember(Name = "Name")]
            public string Name { get; set; }
            [DataMember(Name = "Password")]
            public string Password { get; set; }
            [DataMember(Name = "Email")]
            public string Email { get; set; }
        }
        [DataContract(Name = "Result")]
        public class Result
        {
            [DataMember(Name = "Stu")]
            public string Stu { get; set; }
            [DataMember(Name = "Code")]
            public int Code { get; set; }
            [DataMember(Name = "UserData")]
            public UserData userData { get; set; }
        }
    }

