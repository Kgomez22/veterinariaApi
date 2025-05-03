namespace veterinariaApi.Models
{
    public class User
    {
        
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public IEnumerable<Pet>? Pets { get; set; }

        public IEnumerable<Appointment>? Appointments { get; set; }
    }
}
