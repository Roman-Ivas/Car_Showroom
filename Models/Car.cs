namespace Car_Showroom.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Model { get; set; } = default!;

        public string Manufacturer { get; set; } = default!;

        public double Price { get; set; }

        public int Year { get; set; }

        public string Color { get; set; } = default!;
    }
}
