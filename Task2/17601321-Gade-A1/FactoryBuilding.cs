using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17601321_Gade_A1
{
    class FactoryBuilding : Building
    {

        public FactoryBuilding(int XPosition, int YPosition, int Health, string team, string symbol)
        {
            this.XPosition = XPosition;
            this.YPosition = YPosition;
            this.Health = Health;
            this.team = team;
            this.Symbol = symbol;


        }

        private int FactProduce;
        private int FactTick;
        private int FactSpawn;


    }
}
