namespace GitProject.Models
{
    public class Category
    {
        public int Id { get; set; } 
        public string Fuel { get; set; }

        public string Engine { get; set; }

       public string Model { get; set; }

        public int HorsePower { get; set; }

        public int Country { get; set; }

        public int Mark {  get; set; }
        public List<Car> Cars { get; set; } = new();
    }
}
