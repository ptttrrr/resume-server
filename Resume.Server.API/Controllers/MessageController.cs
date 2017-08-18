using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Resume.Server.Business;
using Resume.Server.Contracts;
using Resume.Server.Data;
using System.Diagnostics;
using System.Configuration;

namespace Resume.Server.API.Controllers
{
    public class MessageController : ApiController
    {
        private readonly MessageService service;

        public MessageController()
        {
            this.service = new MessageService();
        }

        [HttpPost]
        public IHttpActionResult PostMessage(MessageDTO messageDTO)
        {
            var conn = ConfigurationManager.ConnectionStrings["StorageConnectionString"];

            if (service.PostMessage(messageDTO, conn.ToString()))
                return Ok();
            else
                return BadRequest();
        }

    }
}