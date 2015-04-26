using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityManagementWebDotNet.DAL.Gateway
{
    public class Gateway:DbContext
    {
        public Gateway() : base("connection")
        {
            
        }
    }
}