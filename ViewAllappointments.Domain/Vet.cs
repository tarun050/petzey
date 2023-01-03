using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAllappointments.Domain
{
    public class Vet
    {
        [Key]
        public int Id { get; set; }
        public int VetId { get; set; }
        public string VetName { get; set; }
        public string VetAddress { get; set; }
        public string NPINumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }


    }
}
