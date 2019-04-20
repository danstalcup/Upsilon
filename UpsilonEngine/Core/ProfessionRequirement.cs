using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpsilonEngine.Data;

namespace UpsilonEngine.Core
{
    public class ProfessionRequirement
    {
        public ProfessionRequirement(string professionId, int level)
        {
            Type = ProfessionRequirementType.Level;
            ProfessionLevelId = LevelIds.Id(professionId, level);
        }

        public ProfessionRequirementType Type { get; set; }

        public string ProfessionLevelId { get; set; }
    }

    public enum ProfessionRequirementType
    {
        Level, Trait
    }
}
