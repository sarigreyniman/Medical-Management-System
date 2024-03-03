using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Management_System_Core.Entities
{
    public class Prescription
    {
        public int PrescriptionId { get; set; } //מזהה ייחודי למרשם רפואי

        public int PatientId { get; set; } //מזהה ייחודי למטופל

        public string Medication { get; set; } //תיאור המרשם

        public double Dosage { get; set; } //מינון


        public Patient Patient { get; set; }//כל מרשם משויך לפציינט אחד

        public Appointment Appointment { get; set; }//כל מרשם משויך לפגישה אחת

    }
}
