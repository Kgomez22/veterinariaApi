using veterinariaApi.Models;

namespace veterinariaApi.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;
        public PetDTO? Pet { get; set; }
    }
}
