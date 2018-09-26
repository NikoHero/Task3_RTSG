using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17601321_Gade_A1
{
    class EnemyGrandUnit : Unit
    {
        public EnemyGrandUnit(int XPosition, int YPosition, int Health, int MaxHealth, int Speed,
   int Attack, int AttackRange, string team, string symbol, int IsAttacking, String Name, int DarknessLvl, int Healing, int FearLvl)
        {
            this.XPosition = XPosition;
            this.YPosition = YPosition;
            this.Health = Health;
            this.MaxHealth = MaxHealth;
            this.Speed = Speed;
            this.Attack = Attack;
            this.AttackRange = AttackRange;
            this.team = team;
            this.Symbol = symbol;
            this.IsAttacking = IsAttacking;
            this.Name = Name;

            //Unique abilities to Grand Enemy
            this.DarknessLvl = DarknessLvl;
            this.Healing = Healing;
            this.FearLvl = FearLvl;

        }
        }
    }
