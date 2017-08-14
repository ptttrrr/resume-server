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
    public class CoffeeStatusService
    {
        private readonly UnitOfWork repo;

        public CoffeeStatusService(object repo)
        {
            this.repo = new UnitOfWork((Entities)repo);
        }

        public List<CoffeeStatusDTO> GetAll()
        {
            return repo.CoffeeStatusRepository.GetAll().ToList().ToContracts();
        }
    }
}
