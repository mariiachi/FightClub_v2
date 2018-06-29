using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    interface IPlayerView:IView
    {
        event Action FormLoad;
        void Round(bool attack, bool def);
        void SetHP(int value);
        void Death();
    }
}
