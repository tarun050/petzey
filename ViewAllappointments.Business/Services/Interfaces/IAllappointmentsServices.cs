using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewAllappointments.Domain;
using ViewAllappointments.Repository.Repository.Implementations;
using ViewAllappointments.Repository.Repository.Interfaces;
using ViewAllappointmentsDTO;

namespace ViewAllappointments.Services.Services.Interfaces
{
    public interface IAllappointmentsServices
    {

        public ICollection<AllAppointmentsFormDTO> GetAllAppointments();
        public ICollection<AllAppointmentsFormDTO> GetAllAppointmentsById(int id);
        public AppointmentStatisticsDTO GetAppointmentStatistics(int id);
        
    }
}
