using Medical_Management_System_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Management_System_Core.Services
{
    public interface IPrescriptionService
    {
        List<Prescription> GetPrescriptions();

        Prescription GetById(int id);

        Prescription AddPrescription(Prescription prescription);

        Prescription UpdatePrescription(int id, Prescription prescription);

        void DeletePrescription(int id);
    }
}
