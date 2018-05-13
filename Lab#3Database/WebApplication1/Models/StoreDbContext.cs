using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication.BusinessLogic.DbModels;

namespace WebApplication1.Models
{
    public class StoreDbContext : DbContext
    {

        public StoreDbContext() : base("name=DataBaseStore")
        {

        }

        public DbSet<Smartphone> Smartphones { get; set; }

    }

}
