using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOffice2
{
    public class Patient : Person
    {
        public string? Desease { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }


        public Patient(string name, string surname, string email, string desease, int age, string address) : base(name, surname, email)
        {
            Desease = desease;
            Age = age;
            Address = address;
        }

        public override void MostraDettagli()
        {
            if (Desease == null)
            {
                Console.WriteLine($"Nome: {Name}, Età: {Age}, Malattia: Nessuna");
            }
            else
            {
                Console.WriteLine($"Nome: {Name}, Età: {Age}, Malattia: {Desease}");
            }
        }


    }
}
