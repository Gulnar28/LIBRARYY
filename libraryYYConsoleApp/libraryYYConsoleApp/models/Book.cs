using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryYYConsoleApp.models
{
    public class Book
    {
        public int Id { get; set; }

       
        public string Name { get; set; }

       
        public string Price { get; set; }

        
        public string Article { get; set; }

        public BookCathegory Cathegory { get; set; }

        public int BookCathegoryId { get; set; }

        
        public string BookShelf { get; set; }

        public int? ReportId { get; set; }

        public Report Report { get; set; }
    }
}
