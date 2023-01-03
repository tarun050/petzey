using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAllappointments.Domain
{
    public class AppointmentStatus
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
