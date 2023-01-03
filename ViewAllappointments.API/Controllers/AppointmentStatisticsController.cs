using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewAllappointments.Services.Services.Implementations;
using ViewAllappointments.Services.Services.Interfaces;
using ViewAllappointmentsDTO;

namespace ViewAllappointments.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentStatisticsController : ControllerBase
    {
        IAllappointmentsServices services;
        public AppointmentStatisticsController()
        {
            services = new AllappointmentsServices();
        }
        [HttpGet]
        [Route("appointmentstatistics")]

        public IActionResult GetAllAppointmentsById(int DoctorId)
        {

            try
            {
                if (DoctorId == null)
                {
                    return NotFound();
                }
                AppointmentStatisticsDTO appointmentStatistics = services.GetAppointmentStatistics(DoctorId);
                return Ok(appointmentStatistics);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
