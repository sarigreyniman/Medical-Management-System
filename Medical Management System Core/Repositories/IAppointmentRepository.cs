using Medical_Management_System_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Management_System_Core.Repositories
{
    public interface IAppointmentRepository
    {
        Task<List<Appointment>> GetAppointmentesAsync(); 

        Task<Appointment> GetByIdAsync(int id);  

        Task<Appointment> AddAppointmentAsync(Appointment appointment);  

        Task<Appointment> UpdateAppointmentAsync(int id, Appointment appointment);  

        Task DeleteAppointmentAsync(int id); 
    }
}
