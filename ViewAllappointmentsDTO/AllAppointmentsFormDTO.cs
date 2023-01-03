using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAllappointmentsDTO
{
     public class AllAppointmentsFormDTO
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public string PetName { get; set; }
        public string Gender { get; set; }
        public string OwnerName { get; set; }
        public string Age { get; set; }
        public string VetName { get; set;}
      
    }
}
