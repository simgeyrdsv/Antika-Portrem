using Abc.MvcWebUI.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            if(!context.Roles.Any(i=> i.Name =="admin" ))
            {
                var store =new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "admin", Descriptpon = "admin rolü" };

                manager.Create(role);

            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Descriptpon = "user rolü" };

                manager.Create(role);

            }

            if (!context.Users.Any(i => i.Name == "simgeyrdsv"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Simge", Surname = "Yurdusev", UserName = "simgeyrdsv", Email = "simge54yurdusev@gmail.com" };


                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }
            if (!context.Users.Any(i => i.Name == "zümrayrdsv"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "zümra", Surname = "yurdusev", UserName = "zümrayrdsv", Email = "zümrayrdsv@gmail.com" };


                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "user");
            }




            base.Seed(context);
        }
    }
}