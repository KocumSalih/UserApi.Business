using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApi.DAL.Context.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using UserApi.Entities;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t0 => t0.Id);
            builder.Property(t0 => t0.Id).UseIdentityColumn();
            builder.Property(t0 => t0.Name).HasMaxLength(100).IsRequired();
            builder.Property(t0 => t0.Surname).HasMaxLength(100).IsRequired();
            builder.Property(t0 => t0.UserName).HasMaxLength(100).IsRequired();
            builder.Property(t0 => t0.Password).HasMaxLength(100).IsRequired();
            builder.Property(t0 => t0.Email).HasMaxLength(100);
            builder.Property(t0 => t0.Phone).HasMaxLength(100);
            builder.Property(t0 => t0.Address).HasMaxLength(100);
        }
    }
}
