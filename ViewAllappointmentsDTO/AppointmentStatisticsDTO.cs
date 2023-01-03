using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAllappointmentsDTO
{
    public class AppointmentStatisticsDTO
    {
        public int Total { get; set; }
        public int Confirmed { get; set; }
        public int Closed { get; set; }
        public int Cancelled { get; set; }
    }
}
