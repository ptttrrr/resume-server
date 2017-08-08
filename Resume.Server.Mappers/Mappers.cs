using System;
using System.Linq;
using System.Collections.Generic;
using Resume.Server.Data;
using Resume.Server.Contracts;

namespace Resume.Server.Mappers
{
    public static class Mappers
    {
        #region Entity to contract
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
        #endregion


        #region Contract to entity
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
    }
}
