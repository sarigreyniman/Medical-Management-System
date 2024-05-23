using Medical_Management_System_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Management_System_Core.Repositories
{
    public interface IPrescriptionRepository
    {
        List<Prescription> GetPrescriptionsAsync();

        Prescription GetByIdAsync(int id);

        Prescription AddPrescriptionAsync(Prescription prescription);

        Prescription UpdatePrescriptionAsync(int id, Prescription prescription);

        void DeletePrescriptionAsync(int id);
    }
}
