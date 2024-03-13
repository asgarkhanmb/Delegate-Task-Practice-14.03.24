using Delegate_Task.Data;
using Delegate_Task.Models;
using Delegate_Task.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Task.Services
{
    internal class BookService : IBookService
    {
        public List<Book> GetAll()
        {
            return AppDbContext.books;
        }

        public List<Book> GetSearchBookAuthor(Predicate<Book> predicate)
        {

            List<Book> foundBooks = new();
            foreach (var book in AppDbContext.books)
            {
                if (predicate(book))
                {
                    foundBooks.Add(book);
                }
            }
            return foundBooks;
        }
    }
}
