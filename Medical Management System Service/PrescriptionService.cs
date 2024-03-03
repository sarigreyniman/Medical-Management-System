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
    public class PrescriptionService:IPrescriptionService
    {
        private readonly IPrescriptionRepository _prescriptionRepository;

        public PrescriptionService(IPrescriptionRepository prescriptionRepository)
        {
            _prescriptionRepository = prescriptionRepository;
        }

        public List<Prescription> GetPrescriptions()
        {
            return _prescriptionRepository.GetPrescriptions();
        }

        public Prescription GetById(int id)
        {
            return _prescriptionRepository.GetById(id);
        }

        public Prescription AddPrescription(Prescription prescription)
        {
            return _prescriptionRepository.AddPrescription(prescription);
        }

        public Prescription UpdatePrescription(int id, Prescription e)
        {
            return _prescriptionRepository.UpdatePrescription(id, e);
        }

        public void DeletePrescription(int id)
        {
            _prescriptionRepository.DeletePrescription(id);
        }
    }
}
