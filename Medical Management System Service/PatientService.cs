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

        public List<Patient> GetPatients()
        {
            return _patientRepository.GetPatients();
        }

        public Patient GetById(int id)
        {
            return _patientRepository.GetById(id);
        }

        public Patient AddPatient(Patient patient)
        {
            return _patientRepository.AddPatient(patient);
        }

        public Patient UpdatePatient(int id, Patient e)
        {
            return _patientRepository.UpdatePatient(id, e);
        }

        public void DeletePatient(int id)
        {
            _patientRepository.DeletePatient(id);
        }
    }
}
