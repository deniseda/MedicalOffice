using MedicalOffice2;

namespace MedicalOffice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Anagraphic anagraphic = new Anagraphic();

            Doctor doctor = new Doctor("Giulia", "Neri", "giulia@studiomedico.com", "Cardiologia");
            Patient patient = new Patient("Marina", "Capo", "marina@ggg.com", null, 35, "Via Milano 20");

            anagraphic.AddPerson(doctor);
            anagraphic.AddPerson(patient);

            //foreach (Person p in anagraphic.ObtainPeople())
            //{
            //    p.MostraDettagli();
            //}

            Studio studio = new Studio();
            studio.AddAppointment(new DateTime(2025, 4, 25), doctor, patient, patient.Desease, 30);
            
            foreach (Appointment a in studio.AllAppointment())
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}
