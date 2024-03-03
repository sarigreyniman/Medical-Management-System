using Medical_Management_System_Core.Entities;

namespace Medical_Management_System.Models
{
    public class PrescriptionPostModel
    {
        public int PatientId { get; set; } //מזהה ייחודי למטופל

        public string Medication { get; set; } //תיאור המרשם

        public double Dosage { get; set; } //מינון


        public Patient Patient { get; set; }//כל מרשם משויך לפציינט אחד

        public Appointment Appointment { get; set; }//כל מרשם משויך לפגישה אחת
    }
}
