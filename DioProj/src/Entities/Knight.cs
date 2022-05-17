using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioProj.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, int HP, int MP) : base(Name, Level, HP, MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = HeroType.Knight;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack()
        {
            return this.Name + " atacou com espada";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " deu um golpe super efetivo com a espada com bonus de " + Bonus;
            }
            else if (Bonus < 3)
            {
                return this.Name + " deu um golpe pouco efetivo com a espada com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " deu um golpe com a espada com bonus de " + Bonus;
            }
        }
    }
}
