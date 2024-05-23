using Medical_Management_System_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Management_System_Core.Repositories
{
    public interface IPatientRepository
    {

        List<Patient> GetPatientsAsync();

        Patient GetByIdAsync(int id);

        Patient AddPatientAsync(Patient patient);

        Patient UpdatePatientAsync(int id, Patient patient);

        void DeletePatientAsync(int id);
    }
}
