using System;
using System.Collections.Generic;
using System.Text;

namespace PraticaPOO_RPG.Source.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, string job, int level)
        {
            this.Name = name;
            this.Job = job;
            this.Level = level;
        }

        private string Weapom = "o Cajado";

        public override string Attack()
        {
            return base.Attack() + Weapom + "!";
        }
    }
}
