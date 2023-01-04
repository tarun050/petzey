using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewAllappointments.Domain;
using ViewAllappointments.Repository.Data_Access_Layer;
using ViewAllappointments.Repository.Repository.Implementations;
using ViewAllappointments.Repository.Repository.Interfaces;
using ViewAllappointments.Services.Services.Implementations;
using ViewAllappointments.Services.Services.Interfaces;
using ViewAllappointmentsDTO;

namespace ViewAllappointments.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllappointmentssController : ControllerBase
    {

       
        IAllappointmentsServices services;
        public AllappointmentssController()
        {
            services = new AllappointmentsServices();
        }

        [HttpGet]
     
        public IActionResult GetAllAppointments()
        {
            try
            {
                ICollection<AllAppointmentsFormDTO> allAppointments = services.GetAllAppointments();
                if (allAppointments == null)
                {
                    return NotFound();

                }
                return Ok(allAppointments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]

        public IActionResult GetAllAppointmentsById(int id)
        {

            try
            {
             
                ICollection<AllAppointmentsFormDTO> allAppointments = services.GetAllAppointmentsById(id);
                return Ok(allAppointments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
