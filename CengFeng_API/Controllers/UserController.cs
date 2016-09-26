using CengFeng_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Newtonsoft.Json;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
namespace CengFeng_API.Controllers
{
    public class UserController : ApiController
    {
        //[System.Web.Http.HttpGet]
        //[System.Web.Http.HttpPost]
        public List<Users> GetUser()
        {
            var _list = new List<Users> {
                new Users { Id = 1, UName = "张三", Uage = 18, UAddress = "AAA" },
                new Users { Id = 1, UName = "李四", Uage = 18, UAddress = "BBB" },
                new Users { Id = 1, UName = "王五", Uage = 18, UAddress = "CCC" }
            };
            return _list;
        }
 
        public string GetName(string name)
        {
            return String.Format("姓名：{0}", name);
        }
        public string GetName(string name,int age)
        {
            return String.Format("'姓名'：'{0}','年龄':{1}", name,age.ToString());
        }

    }

    public class Users
    {
        public int Id { get; set; }
        public string UName { get; set; }
        public int Uage { get; set; }
        public string UAddress { get; set; }
    }
}
