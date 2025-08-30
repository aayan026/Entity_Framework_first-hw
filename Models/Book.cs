using EntityFramework.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    internal class Book :BaseEntity
    {
        public string Name { get; set; }
        public int PageCount { get; set; }

        //fk
        public int AuthorId { get; set; }

        //navigation property
        public List<Student> Students { get; set; }
        public Author Author { get; set; }
        public BookType BookType { get; set; }
    }
}
