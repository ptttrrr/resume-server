using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Resume.Server.Business;
using Resume.Server.Contracts;
using Resume.Server.Data;

namespace Resume.Server.API.Controllers
{
    public class CoffeeStatusController : ApiController
    {
        private readonly CoffeeStatusService service;

        public CoffeeStatusController()
        {
            this.service = new CoffeeStatusService(new Entities());
        }


        [HttpGet]
        public IEnumerable<CoffeeStatusDTO> GetCoffeeStatus()
        {
            return service.GetAll();
        }

        [HttpPost]
          public IHttpActionResult Post(CoffeeFamine coffeeFamine)
        {
            string test = coffeeFamine.ToString();

            this.service.GetAll();

            return Ok();
        }

    }

    public class CoffeeFamine
    {
        public string Timestamp { get; set; }
    }
}