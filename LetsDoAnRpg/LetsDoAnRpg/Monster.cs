using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsDoAnRpg
{
    class Monster : LivingBeing
    {
        public string Name { get; set; }
        public double MaxHealth { get; set; }
        public double CurrentHealth { get; set; }
        public double Damage { get; set; }
    }
}
