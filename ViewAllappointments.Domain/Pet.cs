using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAllappointments.Domain
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }
        public int PetId { get; set; }
        public string PetName { get; set; }
        public string PetType { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }
}
