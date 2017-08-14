using System;
using System.Linq;
using System.Collections.Generic;
using Resume.Server.Data;
using Resume.Server.Contracts;

namespace Resume.Server.Mappers
{
    public static class Mappers
    {
        #region Skill contracts
        public static SkillDTO ToContract(this Skill skill)
        {
            return new SkillDTO
            {
                Id = skill.Id,
                Name = skill.Name,
                Scale = skill.Scale
            };
        }

        public static List<SkillDTO> ToContracts(this List<Skill> skills)
        {
            return
                skills
                    .Select(x => new SkillDTO
                    {
                        Id = x.Id,
                        Name= x.Name,
                        Scale = x.Scale
                    }).ToList();
        }

        public static Skill ToEntity(this SkillDTO skillDTO)
        {
            return new Skill
            {
                Id = skillDTO.Id,
                Name = skillDTO.Name,
                Scale = skillDTO.Scale
            };
        }
        #endregion

        #region CoffeeStatus contracts
        public static CoffeeStatusDTO ToContract(this CoffeeStatus coffeeStatus)
        {
            return new CoffeeStatusDTO
            {
                Id = coffeeStatus.Id,
                Level = coffeeStatus.Level,
                Timestamp = coffeeStatus.Timestamp
            };
        }

        public static List<CoffeeStatusDTO> ToContracts(this List<CoffeeStatus> coffeeStats)
        {
            return
                coffeeStats
                    .Select(x => new CoffeeStatusDTO
                    {
                        Id = x.Id,
                        Level = x.Level,
                        Timestamp = x.Timestamp
                    }).ToList();
        }
        #endregion
    }
}
