namespace GitProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Fullname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Adress { get; set; }

        public decimal Balance { get; set; }
        public List<Car> Cars { get; set; } = new();
    }
}
