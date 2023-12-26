using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        
            [Key]
            
            public DbSet<Blog> Blogs { get; set; }
            //public DbSet<Context> Contexts { get; set; }
           
            public DbSet<Yorumlar> Yorumlars { get; set; }




        
    }
}