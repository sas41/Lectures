using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Author{ get; set; }
        public Book(string title, int year, params string[] author)
        {
            Title = title;
            Year = year;
            Author = author.ToList();
        }  
    }
}
