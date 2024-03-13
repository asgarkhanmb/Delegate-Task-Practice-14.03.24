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
    internal class PersonService : IPersonService
    {
        public List<Person> FindSalary(Predicate<Person> predicate)
        {
            List<Person> foundPersons = new();
            foreach (var item in AppDbContext.persons)
            {
                if (predicate(item))
                {
                    foundPersons.Add(item);
                }
            }
            return foundPersons;
        }

        public List<Person> GetAll()
        {
            return AppDbContext.persons;
        }

        public List<Person> Search(Predicate<Person> predicate)
        {
            List<Person> foundPersons = new();
            foreach (var item in AppDbContext.persons)
            {
                if (predicate(item))
                {
                    foundPersons.Add(item);
                }
            }
            return foundPersons;
        }
    }
}
