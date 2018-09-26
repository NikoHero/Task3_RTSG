using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17601321_Gade_A1
{
    class Building
    {
        protected int XPosition;
        protected int YPosition;
        protected int Health;
        protected string team;
        protected string Symbol;

        protected int Corruption;

        public Building()
         {


         }

        public abstract void Death();
        public abstract override string ToString();




    }
}
