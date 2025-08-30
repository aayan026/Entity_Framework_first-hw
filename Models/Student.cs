using EntityFramework.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    internal class Student :BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SchoolNumber { get; set; }
        public Gender gender { get; set; }
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; }

        //deyesen navigation property
        public List<Book> Books { get; set; }

    }
}
