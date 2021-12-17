using System;
using System.Collections.Generic;
using System.Text;

namespace PraticaPOO_RPG.Source.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, string job, int level)
        {
            this.Name = name;
            this.Job = job;
            this.Level = level;
        }

        private string Weapom = "a Espada";

        public override string Attack()
        {
            return base.Attack() + Weapom + "!";
        }
    }
}
