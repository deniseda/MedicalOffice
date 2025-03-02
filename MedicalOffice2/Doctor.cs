using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOffice2
{
    public class Doctor : Person
    {
        public string Specialization { get; set; }

        public Doctor(string name, string surname, string email, string specialization) : base(name, surname, email)
        {
            Specialization = specialization;
        }

        public override void ViewDetail()
        {
            Console.WriteLine($"Name and surname: {Name}, {Surname}, Spec in: {Specialization}");
        }


    }
}
