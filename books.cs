using System;
using System.Collections.Generic;
using System.Text;


namespace myappaug12

{
   class Publication
    {


        public Publication(string Title, int Price)
        {
            this.Title = Title;
            this.Price = Price;
        }
        public string Title { get; set; }
        public int Price { get; set; }
    }








    class Books : Publication
    {
        public Books(string Title, int Price, string Author, int Pages) : base(Title, Price)
        {
            this.Author = Author;
            this.Pages = Pages;

        }
        public string Author { get; set; }
        public int Pages { get; set; }

        public void getDetails1()
        {
            Console.WriteLine($"Title is {this.Title}");
            Console.WriteLine($"Price is {this.Price}");
            Console.WriteLine($"Author  is {this.Author}");
            Console.WriteLine($"Pages are  {this.Pages}");

        }
    }


    class Video : Publication
    {
        public Video(string Title, int Price, int Duration, int Minutes) : base(Title, Price)
        {
            this.Duration = Duration;
            this.Minutes = Minutes;

        }
        public int Duration { get; set; }
        public int Minutes { get; set; }

        public void getDetails()
        {
            Console.WriteLine($"Title is {this.Title}");
            Console.WriteLine($"Price is {this.Price}");
            Console.WriteLine($"Author  is {this.Duration}");
            Console.WriteLine($"Pages are  {this.Minutes}");

        }
    }

    class PublicationTest
    {
        public static void Main()
        {
            Books b1 = new Books("THE GOD FATHER", 200, "xyz", 150);
            b1.getDetails1();
            Video v1 = new Video("THE JUDGE", 200, 100, 150);
            v1.getDetails();
        }

    }

}