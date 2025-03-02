using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOffice2
{
    public class Studio
    {
        private IList<Appointment> _appointments;

        private IList<Doctor> _doctors;

        private IList<Patient> _patients;


        public Studio()
        {
            _appointments = new List<Appointment>();
            _doctors = new List<Doctor>();
            _patients = new List<Patient>();
        }

        public void AddAppointment(Appointment appointment)
        {
            //  controllo che non sia stato inserito un appuntamento al medesimo orario per lo stesso medico  
            var conflictingAppointment = _appointments.FirstOrDefault(a => a.DateTime == appointment.DateTime && a.Doctor == appointment.Doctor);
            if (conflictingAppointment != null)
            {
                Console.WriteLine($"Conflicting appointment: DateTime={conflictingAppointment.DateTime}, Doctor={conflictingAppointment.Doctor.Name}, Patient={conflictingAppointment.Patient.Name}");
                throw new InvalidOperationException("The doctor already has an appointment at this time.");
            }
            _appointments.Add(appointment);
        }

        public void AddAppointment(DateTime dateTime, Doctor doctor, Patient patient,string cause, int duration)
        {
            var appointment = new Appointment
            {
                DateTime = dateTime,
                Doctor = doctor,
                Patient = patient,
                Cause = cause,
                Duration = 30

            };

            AddAppointment(appointment);
        }


        public IEnumerable<Appointment> AllAppointment()
        {
        return _appointments;
        }



       
    }

        

 }

