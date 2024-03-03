using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Management_System_Core.Entities
{
    public class Patient
    {
        public int PatientId { get; set; } //מזהה ייחודי למטופל.

        public string PatientName { get; set; } //שם המטופל.

        public DateTime DateOfBirth { get; set; } //תאריך לידה

        public string MedicalHistory { get; set; } //היסטוריה רפואית



        public List<Appointment> Appointments { get; set; }//כל פציינט יכול להיות לו רשימת פגישות

        public List<Prescription> Prescriptions { get; set; }//כל פציינט יכול להיות לו רשימת מרשמים

    }
}
