using Medical_Management_System_Core.Entities;
using Medical_Management_System_Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Management_System_Data.Repositories
{
    public class PatientRepository:IPatientRepository
    {

        private readonly DataContext _context;

        public PatientRepository(DataContext context)
        {
            _context = context;
        }

        public Patient AddPatient(Patient patient)
        {
            _context.PatientList.Add(patient);
            return patient;
        }

        public void DeletePatient(int id)
        {
            _context.PatientList.Remove(_context.PatientList.ToList().Find(c => c.PatientId == id));
        }

        public Patient GetById(int id)
        {
            return _context.PatientList.First(c => c.PatientId == id);
        }

        public List<Patient> GetPatients()
        {
            return _context.PatientList.ToList();
        }

        public Patient UpdatePatient(int id, Patient patient)
        {
            var updatePatient = _context.PatientList.ToList().Find(u => u.PatientId == id);
            if (updatePatient != null)
            {
                updatePatient.PatientName = patient.PatientName;
                return updatePatient;
            }
            return null;
        }

    }
}
