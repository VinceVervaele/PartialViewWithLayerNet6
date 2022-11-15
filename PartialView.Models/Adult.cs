using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialView.Models
{
    public enum JobType
    {
        Docent,
        Student
    }
    public class Adult
    {
        public int Id { get; set; }
        public string? Voornaam { get; set; }
        public string? Naam { get; set; }
        public JobType Job { get; set; }
        public DateTime EnrollDate { get; set; }
        public string? ImagePath { get; set; }
    }
}
