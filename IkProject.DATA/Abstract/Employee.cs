using IkProject.DATA.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkProject.DATA.Abstract
{
    public abstract class Employee : BaseData
    {
        public string Photo { get; set; }
        public string FirstName { get; set; }
        public string FirstName2 { get; set; }
        public string LastName { get; set; }
        public string LastName2 { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string TcNo { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public bool IsActive { get; set; }
        public string Profession { get; set; }
        public string Department { get; set; }
        public string CompanyName { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }

        
    }
}
