using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    interface IView
    {
        void Show();
        void Hide();
        void Close();
        event EventHandler Shown;
        Point Location { get; set; }
        int Width { get; set; }
        int Height { get; set; }
    }
}
