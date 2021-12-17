using System;
using System.Collections.Generic;
using System.Text;

namespace PraticaPOO_RPG.Source.Entities
{
    public abstract class Hero
    {
        public Hero(string name, string job, int level)
        {
            this.Name = name;
            this.Job = job;
            this.Level = level;
        }
        public Hero()
        {

        }

        public string Name;
        public string Job;
        public int Level;

        public override string ToString()
        {
            return "Herói: " + this.Name + ", Classe: " + this.Job + ", Nível: " + this.Level;
        }
        public virtual string Attack()
        {
            return this.Name + " atacou com ";
        }
    }
}
