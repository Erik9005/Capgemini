using Capgemini.Commons.Models;
using Capgemini.DatabaseRepository;
using Capgemini.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Capgemini.Services.Services
{
    public class PersonService : IPersonService
    {
        public void AddPerson(string parameters)
        {
            using(var context = new CapgeminiDbContext())
            {
                context.Add(ParametersToPerson(parameters));
                context.SaveChanges();
            }
        }

        public IEnumerable<Person> GetPersons()
        {
            using (var context = new CapgeminiDbContext())
            {
                return context.Persons.ToList();
            }
        }

        private Person ParametersToPerson(string parameters)
        {
            var props = parameters.Split(',').ToList();
            return new Person() { FirstName = props[0], LastName = props[1], Email = props[2] };
        }
    }
}