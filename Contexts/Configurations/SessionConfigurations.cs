using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC02.Entities;

namespace MVC02.Contexts.Configurations
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x => x.CreatedAt)
                .HasDefaultValueSql("GetDate()");

            builder.HasOne(x => x.Trainer)
                .WithMany(x => x.Sessions)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("SessionCapacityCheck", "Capacity between 1 and 25");
                T.HasCheckConstraint("SessionEndDateCheck", "EndDate > CreatedAt");
            });
        }
    }
}
