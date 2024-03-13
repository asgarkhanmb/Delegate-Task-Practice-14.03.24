using Delegate_Task.Services;
using Delegate_Task.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Task.Controllers
{
    internal class BookController
    {
        private readonly IBookService _bookService;
        public BookController() 
        {
           _bookService=new BookService();  

        }
        public void GetAll()
        {
            foreach (var item in _bookService.GetAll()) 
            {
                Console.WriteLine(item.Name + "-" + item.Author);
            }
        }
        public void GetSearchBookAuthor()
        {
            var result = _bookService.GetSearchBookAuthor(m => m.Author.Contains("Nizami"));
            foreach (var item in result) 
            {
                Console.WriteLine(item.Name + "-" + item.Author);
            }
        }
    }
}
