using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trips.Booking.Core.Entities;

namespace Trips.Booking.Infrastructure.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(x => x.Email).IsRequired();
            builder.HasOne(x => x.Trip).WithMany()
                .HasForeignKey(x => x.TripId);
        }
    }
}
