using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpsilonEngine.Core;

namespace UpsilonEngine.Data
{
    public class Professions
    {
        public static List<Profession> AllProfessions => new List<Profession>
        {
            Amateur,
            Warrior,
            Student,
            Rogue
        };

        public static Profession Amateur =>
            new Profession
            {
                Name = "Amateur",
                Description = "A new professional learning their first, general skills",
                Id = ProfessionIds.Amateur,
                Levels = AmateurLevels,
                Requirements = new List<ProfessionRequirement>()
            };

        public static List<ProfessionLevel> AmateurLevels =>
            ProcessLevels(ProfessionIds.Amateur, new List<ProfessionLevel>
            {
                new ProfessionLevel
                {                    
                    Name = "Basic Proficiency",
                    Description = "Your first step towards becoming a professional",
                    Ability = "Unlock other basic professions",
                    ExperienceRequired = 100
                },
                new ProfessionLevel
                {
                    Name = "Beginner Proficiency",
                    Description = "Incremental improvements to your basic skills.",
                    Ability = "+1% to all attributes",
                    ExperienceRequired = 1000
                },
                new ProfessionLevel
                {
                    Name = "Minor Proficiency",
                    Description = "Incremental improvements to your basic skills.",
                    Ability = "+2% to all attributes",
                    ExperienceRequired = 4000
                },
                new ProfessionLevel
                {
                    Name = "Intermediate Proficiency",
                    Description = "Incremental improvements to your basic skills.",
                    Ability = "+3% to all attributes",
                    ExperienceRequired = 9000
                },
                new ProfessionLevel
                {
                    Name = "Veteran Proficiency",
                    Description = "Incremental improvements to your basic skills.",
                    Ability = "+4% to all attributes",
                    ExperienceRequired = 16000
                },
                new ProfessionLevel
                {
                    Name = "Advanced Proficiency",
                    Description = "Incremental improvements to your basic skills.",
                    Ability = "+5% to all attributes",
                    ExperienceRequired = 25000
                },
                new ProfessionLevel
                {
                    Name = "Expert Proficiency",
                    Description = "Incremental improvements to your basic skills.",
                    Ability = "+6% to all attributes",
                    ExperienceRequired = 36000
                },
                new ProfessionLevel
                {
                    Name = "Amateur No More",
                    Description = "Good luck is simply the product of continued hard work.",
                    Ability = "+5% to luck",
                    ExperienceRequired = 10000
                }
            });

        public static Profession Warrior =>
            new Profession()
            {
                Name = "Warrior",
                Description = "A basic battle-focused professional who can later specialize their skills",
                Id = ProfessionIds.Warrior,
                Levels = WarriorLevels,
                Requirements = new List<ProfessionRequirement>
                {
                    new ProfessionRequirement(ProfessionIds.Amateur, 1)
                }
            };

        public static List<ProfessionLevel> WarriorLevels => ProcessLevels(ProfessionIds.Warrior,
            new List<ProfessionLevel>
            {
                new ProfessionLevel
                {
                    Name = "Basic Warfare",
                    Description = "Prepare yourself for battle",
                    Ability = "Unlock standard fighting professions",
                    ExperienceRequired = 1000
                },
                new ProfessionLevel
                {
                    Name = "Beginner Warfare",
                    Description = "Incrementally improve your attacking proficiency",
                    Ability = "+10% attack speed, +20% when using Basic weapons",
                    ExperienceRequired = 1000
                },
                new ProfessionLevel
                {
                    Name = "Minor Warfare",
                    Description = "Incrementally improve your attacking proficiency",
                    Ability = "+20% attack speed, +40% when using Basic weapons",
                    ExperienceRequired = 4000
                },
                new ProfessionLevel
                {
                    Name = "Specialized Warfare",
                    Description = "Increase and focus your battle skills",
                    Ability = "Unlock specialized fighting professions",
                    ExperienceRequired = 5000
                },
                new ProfessionLevel
                {
                    Name = "Intermediate Warfare",
                    Description = "Incrementally improve your attacking proficiency",
                    Ability = "+30% attack speed, +60% when using Basic weapons",
                    ExperienceRequired = 9000
                },
                new ProfessionLevel
                {
                    Name = "Veteran Warfare",
                    Description = "Incrementally improve your attacking proficiency",
                    Ability = "+40% attack speed, +80% when using Basic weapons",
                    ExperienceRequired = 16000
                },
                new ProfessionLevel
                {
                    Name = "Advanced Warfare",
                    Description = "Incrementally improve your attacking proficiency",
                    Ability = "+50% attack speed, +100% when using Basic weapons",
                    ExperienceRequired = 25000
                },
                new ProfessionLevel
                {
                    Name = "Expert Warfare",
                    Description = "Incrementally improve your attacking proficiency",
                    Ability = "+60% attack speed, +120% when using Basic weapons",
                    ExperienceRequired = 4000
                }
            });

        public static Profession Student =>
            new Profession()
            {
                Name = "Student",
                Description = "An aspiring amateur of mental, creative, and magical professions",
                Id = ProfessionIds.Student,
                Levels = StudentLevels,
                Requirements = new List<ProfessionRequirement>
                {
                    new ProfessionRequirement(ProfessionIds.Amateur, 1)
                }
            };

        public static List<ProfessionLevel> StudentLevels => ProcessLevels(ProfessionIds.Student,
            new List<ProfessionLevel>
            {
                new ProfessionLevel
                {
                    Name = "Basic Studies",
                    Description = "Begin training your mind",
                    Ability = "Unlock standard mental, creative, and magical professions",
                    ExperienceRequired = 1000
                },
                new ProfessionLevel
                {
                    Name = "Basic Studies",
                    Description = "Incrementally improve your intellectual prowess",
                    Ability = "Increase Intelligence level growth by 1",
                    ExperienceRequired = 1000
                },
                new ProfessionLevel
                {
                    Name = "Minor Studies",
                    Description = "Incrementally improve your intellectual prowess",
                    Ability = "Increase Intelligence level growth by 1",
                    ExperienceRequired = 4000
                },
                new ProfessionLevel
                {
                    Name = "Specialized Studies",
                    Description = "Increase and focus your mental prowess",
                    Ability = "Unlock specialized mental, creative, and magical professions",
                    ExperienceRequired = 5000
                },
                new ProfessionLevel
                {
                    Name = "Intermediate Studies",
                    Description = "Incrementally improve your intellectual prowess",
                    Ability = "Increase Intelligence level growth by 1",
                    ExperienceRequired = 9000
                },
                new ProfessionLevel
                {
                    Name = "Veteran Studies",
                    Description = "Incrementally improve your intellectual prowess",
                    Ability = "Increase Intelligence level growth by 1",
                    ExperienceRequired = 16000
                },
                new ProfessionLevel
                {
                    Name = "Advanced Studies",
                    Description = "Incrementally improve your intellectual prowess",
                    Ability = "Increase Intelligence level growth by 1",
                    ExperienceRequired = 25000
                },
                new ProfessionLevel
                {
                    Name = "Expert Studies",
                    Description = "Incrementally improve your intellectual prowess",
                    Ability = "Increase Intelligence level growth by 1",
                    ExperienceRequired = 36000
                }
            });

        public static Profession Rogue =>
            new Profession()
            {
                Name = "Rogue",
                Description = "A professional who uses finesse and deception to accomplish tasks",
                Id = ProfessionIds.Rogue,
                Levels = RogueLevels,
                Requirements = new List<ProfessionRequirement>
                {
                    new ProfessionRequirement(ProfessionIds.Amateur, 1)
                }
            };

        public static List<ProfessionLevel> RogueLevels => ProcessLevels(ProfessionIds.Rogue,
            new List<ProfessionLevel>
                {
                    new ProfessionLevel
                    {
                        Name = "Basic Finesse",
                        Description = "Begin training your reflexes and perception",
                        Ability = "Unlock standard finesse and sneaky professions",
                        ExperienceRequired = 1000
                    },
                });                

        private static List<ProfessionLevel> ProcessLevels(string professionId, List<ProfessionLevel> rawLevels)
        {
            int levelCounter = 1;
            foreach (var level in rawLevels)
            {
                level.Id = LevelIds.Id(professionId, levelCounter);
                level.LevelNumber = levelCounter;
                levelCounter++;
            }

            return rawLevels;
        }
    }

    public class ProfessionIds
    {
        public const string Amateur = "amateur";
        public const string Warrior = "warrior";
        public const string Student = "student";
        public const string Rogue = "rogue";
    }

    public class LevelIds
    {
        public static string Id(string professionId, int levelNumber) => $"{professionId}_{levelNumber}";        
    }
}