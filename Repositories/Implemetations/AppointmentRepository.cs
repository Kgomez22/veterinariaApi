using Microsoft.EntityFrameworkCore;
using veterinariaApi.Data;
using veterinariaApi.DTOs;
using veterinariaApi.Models;
using veterinariaApi.Repositories.Interfaces;
using veterinariaApi.Responces;

namespace veterinariaApi.Repositories.Implemetations
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private  DataContext _context;
        public AppointmentRepository(DataContext context) 
        {
            _context = context; 
        }

        public async Task<HttpResponseWrapper<Appointment>> AddAsync(AppointmentDTO model)
        {
            var user = await _context.Users.Where(w => w.Id == model.User!.Id).FirstOrDefaultAsync();
            if (user == null) 
            {
                user = new User 
                {
                    Id = model.User!.Id,
                    Name = model.User!.Name,
                    Phone = model.User!.Phone,
                };
                await _context.AddAsync(user);
            }
            string petName = model.User!.Pet!.Name;
            string petType = model.User!.Pet!.Type;
            var pet = await _context.Pets.Where(w=>w.UserId== user.Id && w.Name==petName).FirstOrDefaultAsync();
            if (pet == null) 
            {
                pet = new Pet { Name = petName, Type = petType, UserId=user.Id};
                await _context.AddAsync(pet);
            }

            var Appointment = await _context.Appointments.FindAsync(model.Id);
            if (Appointment != null) 
            {
                return new HttpResponseWrapper<Appointment>
                {
                    Data = null,
                    WasSucceeded = false,
                    Message = "Error esta cita ya existe"
                };
            }
            if (!DateTime.TryParse(model.DateAppointment, out DateTime dateTime)) 
            {
                dateTime = DateTime.Now;
            };

            var newAppointment = new Appointment { 
                DateAppointment = dateTime,
                Description = model.Description,
                UserId = model.User!.Id,
            };
            await _context.AddAsync(newAppointment);
            await _context.SaveChangesAsync();
            return new HttpResponseWrapper<Appointment>
            {
                Data = newAppointment,
                WasSucceeded = true,
            };
        }
    }
}
