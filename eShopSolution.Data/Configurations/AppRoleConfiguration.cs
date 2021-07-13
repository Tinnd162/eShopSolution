using eShopSolution.Data.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class AppRoleConfiguration :IEntityTypeConfiguration<AppRole>
    {

        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("AppRoles").HasKey(x=>x.Id);
            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();

            builder.HasMany<IdentityRoleClaim<Guid>>().WithOne().HasForeignKey(x => x.RoleId).IsRequired();
            builder.HasMany<IdentityUserRole<Guid>>().WithOne().HasForeignKey(x => x.RoleId).IsRequired();
        }
    }
}

