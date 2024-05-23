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
    public class PatientService:IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public List<Patient> GetPatientsAsync()
        {
            return _patientRepository.GetPatientsAsync();
        }

        public Patient GetByIdAsync(int id)
        {
            return _patientRepository.GetByIdAsync(id);
        }

        public Patient AddPatientAsync(Patient patient)
        {
            return _patientRepository.AddPatientAsync(patient);
        }

        public Patient UpdatePatientAsync(int id, Patient e)
        {
            return _patientRepository.UpdatePatientAsync(id, e);
        }

        public void DeletePatientAsync(int id)
        {
            _patientRepository.DeletePatientAsync(id);
        }
    }
}
