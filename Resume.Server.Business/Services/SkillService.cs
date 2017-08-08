using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Server.Data;
using Resume.Server.Data.UnitOfWork;
using Resume.Server.Mappers;
using Resume.Server.Contracts;

namespace Resume.Server.Business
{
    public class SkillService
    {
        private readonly UnitOfWork repo;

        public SkillService(object repo)
        {
            this.repo = new UnitOfWork((Entities)repo);
        }

        public List<SkillDTO> GetAll()
        {
            return repo.SkillRepository.GetAll().ToList().ToContracts();
        }
    }
}
