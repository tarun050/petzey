using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewAllappointments.Domain;
using ViewAllappointments.Repository.Repository.Implementations;
using ViewAllappointments.Repository.Repository.Interfaces;
using ViewAllappointments.Services.Mapping.Implementations;
using ViewAllappointments.Services.Mapping.Interfaces;
using ViewAllappointments.Services.Services.Interfaces;
using ViewAllappointmentsDTO;

namespace ViewAllappointments.Services.Services.Implementations
{
    public class AllappointmentsServices : IAllappointmentsServices
    {
        IAllappointmentsRepository repo;
        IAllappointmentsMapping mapping;
        public AllappointmentsServices()
        {
            mapping = new AllappointmentsMapping();
            repo = new AllappointmentsRepository();
            
        }
        public ICollection<AllAppointmentsFormDTO> GetAllAppointments()
        {
            ICollection<AllAppointments> allAppointments= repo.GetAllAppointments();
            ICollection<AllAppointmentsFormDTO> allAppointmentsForms = mapping.ChangeAllAppointmentsToAllAppointmentsFormDTO(allAppointments);
            return allAppointmentsForms;
        }
        public ICollection<AllAppointmentsFormDTO> GetAllAppointmentsById(int id)
        {
            ICollection<AllAppointments> allAppointments = repo.GetAllAppointmentsById(id);
            ICollection<AllAppointmentsFormDTO> allAppointmentsDTO = mapping.ChangeAllAppointmentsToAllAppointmentsFormDTO(allAppointments);
            return allAppointmentsDTO;
        }

        public AppointmentStatisticsDTO GetAppointmentStatistics(int id)
        {
            int total = repo.GetTotalAppointment(id);
            int cancelled = repo.GetCancelledAppointment(id);
            int closed = repo.GetClosedAppointment(id);
            int confirmed = repo.GetConfirmedAppointment(id);
            AppointmentStatisticsDTO appointmentStatistics = mapping.ChangeStatisticsToAppointmentStatisticsDTO(total, confirmed, closed, cancelled);
            return appointmentStatistics;
        }
    }
}
