using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsDoAnRpg
{
    interface LivingBeing
    {
        double MaxHealth { get; set;}
        double CurrentHealth { get; set; }
        double MaxMana { get; set; }
        double CurrentMana { get; set; }
        double Damage { get; set; }
    }
}
