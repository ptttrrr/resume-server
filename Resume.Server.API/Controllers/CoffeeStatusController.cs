using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

    }
}