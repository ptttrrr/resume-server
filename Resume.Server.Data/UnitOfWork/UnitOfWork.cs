using System;
using Resume.Server.Data.Repositories;

namespace Resume.Server.Data.UnitOfWork
{
    public class UnitOfWork
    {
        private Entities context;

        private GenericRepository<Skill> skillRepository;
        private GenericRepository<CoffeeStatus> coffeeStatusRepository;

        public UnitOfWork(Entities context)
        {
            this.context = context;
        }

        public GenericRepository<Skill> SkillRepository => skillRepository ?? (skillRepository = new GenericRepository<Skill>(context));
        public GenericRepository<CoffeeStatus> CoffeeStatusRepository => coffeeStatusRepository ?? (coffeeStatusRepository = new GenericRepository<CoffeeStatus>(context));


    }
}
