using EntityFramework.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    internal class BookType : BaseEntity
    {
        public string Name { get; set; }

        //navigation prop   
        public List<Book> Books { get; set; }
    }
}
