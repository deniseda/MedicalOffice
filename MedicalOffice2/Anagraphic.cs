using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOffice2
{
    public class Anagraphic
    {
        private IList<IPerson> _person;

        public Anagraphic()
        {
            _person = new List<IPerson>();
        }

        public void AddPerson(Person person)
        {
            _person.Add(person);
        }

        public void RemovePerson(Person person)
        {
            _person.Remove(person);
        }

        public IEnumerable<IPerson> ObtainPeople()
        {
            return _person;
        }

    }
}
