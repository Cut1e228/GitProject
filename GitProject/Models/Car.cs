namespace GitProject.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }

        public string Image     { get; set; }

        public string Model { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<Category> categories { get; set; } = new();


        
    }
}
