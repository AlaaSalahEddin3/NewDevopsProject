using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectWebApi.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext() : base("CS")
        {

        }
        public virtual DbSet<Order> orders { get; set; }
    }
}