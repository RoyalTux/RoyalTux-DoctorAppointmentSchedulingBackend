﻿using DoctorAppointmentScheduling.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointmentScheduling.Domain.ModelBuilders
{
    public class DoctorBuilder
    {
        public static void BuildDoctor(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Bio)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasMany(e => e.Specializations);

                entity.HasMany(e => e.Appointments);
            });
        }
    }
}
