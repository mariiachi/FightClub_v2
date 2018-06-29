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
    public partial class Player2Form : Form, IPlayerView
    {
        
        public Player2Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

        }
        
        public event Action FormLoad;

        public void Round(bool attack, bool def)
        {
            CompActLabel.Visible = true;
            if (attack)
                CompActLabel.Text = "Тайлер атакует";
            else if (def)
                CompActLabel.Text = "Тайлер защищается";
            else CompActLabel.Visible = false;
        }

        public void SetHP(int value)
        {
            compHpProgress.Value = value;
            compHpLabel.Text = value.ToString();
            compHpLabel.Left = compHpProgress.Right + 5;
        }

        private void Player2Form_Load(object sender, EventArgs e)
        {
            FormLoad?.Invoke();
        }

        public void Death()
        {
            DialogResult reloadOption = MessageBox.Show("В этот раз тебе повезло. Поздравляю с победой.\n\nЗапустить новый бой?", "Congratulations!", MessageBoxButtons.YesNo);
            if (reloadOption == DialogResult.Yes)
            {
                FormLoad?.Invoke();
            }
            else
            {
                Application.Exit();
            }

        }

        private void Player2Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
