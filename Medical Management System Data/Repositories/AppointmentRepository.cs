using Medical_Management_System_Core.Entities;
using Medical_Management_System_Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Management_System_Data.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {

        private readonly DataContext _context;

        public AppointmentRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Appointment> AddAppointmentAsync(Appointment appointment)
        {
            _context.AppointmentList.Add(appointment);
          await  _context.SaveChangesAsync();
            return appointment;
        }

        public void DeleteAppointment(int id)
        {
            var appointment = GetById(id);
            _context.AppointmentList.Remove(appointment);
            _context.SaveChanges();
           // _context.AppointmentList.Remove(_context.AppointmentList.ToList().Find(c => c.AppointmentId == id));
        }

        public Appointment GetById(int id)
        {
            return _context.AppointmentList.Include(a=>a.Patient).First(c => c.AppointmentId == id);
        }

        public List<Appointment> GetAppointmentes()
        {
            return _context.AppointmentList.ToList();
        }

        public Appointment UpdateAppointment(int id, Appointment appointment)
        {
            var updateAppointmen = _context.AppointmentList.ToList().Find(u => u.AppointmentId == id);
            if (updateAppointmen != null)
            {
                updateAppointmen.PatientId = appointment.PatientId;
                return updateAppointmen;
            }
            return null;
        }
    }
}

