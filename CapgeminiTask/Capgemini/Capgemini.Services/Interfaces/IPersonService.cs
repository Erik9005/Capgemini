using Capgemini.Commons.Models;
using System.Collections.Generic;

namespace Capgemini.Services.Interfaces
{
    public interface IPersonService
    {
        void AddPerson(string parameters);

        IEnumerable<Person> GetPersons();
    }
}