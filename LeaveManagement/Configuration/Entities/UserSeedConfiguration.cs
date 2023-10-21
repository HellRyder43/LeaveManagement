using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();

            builder.HasData(
                new Employee
                {
                    Id = "0ab2ed75-74da-441c-bf9c-0cff68895f3e",
                    Email = "amirhamzah92.ka@gmail.com",
                    NormalizedEmail = "AMIRHAMZAH92.KA@GMAIL.COM",
                    UserName = "amirhamzah92.ka@gmail.com",
                    NormalizedUserName = "AMIRHAMZAH92.KA@GMAIL.COM",
                    FirstName = "Amir",
                    LastName = "Hamzah",
                    PasswordHash = hasher.HashPassword(null, "Aulian92$"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "210f8836-1773-4492-95f5-cb1b61980616",
                    Email = "ryder9243@gmail.com",
                    NormalizedEmail = "RYDER9243@GMAIL.COM",
                    UserName = "ryder9243@gmail.com",
                    NormalizedUserName = "RYDER9243@GMAIL.COM",
                    FirstName = "Auni",
                    LastName = "Dalilah",
                    PasswordHash = hasher.HashPassword(null, "Aulian92$"),
                    EmailConfirmed = true
                }
            );
        }
    }
}