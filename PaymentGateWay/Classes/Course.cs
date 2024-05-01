using System.ComponentModel.DataAnnotations;

namespace PaymentGateWay.Classes
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public List<Course>? CrsList { get; set; }

        public Course(int id, string? name, string? description, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
