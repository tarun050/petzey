using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ViewAllappointments.Domain
{
    public class AllAppointments
    {
        
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public string Age { get; set; }
        public string Issue { get; set; }
        public string Comment { get; set; }
        public string Reason { get; set; }
        [Column(TypeName = "Date")]
        public DateTime CreatedAt { get; set; }
        public Vet Doctor { get; set; }
        public Pet pet { get; set; }
        public string PetName { get; set; }
        public string Gender { get; set; }
        public string VetName { get; set; } 
        public PetOwner petOwner { get; set; }
        public string OwnerName { get; set; }
        public AppointmentStatus appointmentStatus { get; set; }
    }

}

