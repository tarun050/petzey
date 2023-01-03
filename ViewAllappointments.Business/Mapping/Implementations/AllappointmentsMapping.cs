using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewAllappointments.Domain;
using ViewAllappointments.Services.Mapping.Interfaces;
using ViewAllappointmentsDTO;

namespace ViewAllappointments.Services.Mapping.Implementations
{
    public class AllappointmentsMapping : IAllappointmentsMapping
    {

        public ICollection<AllAppointmentsFormDTO> ChangeAllAppointmentsToAllAppointmentsFormDTO(ICollection<AllAppointments> allAppointments)
        {
            ICollection<AllAppointmentsFormDTO> allAppointmentsForms = new List<AllAppointmentsFormDTO>();
            foreach(var appointment in allAppointments)
            {
                AllAppointmentsFormDTO formDTO = new AllAppointmentsFormDTO();
                formDTO.Id = appointment.Id;
                formDTO.AppointmentDate = appointment.AppointmentDate;
                formDTO.AppointmentTime = appointment.AppointmentTime;
                formDTO.PetName = appointment.PetName;
                formDTO.Age = appointment.Age;
                formDTO.OwnerName = appointment.OwnerName;
                allAppointmentsForms.Add(formDTO);
            }
            return allAppointmentsForms;
        }

        public AppointmentStatisticsDTO ChangeStatisticsToAppointmentStatisticsDTO(int total, int Confirmed, int Closed, int Cancelled)
        {
            AppointmentStatisticsDTO appointmentStatistics = new AppointmentStatisticsDTO()
            {
                Total = total,
                Confirmed = Confirmed,
                Closed = Closed,
                Cancelled = Cancelled
            };
            return appointmentStatistics;
        }
    }
}
