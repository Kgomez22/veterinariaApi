using System.Text.Json.Serialization;

namespace veterinariaApi.Models
{
    public class Pet
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Type { get; set; } = null!;

        public short Age { get; set; }

        public string? Race { get; set;}

        public int UserId { get; set; }
        [JsonIgnore]
        public  User? User { get; set; }
    }
}
