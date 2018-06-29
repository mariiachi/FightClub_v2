using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class LogInForm : Form, ILogIn
    {
        public LogInForm()
        {
            InitializeComponent();
            
        }

        public new void Show()
        {
            Application.Run(this);
        }

        public string Username
        {
            get
            {
                return userNameInput.Text;
            }
        }

        public event Action LogIn;

        public void ShowError(string errMes)
        {
            MessageBox.Show(errMes);
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
         //   LogInPresenter lp = new LogInPresenter(this);
             LogIn?.Invoke(); 
        }
    }
}
