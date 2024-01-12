using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    public class BookModel
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public bool IsCheckedOut { get; set; }
    }
}
