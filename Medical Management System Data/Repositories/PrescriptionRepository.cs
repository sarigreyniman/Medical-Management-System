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
    public class PrescriptionRepository : IPrescriptionRepository
    {

        private readonly DataContext _context;

        public PrescriptionRepository(DataContext context)
        {
            _context = context;
        }

        public Prescription AddPrescription(Prescription prescription)
        {
            _context.PrescriptionList.Add(prescription);
            return prescription;
        }

        public void DeletePrescription(int id)
        {
            _context.PrescriptionList.Remove(_context.PrescriptionList.ToList().Find(c => c.PrescriptionId == id));
        }

        public Prescription GetById(int id)
        {
            return _context.PrescriptionList.Include(a => a.Patient).First(c => c.PrescriptionId == id);
        }

        public List<Prescription> GetPrescriptions()
        {
            return _context.PrescriptionList.ToList();
        }

        public Prescription UpdatePrescription(int id, Prescription prescription)
        {
            var updatePrescription = _context.PrescriptionList.ToList().Find(u => u.PatientId == id);
            if (updatePrescription != null)
            {
                updatePrescription.Medication = prescription.Medication;
                return updatePrescription;
            }
            return null;
        }
    }
}
