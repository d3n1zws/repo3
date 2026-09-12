

namespace Task
{
    internal class Library
    {
        public Book[] books = new Book[50];
        public int FindBooks(DateOnly mindate, DateOnly maxdate, int price)
        {
            int count = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                    continue;
                if (books[i].PublishDate >=  mindate && books[i].PublishDate <= maxdate && books[i].Price >= price)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
