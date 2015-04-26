using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementWebDotNet.DAL.DAO
{
    public class Admin
    {
        public int Id{set;get;}
        public string UserName { set; get; }
        public string Password { set; get; }
    }
}