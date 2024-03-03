using Medical_Management_System_Core.DTOs;
using Medical_Management_System_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Management_System_Core
{
    public class Mapping
    {
        public AppointmentDto MapToAppointmentDto(Appointment appointment)
        {
            return new AppointmentDto { AppointmentDate=appointment.AppointmentDate,AppointmentId=appointment.AppointmentId,DoctorName=appointment.DoctorName,PatientId=appointment.PatientId};
        }

        public PatientDto MapToPatientDto(Patient patient)
        {
            return new PatientDto {DateOfBirth=patient.DateOfBirth,PatientId=patient.PatientId,MedicalHistory=patient.MedicalHistory,PatientName=patient.PatientName  };
        }

        public PrescriptionDto MapToPrescriptionDto(Prescription prescription)
        {
            return new PrescriptionDto { Dosage = prescription.Dosage, PatientId =prescription.PatientId,Medication=prescription.Medication,PrescriptionId=prescription.PrescriptionId };
        }
    }
}
