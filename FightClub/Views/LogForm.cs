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
    interface ILog: IView
    {
        void AddNewLog(string mes);
        void ClearLog();
    }

    public partial class LogForm : Form, ILog
    {
        public LogForm()
        {
            InitializeComponent();
        }

        public void AddNewLog(string mes)
        {
            FightLog.Items.Add(mes);
            FightLog.SelectedIndex = FightLog.Items.Count - 1;
            FightLog.SelectedIndex = -1;
        }

        public void ClearLog()
        {
            FightLog.Items.Clear();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать в Бойцовский клуб.\n\nПравила:\n- Игра строится на основе раундов.\n" +
 "- В одном раунде один игрок атакует, другой защищается.\n- Атакующий игрок выбирет для удара часть " +
 "тела оппонента(голова, корпус, ноги) с помощью соответствующих кнопок.\n- Защищающийся игрок выбирает часть тела для блока(голова, " +
 "корпус, ноги) с помощью соответствующих кнопок.\n- Если защищенная и атакуемая части тела совпадут, очки жизни остануться прежними. Иначе отнимается 10 очков жизни.\n" +
 "Победа игрока наступает, когда очки жизни его оппонента равны 0.\n- За ходом игры можно следить с помощью текстовых комментариев в окне Fight Log.\n" +
 "- Очки жизни отображаются в верхней части окна игрока рядом с его именем.", "Help", MessageBoxButtons.OK);
        }

        private void LogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
