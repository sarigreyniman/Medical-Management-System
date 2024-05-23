using Medical_Management_System_Core.Entities;
using Medical_Management_System_Core.Repositories;
using Medical_Management_System_Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Medical_Management_System_Service
{
    public class AppointmentService: IAppointmentService
    {

        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public List<Appointment> GetAppointmentesAsync()
        {
            return _appointmentRepository.GetAppointmentesAsync();
        }

        public Appointment GetByIdAsync(int id)
        {
            return _appointmentRepository.GetByIdAsync(id);
        }


        public Appointment AddAppointmentAsync(Appointment appointment)
        {
            return _appointmentRepository.AddAppointmentAsync(appointment);
        }

        public Appointment UpdateAppointmentAsync(int id, Appointment e)
        {
            return _appointmentRepository.UpdateAppointmentAsync(id, e);
        }

        public void DeleteAppointmentAsync(int id)
        {
            _appointmentRepository.DeleteAppointmentAsync(id);
        }

    }
}
