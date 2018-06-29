using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
   internal class LogInPresenter: IPresenter
    {
        private readonly ILogIn logInView;
        private IPresenter Player1Pres;

        public LogInPresenter (ILogIn view)
        {
            logInView = view;
            view.LogIn += () => LogIn(view.Username);
        }

        public void Run()
        {
            logInView.Show();
        }

        private void LogIn(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                logInView.ShowError("Назови своё имя.");
            }
            else
            {
                logInView.Hide();
                Player1Pres = new GamePresenter(name);
                Player1Pres.Run();

            }
        }



    }
}
