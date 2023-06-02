using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	public class UserMap : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.ToTable("users",@"dbo");

			builder.HasKey(t => t.Id);

			builder.Property(x=>x.UserName).HasColumnName("UserName").HasMaxLength(50).IsRequired();
			builder.Property(x=>x.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
			builder.Property(x=>x.LastName).HasColumnName("LastName").HasMaxLength(50).IsRequired();
			builder.Property(x=>x.Password).HasColumnName("Password").HasMaxLength(50).IsRequired();
			builder.Property(x=>x.Gender).HasColumnName("Gender").HasMaxLength(50).IsRequired();
			builder.Property(x=>x.DateOfBirth).HasColumnName("DateOfBirth").HasMaxLength(50).IsRequired();
			builder.Property(x=>x.CreatedDate).HasDefaultValue(DateTime.Now);
		}
		
	}
}
