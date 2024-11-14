using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Measurement
    {
        [Key]
        public int ID { get; set; }
        
        public DateTime DateTime { get; set; }

        public int Systolic {  get; set; }

        public int Diastolic { get; set; }

        public bool Seen {  get; set; }

        // FK for Patient
        [ForeignKey("Patient")]
        [StringLength(10)]
        public string PatientSSN { get; set; }

        // Navigation Property
        public Patient Patient { get; set; }

    }
}
