using Delegate_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Task.Services.Interfaces
{
    internal interface IPersonService
    {
        List<Person> GetAll();
        List<Person> Search(Predicate<Person> predicate);
        List<Person> FindSalary(Predicate<Person> predicate);
        
    }
}
