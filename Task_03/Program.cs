using System;
using System.Drawing;
using System.Text;

// Домашнє завдання №1
// Завдання 3

namespace Classes
{
    class Program
    {
        class Book
        {
            private Title title;
            private Author author;
            private Content content;

            public Book(string title, string author, string content)
            {
                this.title = new Title(title);
                this.author = new Author(author);
                this.content = new Content(content);
            }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                title.Show();
                Console.ForegroundColor = ConsoleColor.Green;
                author.Show();
                Console.ForegroundColor = ConsoleColor.Yellow;
                content.Show();
                Console.ResetColor();
            }
        }
        class Title
        {
            private string title;

            public Title(string title)
            {
                this.title = title;
            }

            public void Show()
            {
                Console.WriteLine("Назва книги: " + title);
            }
        }
        class Author
        {
            private string author;

            public Author(string author)
            {
                this.author = author;
            }

            public void Show()
            {
                Console.WriteLine("Автор книги: " + author);
            }
        }
        class Content
        {
            private string content;

            public Content(string content)
            {
                this.content = content;
            }

            public void Show()
            {
                Console.WriteLine("Зміст книги: " + content);
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть назву книги: ");
            string bookTitle = Console.ReadLine();

            Console.WriteLine("Введіть автора книги: ");
            string bookAuthor = Console.ReadLine();

            Console.WriteLine("Введіть короткий зміст книги: ");
            string bookContent = Console.ReadLine();

            Book book = new Book(bookTitle, bookAuthor, bookContent);

            Console.WriteLine("\nДані про книгу:");
            book.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}

