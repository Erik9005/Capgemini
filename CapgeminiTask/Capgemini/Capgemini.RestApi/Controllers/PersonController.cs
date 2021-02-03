using Capgemini.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.RestApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class PersonController : ControllerBase
    {

        private IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }

        [Route("save/{parameters}")]
        [HttpGet]
        public ActionResult SavePerson(string parameters)
        {
            _service.AddPerson(parameters);
            return Ok();
        }

        [Route("persons")]
        [HttpGet]
        public ActionResult GetPersons()
        {
            var persons = _service.GetPersons();
            return new JsonResult(persons);
        }
    }
}