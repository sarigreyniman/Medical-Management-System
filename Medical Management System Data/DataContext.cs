using Medical_Management_System_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Medical_Management_System_Data
{
    public class DataContext:  DbContext
    {
        public DbSet<Patient> PatientList { get; set; }

        public DbSet<Appointment> AppointmentList { get; set; }

        public DbSet<Prescription> PrescriptionList { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MedicalManagementSystem_db");
        }


    }
}
