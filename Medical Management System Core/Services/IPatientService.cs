using Medical_Management_System_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Management_System_Core.Services
{
    public interface IPatientService
    {
        List<Patient> GetPatients();

        Patient GetById(int id);

       Patient AddPatient(Patient patient);

        Patient UpdatePatient(int id, Patient patient);

        void DeletePatient(int id);
    }
}
