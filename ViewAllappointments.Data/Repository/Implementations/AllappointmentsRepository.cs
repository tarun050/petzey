using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewAllappointments.Domain;
using ViewAllappointments.Repository.Data_Access_Layer;
using ViewAllappointments.Repository.Repository.Interfaces;

namespace ViewAllappointments.Repository.Repository.Implementations
{
    public class AllappointmentsRepository : IAllappointmentsRepository
    {
       private ViewAllappointmentsDbContext db = new ViewAllappointmentsDbContext();

        public ICollection<AllAppointments> GetAllAppointments()
        {
            ICollection<AllAppointments> allAppointments = db.AllAppointments.Include(x=> x.petOwner).Include(x => x.Doctor).Include(x=>x.pet).ToList();
            return allAppointments;
        }

        public ICollection<AllAppointments> GetAllAppointmentsById(int id)
        {
            ICollection<AllAppointments> allAppointments = db.AllAppointments.Where(x => x.Id == id).Include(x => x.petOwner).Include(x => x.Doctor).Include(x => x.pet).ToList();
            return allAppointments;
        }

        public int GetTotalAppointment(int id)
        {
            int total = db.AllAppointments.Where(x => x.Doctor.Id == id).Count();
            return total;
        }

        public int GetClosedAppointment(int id)
        {
            int closed = db.AllAppointments.Include(x => x.appointmentStatus).Where(x => x.appointmentStatus.Status == "Closed"&&x.Doctor.Id==id).Count();
            return closed;
        }

        public int GetConfirmedAppointment(int id)
        {
            int confirmed = db.AllAppointments.Include(x => x.appointmentStatus).Where(x => x.appointmentStatus.Status == "Confirmed" && x.Doctor.Id == id).Count();
            return confirmed;
        }

        public int GetCancelledAppointment(int id)
        {
            int cancelled  = db.AllAppointments.Include(x => x.appointmentStatus).Where(x => x.appointmentStatus.Status == "Cancelled" && x.Doctor.Id == id).Count();
            return cancelled;
        }
    }

}