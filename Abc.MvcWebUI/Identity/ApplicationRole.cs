using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Abc.MvcWebUI.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string Descriptpon { get; set; }

        public ApplicationRole()
        {

        }

        public ApplicationRole(string rolename,string description)
        {
            this.Descriptpon = description;
        }
    }
}