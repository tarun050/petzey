using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewAllappointments.Domain;

namespace ViewAllappointments.Repository.Repository.Interfaces
{
    public interface IAllappointmentsRepository
    {
        public ICollection<AllAppointments> GetAllAppointments();
       public ICollection<AllAppointments> GetAllAppointmentsById(int id);
        public int GetTotalAppointment(int id);
        public int GetConfirmedAppointment(int id);
        public int GetClosedAppointment(int id);
        public int GetCancelledAppointment(int id);
    }
}
