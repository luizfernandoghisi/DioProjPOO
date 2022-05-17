using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioProj.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public HeroType Type { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public Hero(string Name, int Level, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
            this.MP = MP;
        }

        public Hero(string Name, int Level, HeroType Type, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
            this.HP = HP;
            this.MP = MP;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Type;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou";
        }


    }
}
