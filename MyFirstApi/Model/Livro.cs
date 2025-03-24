namespace MyFirstApi.Model
{
    public class Livro
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime Release { get; set; }
        public decimal Price { get; set; }

        public Livro(string name, string author, DateTime release, decimal price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Author = author;
            Release = release;
            Price = price;
        }
    }
}
