using Medical_Management_System_Core.Entities;

namespace Medical_Management_System.Models
{
    public class PatientPostModel
    {
        public string PatientName { get; set; } //שם המטופל.

        public DateTime DateOfBirth { get; set; } //תאריך לידה

        public string MedicalHistory { get; set; } //היסטוריה רפואית



        public List<Appointment> Appointments { get; set; }//כל פציינט יכול להיות לו רשימת פגישות

        public List<Prescription> Prescriptions { get; set; }//כל פציינט יכול להיות לו רשימת מרשמים
    }
}
