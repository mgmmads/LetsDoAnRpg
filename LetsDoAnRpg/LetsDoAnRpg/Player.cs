using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsDoAnRpg
{
    class Player : LivingBeing
    {
        public double MaxHealth { get; set; }
        public double CurrentHealth { get; set; }
        public double MaxMana { get; set; }
        public double CurrentMana { get; set; }
        public double Damage { get; set; }
        public int SkillPoints { get; set; }
        public double ExperienceForNextLevel { get; set; }
        public double CurrentExperience { get; set; }
        public int StrengthPoints { get; set; }
        public int AgilityPoints { get; set; }
        public int IntelligentPoints { get; set; }
        //public List<Item> backPack = new List<Item>();

        public Player(int strengthPoints, int agilityPoints, int intelligentPoints)
        {
            MaxHealth = 25 + (strengthPoints * 2);
            CurrentHealth = MaxHealth;
            MaxMana = 10 + (intelligentPoints * 2);
            CurrentMana = MaxMana;
            Damage = 5 + (strengthPoints * 0.5 + agilityPoints * 0.25);

        }

    }
}
