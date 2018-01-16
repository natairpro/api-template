using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Data
{
    public class PersonService
    {
        public async Task<IEnumerable<Person>> GetManyByAsync()
        {

            return await Task.FromResult(new List<Person>
            {
                    new Person
                    {
                        LastName = "Smith",
                        FirstName = "John",
                        Id = 1
                    }
             });
        }
    }
}
