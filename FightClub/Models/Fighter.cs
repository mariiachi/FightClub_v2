using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    

   public class Fighter
    {
        private int hp;

        public string Name { get; set; }
        public BodyPart Blocked { get; set; }
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                if (value < 0)
                    hp = 0;
                else
                    hp = value;
            }
        }
            
        public Fighter (string name)
        {
            Name = name;
            Hp = 100;
        }

        public void SetBlock (BodyPart bodyPart)
        {
            Blocked = bodyPart;
        }

        public void GetHit(BodyPart bodyPart)
        {
            if (bodyPart == Blocked)
            {
                OnBlock(new FightCourseEventArgs(this.Name, this.Hp));
            }
            else
            {
                Hp -= 10;
                if (Hp>0)
                {
                    OnWound(new FightCourseEventArgs(this.Name, this.Hp));
                }
                else
                {
                    OnDeath(new FightCourseEventArgs(this.Name, this.Hp));
                }
            }
            
        }
        
        public event FightCourseHandler Block;
        public event FightCourseHandler Wound;
        public event FightCourseHandler Death;

        public void OnBlock(FightCourseEventArgs args)
        {
            Block?.Invoke(this, args);
        }

        public void OnWound (FightCourseEventArgs args)
        {
            Wound?.Invoke(this, args);
        }

        public void OnDeath(FightCourseEventArgs args)
        {
            Death?.Invoke(this, args);
        }


    }
}
