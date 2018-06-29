using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    public delegate void FightCourseHandler(object sender, FightCourseEventArgs args);
    public class FightCourseEventArgs
    {
        private int hp;
        public string Name { get; set; }
        public int Hp
        {
            get { return hp; }
            set
            {
              if (value < 0)
                  hp = 0;
              else
                  hp = value;
            }
        }
        public FightCourseEventArgs(string name, int hp)
        {
            Name = name;
            Hp = hp;
        }
    }
}
