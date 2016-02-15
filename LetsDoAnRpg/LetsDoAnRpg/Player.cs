using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsDoAnRpg
{
    class Player : LivingBeing
    {
        //General Information
        public string Name { get; set; }
        public double MaxHealth { get; set; }
        public double CurrentHealth { get; set; }
        public double MaxMana { get; set; }
        public double CurrentMana { get; set; }
        public double Damage { get; set; }

        //Leveling
        public int SkillPoints { get; set; }
        public int PlayerLevel { get; set; }
        public double ExperienceForNextLevel { get; set; }
        public double CurrentExperience { get; set; }

        //Stats
        public int StrengthPoints { get; set; }
        public int AgilityPoints { get; set; }
        public int IntelligentPoints { get; set; }

        //Inventory
        public int GoldCoins { get; set; }
        public List<Item> backPack = new List<Item>();

        /// <summary>
        /// Constructor for the Player.
        /// </summary>
        /// <param name="strengthPoints"></param>
        /// <param name="agilityPoints"></param>
        /// <param name="intelligentPoints"></param>
        public Player(int strengthPoints, int agilityPoints, int intelligentPoints)
        {
            MaxHealth = 25 + (strengthPoints * 2);
            CurrentHealth = MaxHealth;
            MaxMana = 10 + (intelligentPoints * 2); //Mostly useless by now, as no spells have been planned.
            CurrentMana = MaxMana;
            Damage = 5 + (strengthPoints * 0.5 + agilityPoints * 0.25);
            PlayerLevel = 1;
            SkillPoints = 0;
            ExperienceForNextLevel = PlayerLevel * 100;
            CurrentExperience = 0;
            StrengthPoints = strengthPoints;
            AgilityPoints = agilityPoints;
            IntelligentPoints = intelligentPoints;
            GoldCoins = 0;
        }
    }
}
