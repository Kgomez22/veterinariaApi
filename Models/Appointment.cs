namespace veterinariaApi.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public DateTime DateAppointment { get; set; }

        public string? Description { get; set; }

        public User? User { get; set; }

        public int UserId { get; set; }
    }
}
