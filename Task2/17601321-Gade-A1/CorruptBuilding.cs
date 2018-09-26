using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17601321_Gade_A1
{
    class CorruptBuilding : Building
    {

        public CorruptBuilding(int XPosition, int YPosition, int Health, string team, string symbol,int Coruption)
        {
            this.XPosition = XPosition;
            this.YPosition = YPosition;
            this.Health = Health;
            this.team = team;
            this.Symbol = symbol;


            //Enemy Building unique ablity
            this.Corruption = Coruption;
            
        }

    }
}
