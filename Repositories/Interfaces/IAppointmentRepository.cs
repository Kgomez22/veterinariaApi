using veterinariaApi.DTOs;
using veterinariaApi.Models;
using veterinariaApi.Responces;

namespace veterinariaApi.Repositories.Interfaces
{
    public interface IAppointmentRepository
    {
        Task<HttpResponseWrapper<Appointment>> AddAsync(AppointmentDTO model);
      
    }
}
