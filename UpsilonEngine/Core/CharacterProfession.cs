using System.Collections.Generic;
using System.Linq;

namespace UpsilonEngine.Core
{
    public class CharacterProfession
    {
        public CharacterProfession(Character character, Profession profession)
        {
            this.Character = character;
            this.Profession = profession;
            this.Levels = profession.Levels.Select(x => new CharacterProfessionLevel(character, x)).ToList();
        }        

        public Character Character { get; protected set; }

        public Profession Profession { get; protected set; }

        public List<CharacterProfessionLevel> Levels { get; protected set; } = new List<CharacterProfessionLevel>();
    }
}
