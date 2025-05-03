using veterinariaApi.Models;

namespace veterinariaApi.DTOs
{
    public class AppointmentDTO
    {
        public int Id { get; set; }

        public string DateAppointment { get; set; } = null!;

        public string? Description { get; set; }

        public UserDTO? User { get; set; }
    }
}
