using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLibrary
{
   public class Library
    {
        string Name { get; set; }
        string adress { get; set;}
        public object ItemsForCheckout { get; internal set; }

        public List<Book> Books = new List<Book>();
        public List<VideoGame> videogames = new List<VideoGame>();
        public List<checkoutable> Items = new List<checkoutable>();
   

        public Library(string v1, string v2)
        {
            Name = Name;
        }
    }
}
