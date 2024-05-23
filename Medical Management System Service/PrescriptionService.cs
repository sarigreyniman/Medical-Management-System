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

        public List<Prescription> GetPrescriptionsAsync()
        {
            return _prescriptionRepository.GetPrescriptionsAsync();
        }

        public Prescription GetByIdAsync(int id)
        {
            return _prescriptionRepository.GetByIdAsync(id);
        }

        public Prescription AddPrescriptionAsync(Prescription prescription)
        {
            return _prescriptionRepository.AddPrescriptionAsync(prescription);
        }

        public Prescription UpdatePrescriptionAsync(int id, Prescription e)
        {
            return _prescriptionRepository.UpdatePrescriptionAsync(id, e);
        }

        public void DeletePrescriptionAsync(int id)
        {
            _prescriptionRepository.DeletePrescriptionAsync(id);
        }
    }
}
