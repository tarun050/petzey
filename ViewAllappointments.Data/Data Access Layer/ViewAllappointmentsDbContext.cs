using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewAllappointments.Domain;

namespace ViewAllappointments.Repository.Data_Access_Layer
{
    public class ViewAllappointmentsDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:petzeyproject.database.windows.net,1433;Initial Catalog=Petzey-Appoinment;Persist Security Info=False;User ID=Tarun_050;Password=Relax@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }


        public DbSet<AllAppointments> AllAppointments { get; set; }
        
    }
}
