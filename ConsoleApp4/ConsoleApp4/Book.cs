using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace librarymanagementsystem
{
    internal class Book : LibraryItem, ITEM

    {
        private string author;

        public Book(string authorName)
        {
            author = authorName;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Book ID: " + GetId());
            Console.WriteLine("Title: " + GetTitle());
            Console.WriteLine("Author: " + author);
            Console.WriteLine("------------------------");
        }
    }
}

 
