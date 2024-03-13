using Delegate_Task.Services;
using Delegate_Task.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Task.Controllers
{
    internal class PersonController
    {
        private readonly IPersonService _personService;

        public PersonController()
        {
            _personService = new PersonService();
        }
        public void GetAll()
        {
            foreach (var item in _personService.GetAll())
            {
                Console.WriteLine(item.Name + "-" + item.Surname + "-" + item.Address + "-" + item.Salary);
            }
        }
        public void Search()
        {
            var response = _personService.Search(m => m.Name.Contains("R"));
            foreach (var item in response)
            {
                Console.WriteLine(item.Name + "-" + item.Surname + "-" + item.Address + "-" + item.Salary);
            }
        }
        public void FindSalary()
        {
            var response = _personService.FindSalary(m => m.Salary > 1000);
            foreach (var item in response)
            {
                Console.WriteLine(item.Name + "-" + item.Surname + "-" + item.Address + "-" + item.Salary);
            }
        }
        
    }
}
