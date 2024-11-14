using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class BPT_DbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Measurement> Measurements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("FIX");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasKey(p => p.SSN);

            modelBuilder.Entity<Measurement>()
                .HasKey(m => m.ID);

            modelBuilder.Entity<Measurement>()
                .HasOne(m => m.Patient)
                .WithMany(p => p.Measurements)
                .HasForeignKey(m => m.PatientSSN);
        }
    }
}
