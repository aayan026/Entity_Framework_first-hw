using EntityFramework.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    internal class Author :BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Book> Books { get; set; }
    }
}
