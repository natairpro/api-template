using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Dto;

namespace InntopiaApi.Mappings
{
    public class PersonMapper
    {
        public PersonDto Map(Person item)
        {
            return new PersonDto
            {
                LastName = item.LastName,
                FirstName = item.FirstName,
                Id = item.Id
            };
        }

        public async Task<IEnumerable<PersonDto>> MapManyAsync(Task<IEnumerable<Person>> items)
        {

            return items.Result.Select(i => new PersonDto
            {
                LastName = i.LastName,
                FirstName = i.FirstName,
                Id = i.Id
            });
        }
    }
}
