using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17601321_Gade_A1
{
    class REcourceBuilding : Building
    {
        //resourcebuilding
        public REcourceBuilding(int XPosition, int YPosition, int Health, string team, string symbol,int WoodAmount, int MetalAmount)
        {
            this.XPosition = XPosition;
            this.YPosition = YPosition;
            this.Health = Health;
            this.team = team;
            this.Symbol = symbol;

            //New Resource additions
            this.WoodAmount = WoodAmount;
            this.MetalAmount = MetalAmount;

        }

        private int ReType;
        private int RePGT;
        private int ReRemain; 

    }
}
