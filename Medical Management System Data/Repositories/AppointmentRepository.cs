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

        public async Task<List<Appointment>> GetAppointmentesAsync()
        {
            return await _context.AppointmentList.ToListAsync();
        }

        public async Task<Appointment> AddAppointmentAsync(Appointment appointment)
        {
            _context.AppointmentList.Add(appointment);
            await _context.SaveChangesAsync();
            return appointment;
        }

        public async Task DeleteAppointmentAsync(int id)
        {
            var appointment = await GetByIdAsync(id);
            if (appointment != null)
            {
                _context.AppointmentList.Remove(appointment);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Appointment> GetByIdAsync(int id)
        {
            return await _context.AppointmentList.Include(a => a.Patient).FirstOrDefaultAsync(c => c.AppointmentId == id);
        }
        public async Task<Appointment> UpdateAppointmentAsync(int id, Appointment appointment)
        {
            var updateAppointmen = await _context.AppointmentList.FindAsync(id);
            if (updateAppointmen != null)
            {
                updateAppointmen.PatientId = appointment.PatientId;
                await _context.SaveChangesAsync();
                return updateAppointmen;
            }
            return null;
        }
    }
}

