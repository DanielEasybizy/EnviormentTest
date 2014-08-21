using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using EnviormentTest.Models;

namespace EnviormentTest.App_Start
{
    public class EnviormentTestContext : DbContext
    {
        public DbSet<Thing> Things { get; set; }

        public EnviormentTestContext() : base("EnviormentTest")
        {
        }
    }
}