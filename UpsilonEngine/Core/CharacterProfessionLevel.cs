namespace UpsilonEngine.Core
{
    public class CharacterProfessionLevel
    {
        public CharacterProfessionLevel(Character character, ProfessionLevel professionLevel)
        {
            this.ProfessionLevel = professionLevel;
            this.Character = character;
        }

        public Character Character { get; set; }

        public ProfessionLevel ProfessionLevel { get; set; }

        public int Experience { get; set; } = 0;

        public bool IsLearned => Experience >= ProfessionLevel.ExperienceRequired;
    }
}
