using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "e5dc40e3-44bd-45c8-a9d9-7176ad4ee329",
                    UserId = "0ab2ed75-74da-441c-bf9c-0cff68895f3e"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "1ccb8b30-835b-4a0c-894c-9a88d2908b50",
                    UserId = "210f8836-1773-4492-95f5-cb1b61980616"
                }
            );
        }
    }
}