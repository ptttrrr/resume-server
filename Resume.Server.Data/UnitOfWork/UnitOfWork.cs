using System;
using Resume.Server.Data.Repositories;

namespace Resume.Server.Data.UnitOfWork
{
    public class UnitOfWork
    {
        private Entities context;

        private GenericRepository<Skill> skillRepository;

        public UnitOfWork(Entities context)
        {
            this.context = context;
        }

        public GenericRepository<Skill> SkillRepository => skillRepository ?? (skillRepository = new GenericRepository<Skill>(context));


    }
}
