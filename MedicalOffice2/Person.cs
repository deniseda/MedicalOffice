using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOffice2;

public abstract class Person : IPerson
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }


    public Person(string name, string surname, string email)
    {
        Name = name;
        Surname = surname;
        Email = email;
    }

    public abstract void MostraDettagli();
}
