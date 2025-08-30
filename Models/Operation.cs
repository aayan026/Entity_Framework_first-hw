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

    }
}
