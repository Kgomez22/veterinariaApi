using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using veterinariaApi.DTOs;
using veterinariaApi.Models;
using veterinariaApi.Repositories.Interfaces;

namespace veterinariaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentRepository _repository;

        public AppointmentsController(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(AppointmentDTO appointment)
        {
            var response = await _repository.AddAsync(appointment);
            if (!response.WasSucceeded) 
            {
                return BadRequest(response.Message);
            }
            return Ok(response.Data);    
        }
    }
}
