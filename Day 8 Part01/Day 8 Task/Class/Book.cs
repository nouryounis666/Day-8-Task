using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Task.Class
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
        }

        public Book(string title)
        {
            Title = title;
            Author = "Unknown";
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
