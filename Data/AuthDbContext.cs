using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IKProje.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext>options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            var userRoleId = "57c031dd-e56b-4613-b5d3-903d4f79b573";
            var SuperAdminRoleId = "2db07232-1d0c-4605-aef1-14c2e0c531d2";
            var AdminRoleId = "8227d89f-6dfb-4e79-8e9e-8719e29aa101";




            var roles = new List<IdentityRole> { 
            
            new IdentityRole{
                Name="admin",
                NormalizedName="admin",
                Id=AdminRoleId,
                ConcurrencyStamp=AdminRoleId
            },
                 new IdentityRole{
                Name="SuperAdmin",
                NormalizedName="SuperAdmin",
                Id=SuperAdminRoleId,
                ConcurrencyStamp=SuperAdminRoleId
            },                   
                 new IdentityRole
                 {
                     Name = "User",
                     NormalizedName = "User",
                     Id =userRoleId,
                     ConcurrencyStamp =userRoleId
                 }

            };

            builder.Entity<IdentityRole>().HasData(roles);

            var SuperAdminId = "75eb826f-cb77-48d6-8272-11dca8b70015";
            var superAdminUser = new IdentityUser
            {
                UserName = "Burak",
                Id = SuperAdminId,
            };
            superAdminUser.PasswordHash = new PasswordHasher<IdentityUser>()
                .HashPassword(superAdminUser, "SuperAdmin.123");
            builder.Entity<IdentityUser>().HasData(superAdminUser);

            var superAdminRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId=AdminRoleId,
                    UserId=SuperAdminId,
                },
                new IdentityUserRole<string>
                {
                    RoleId=SuperAdminRoleId,
                    UserId=SuperAdminId,
                },
                new IdentityUserRole<string>
                {
                    RoleId=userRoleId,
                    UserId=SuperAdminId,
                }
            };

            builder.Entity<IdentityUserRole<string>>().HasData(superAdminRoles);


        }
    }
}
