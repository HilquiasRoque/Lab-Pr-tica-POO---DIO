using System;
using System.Collections.Generic;
using System.Text;

namespace PraticaPOO_RPG.Source.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, string job, int level)
        {
            this.Name = name;
            this.Job = job;
            this.Level = level;
        }

        private string Weapom = "as Shuriken";

        public override string Attack()
        {
            return base.Attack() + Weapom + "!";
        }
    }
}
