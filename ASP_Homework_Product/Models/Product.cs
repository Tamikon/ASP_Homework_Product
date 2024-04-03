namespace ASP_Homework_Product.Models
{
    public class Product
    {
        private static int idCounter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public Product(string name, string description, int cost)
        {
            Id = idCounter;
            Name = name;
            Description = description;
            Cost = cost;
            idCounter++;
        }
        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}";
        }
    }
}