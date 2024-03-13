using Delegate_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Task.Data
{

    internal class AppDbContext
    {
        public static List<Person> persons;
        public static List<Book> books;
        static AppDbContext()
        {
            persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Name = "Asgarkhan",
                    Surname="Bayramov",
                    Address = "Yasamal",
                    Salary=900
                },
                new Person
                {
                    Id = 2,
                    Name = "Bahruz",
                    Surname="Eliyev",
                    Address = "Kurdexani",
                    Salary =1200
                },
                new Person
                {
                    Id = 3,
                    Name = "Reshad",
                    Surname="Aghayev",
                    Address = "Neftciler",
                    Salary=1500

                },
                new Person
                {
                    Id = 4,
                    Name = "Rufat",
                    Surname="Ismayilov",
                    Address = "28 May",
                    Salary=1100
                },

            };


            books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Name="Isgendername",
                    Author="Nizami Gencevi",
                },
                new Book
                {
                   Id=2,
                   Name="Xosrov ve Shirin",
                   Author="Nizami Gencevi",
                },
                new Book
                {
                    Id=3,
                    Name="Ikinci Addim",
                    Author="Qaraqan",
                },
                new Book
                {
                    Id=4,
                    Name="Bir milyon dollarim olsaydi",
                    Author="Qaraqan",
                }


            };

           
        }
    }
}
