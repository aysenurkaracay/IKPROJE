using IkProject.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkProject.DATA.Concreate
{
    public class CEO:Employee
    {
       
        public ICollection<Officer> Employees { get; set; }

    }
}
