using Car_Showroom.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Showroom.Data
{
    public class CarsDbContext:DbContext
    {
        public DbSet<Car> Cars { get; set; } = default!;

        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options) { 
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            Car car1 = new()
            {
                Id = 1,
                Manufacturer = "Mercedes",
                Model = "CLS",
                Price = 80000,
                Year = 2016,
                Color = "Black"
            };
            Car car2 = new() 
            {
                Id = 2,
                Manufacturer = "VM",
                Model = "Jetta",
                Price = 30000,
                Year = 2021,
                Color = "Black"
            };
            Car car3 = new() { 
            Id= 3,
            Manufacturer="Audi",
            Model="R8",
            Price=300000,
            Year=2021,
            Color="Black"
            };
            modelBuilder.Entity<Car>().HasData(car1, car2,car3);
        }
    }
}
