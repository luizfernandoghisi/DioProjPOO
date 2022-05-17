using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioProj.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, int HP, int MP) : base(Name, Level, HP, MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = HeroType.Ninja;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack()
        {
            return this.Name + " atacou pelas sombras";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name = " deu um golpe super efetivo furtivo com bonus de " + Bonus;
            }
            else if (Bonus < 3)
            {
                return this.Name + " deu um golpe pouco efetivo furtivo com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " deu um golpe furtivo com bonus de " + Bonus;
            }
        }
    }
}
