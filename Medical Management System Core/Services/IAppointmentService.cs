using Medical_Management_System_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Management_System_Core.Services
{
    public interface IAppointmentService
    {
        List<Appointment> GetAppointmentes();

        Appointment GetById(int id);

        Appointment AddAppointment(Appointment appointment);

        Appointment UpdateAppointment(int id, Appointment appointment);

        void DeleteAppointment(int id);
    }
}
