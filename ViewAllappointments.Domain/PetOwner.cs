using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAllappointments.Domain
{
    public class PetOwner
    {
        [Key]
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }

    }
}
