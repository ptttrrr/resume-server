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
    public class SkillController : ApiController
    {
        private readonly SkillService skillService;

        public SkillController()
        {
            this.skillService = new SkillService(new Entities());
        }


        [HttpGet]
        public IEnumerable<SkillDTO> GetSkills()
        {
            return skillService.GetAll();
        }

    }
}