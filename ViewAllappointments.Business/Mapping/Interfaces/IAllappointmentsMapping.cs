using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewAllappointments.Domain;
using ViewAllappointmentsDTO;

namespace ViewAllappointments.Services.Mapping.Interfaces
{
    public interface IAllappointmentsMapping
    {
        public ICollection<AllAppointmentsFormDTO> ChangeAllAppointmentsToAllAppointmentsFormDTO(ICollection<AllAppointments> allAppointments);
        public AppointmentStatisticsDTO ChangeStatisticsToAppointmentStatisticsDTO(int total,int Confirmed,int Closed,int Cancelled);
    }
}
