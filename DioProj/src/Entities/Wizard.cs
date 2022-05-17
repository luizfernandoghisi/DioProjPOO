using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioProj.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level,HeroType Type, int HP, int MP) : base(Name, Level, Type, HP, MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack()
        {
            if (this.Type == HeroType.WhiteWizard)
            {
                return this.Name + " lançou magia de luz";
            }
            else if (this.Type == HeroType.BlackWizard)
                return this.Name + " lançou magia negra";
            else
                return this.Name + "não é um mago, favor corrigir o seu tipo!";
        }

        public string Attack(int Bonus)
        {
            if (this.Type == HeroType.WhiteWizard)
            {
                if (Bonus > 6)
                {
                    return this.Name = " lançou magia de luz super efetiva com bonus de " + Bonus;
                }
                else if (Bonus < 3)
                {
                    return this.Name + " lançou magia de luz pouco efetiva com bonus de " + Bonus;
                }
                else
                {
                    return this.Name + " lançou magia de luz com bonus de " + Bonus;
                }
            }
            else if (this.Type == HeroType.BlackWizard)
            {
                if (Bonus > 6)
                {
                    return this.Name = " lançou magia negra super efetiva com bonus de " + Bonus;
                }
                else if (Bonus < 3)
                {
                    return this.Name + " lançou magia negra pouco efetiva com bonus de " + Bonus;
                }
                else
                {
                    return this.Name + " lançou magia negra com bonus de " + Bonus;
                }
            }
            else
            {
                return this.Name + "não é um mago, favor corrigir o seu tipo!";
            }

        }
    }
}
