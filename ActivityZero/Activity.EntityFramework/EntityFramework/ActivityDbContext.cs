﻿using System.Data.Common;
using Abp.Zero.EntityFramework;
using Activity.Authorization.Roles;
using Activity.MultiTenancy;
using Activity.Users;
using System.Data.Entity;
using Activity.Entities;
namespace Activity.EntityFramework
{
    public class ActivityDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<Menu> Menus { get; set; }
        public virtual IDbSet<Activity.Entities.Activity> Activities { get; set; }
        public virtual IDbSet<Activity.Entities.ActivityItem> ActiviyItems { get; set; }
        public virtual IDbSet<Activity.Entities.ActivityCatagory> ActivityCatagories { get; set; }
        public virtual IDbSet<Activity.Entities.Discuss> Discusses { get; set; }
       
        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ActivityDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ActivityDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ActivityDbContext since ABP automatically handles it.
         */
        public ActivityDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ActivityDbContext(DbConnection connection)
            : base(connection, true)
        {

        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties().Where(p => p.DeclaringType == typeof(string)).Configure(p => p.HasMaxLength(1000));

            modelBuilder.Properties().Where(p => p.DeclaringType == typeof(string)).Configure(p => p.HasColumnType("NVarchar"));
        }
    }
}
