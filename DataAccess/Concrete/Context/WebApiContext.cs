using DataAccess.Concrete.EntityFramework.Mapping;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
	public class WebApiContext:DbContext
	{
		//public Context(DbContextOptions<Context> options) : base(options)
		//{
		//}

		//protected Context()
		//{
		//}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=ECommerceDb;Trusted_Connection=true;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserMap());
		}

        public DbSet<User> User { get; set; }
    }
}
