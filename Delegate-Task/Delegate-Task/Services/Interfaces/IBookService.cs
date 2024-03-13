using Delegate_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Task.Services.Interfaces
{
    internal interface IBookService
    {
        List<Book> GetAll();
        List<Book> GetSearchBookAuthor(Predicate<Book> predicate);
    }
}
