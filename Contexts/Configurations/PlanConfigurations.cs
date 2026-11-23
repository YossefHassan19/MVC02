using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC02.Entities;

namespace MVC02.Contexts.Configurations
{
    public class PlanConfigurations : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(x => x.CreatedAt)
                .HasDefaultValueSql("GetDate()");

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("PlanDurationDaysCheck", "DurationDays between 1 and 365");
            });
        }
    }
}
