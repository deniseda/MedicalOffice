using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOffice2
{
    public class Appointment
    {
        public DateTime DateTime {  get; set; }


        //istances of doctor and patient
        public Doctor Doctor { get; set; }

        public Patient Patient { get; set; }
        

        public string Cause { get; set; }


        private int _duration;

        public int Duration
        {
            get { return _duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Duration cannot be negative");
                }
                _duration = value;
            }
        }

        public Appointment() { }

        public Appointment(DateTime datetime, Doctor doctor, Patient patient, string cause, int duration)
        {
            if (doctor == null || patient == null)
            {
                throw new ArgumentException("Doctor and patient cannot be null.");
            }

            DateTime = datetime;
            Doctor = doctor;
            Patient = patient;
            Cause = cause;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"Appointment with Dr. {Doctor.Name} and Patient {Patient.Name} on {DateTime} for {Cause}, Duration: {Duration} minutes";
        }

    }


    
}
