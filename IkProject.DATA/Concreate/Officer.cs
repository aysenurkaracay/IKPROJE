using IkProject.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkProject.DATA.Concreate
{
    public class Officer :Employee
    {

        public virtual CEO CEO { get; set; }
    }
}
