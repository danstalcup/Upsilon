using System.Collections.Generic;

namespace UpsilonEngine.Core
{
    public class Profession
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<ProfessionLevel> Levels { get; set; }

        public List<ProfessionRequirement> Requirements { get; set; }
    }
}
