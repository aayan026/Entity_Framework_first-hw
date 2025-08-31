using EntityFramework.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    internal class Operation :BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
