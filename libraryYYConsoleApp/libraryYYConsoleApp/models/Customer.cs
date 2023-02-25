using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryYYConsoleApp.models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
        [Required]
        [StringLength(50)]
        public string Fin { get; set; }
        [Required]
        [StringLength(15)]
        public string Phone { get; set; }
        public int ReportId { get; set; }
        public ICollection<Report> Report
        {
            get; set;
        }
}
