﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Management_System_Core.Entities
{
    public class Appointment
    {
        public int AppointmentId { get; set; } //מזהה ייחודי לפגישה רפואית

        public int PatientId { get; set; } //מזהה ייחודי למטופל

        public DateTime AppointmentDate { get; set; } //תאריך ושעת הפגישה

        public string DoctorName { get; set; } //שם הרופא שביצע את הפגישה


        public Patient Patient { get; set; }//כל פגישה יכולה להיות של פציינט אחד

        public List<Prescription> Prescriptions { get; set; }//כל פציינט יכול להיות לו רשימת פגישות

    }
}
