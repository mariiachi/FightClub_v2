using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    interface ILogIn: IView
    {
        string Username { get; }
        event Action LogIn;
        void ShowError(string errMes);
    }
}
