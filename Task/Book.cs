namespace Task
{
    internal class Book
    {
        public Book(int id, string title, string author, DateOnly publishDate, double price)
        {
            Id = id;
            Title = title;
            Author = author;
            PublishDate = publishDate;
            Price = price;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateOnly PublishDate { get; set; }
        public double Price { get; set; }
    }
}
