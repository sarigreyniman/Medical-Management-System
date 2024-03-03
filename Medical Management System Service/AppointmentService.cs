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

        public List<Appointment> GetAppointmentes()
        {
            return _appointmentRepository.GetAppointmentes();
        }

        public Appointment GetById(int id)
        {
            return _appointmentRepository.GetById(id);
        }


        public Appointment AddAppointment(Appointment appointment)
        {
            return _appointmentRepository.AddAppointment(appointment);
        }

        public Appointment UpdateAppointment(int id, Appointment e)
        {
            return _appointmentRepository.UpdateAppointment(id, e);
        }

        public void DeleteAppointment(int id)
        {
            _appointmentRepository.DeleteAppointment(id);
        }

    }
}
