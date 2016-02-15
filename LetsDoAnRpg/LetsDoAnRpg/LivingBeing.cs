using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsDoAnRpg
{
    interface LivingBeing
    {
        string Name { get; set; }
        double MaxHealth { get; set;}
        double CurrentHealth { get; set; }
        double Damage { get; set; }
    }
}
