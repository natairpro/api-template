using System.Collections.Generic;
using System.Threading.Tasks;
using Data;
using Dto;
using InntopiaApi.Mappings;
using Microsoft.AspNetCore.Mvc;

namespace InntopiaApi.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        // GET api/values
        [HttpGet]
        public Task<IEnumerable<Dto.PersonDto>> Get()
        {
            var service = new PersonService();

            var data = service.GetManyByAsync();

            var mapper = new PersonMapper();

            var mappedData = mapper.MapManyAsync(data);

            return mappedData;
        }
    }
}
