using Task;

Book book1 = new Book(1, "Deniz", "deniz", new DateOnly(2025, 1, 1), 50.0);
Book book2 = new Book(2, "Nigar", "nigar", new DateOnly(2024, 3, 17), 30.0);
Library library = new Library();
library.books[0] = book1;
library.books[1] = book2;
Console.WriteLine(library.FindBooks(new DateOnly(2021, 4, 12), new DateOnly(2026, 1, 1), 20));

