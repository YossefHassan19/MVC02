using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC02.Entities;

namespace MVC02.Contexts.Configurations
{
    public class MemberConfigurations : GymUserConfigurations<Member> , IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            //CreatedAt => JoinedAt
            builder.Property(x => x.CreatedAt)
                .HasColumnName("JoinedAt")
                .HasDefaultValueSql("GetDate()");

            base.Configure(builder); //Apply the base class configuration for GymUser
        }
    }
}
