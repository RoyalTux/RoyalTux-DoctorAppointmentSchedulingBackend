﻿using DoctorAppointmentScheduling.Domain.Extensibility.Entities;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointmentScheduling.Domain.ModelBuilders
{
    public class AppointmentBuilder
    {
        public static void BuildAppointment(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);
            });
        }
    }
}