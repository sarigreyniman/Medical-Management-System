using Medical_Management_System_Core.Entities;

namespace Medical_Management_System.Models
{
    public class AppointmentPostModel
    {
        public int PatientId { get; set; } //מזהה ייחודי למטופל

        public DateTime AppointmentDate { get; set; } //תאריך ושעת הפגישה

        public string DoctorName { get; set; } //שם הרופא שביצע את הפגישה


        public Patient Patient { get; set; }//כל פגישה יכולה להיות של פציינט אחד

        public List<Prescription> Prescriptions { get; set; }//כל פציינט יכול להיות לו רשימת פגישות

    }
}
