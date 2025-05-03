namespace veterinariaApi.DTOs
{
    public class PetDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Type { get; set; } = null!;
        public short Age { get; set; }

        public string? Race { get; set; }
    }
}
