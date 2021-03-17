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
        public PeopleDb db;
        public PeopleController(PeopleDb db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var people = db.People.ToList();


            return Ok(people);
        }
    }


}
