using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOffice2
{
    public interface IPerson
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Email { get; set; }

        void ViewDetail();
    }
}
