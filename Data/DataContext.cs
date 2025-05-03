using Microsoft.EntityFrameworkCore;
using veterinariaApi.Models;

namespace veterinariaApi.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {
            

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
