using Lab1_Makarevich.Rest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_Makarevich.Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
       // public PeopleController(PeopleDb db)
       // {

       // }

        [HttpGet]
        public IActionResult Get()
        {
            var people = new List<Person>
        {
            new Person
            {
                FirstName = "Ilya",
                LastName = "Makarevich",
                PersonId = 1
            }
        };

            return Ok(people);
        }

    }

    
}
