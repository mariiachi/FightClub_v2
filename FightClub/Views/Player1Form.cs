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
    public partial class Player1Form : Form, IUserView
    {
        
        public Player1Form(string userName)
        {
            InitializeComponent();
            userNameLabel.Text = userName;
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
        }

        public event Action FormLoad;
        public event EventHandler Block;
        public event EventHandler Attack;

        private void Player1Form_Load(object sender, EventArgs e)
        { 
            FormLoad?.Invoke();
        }

        void IPlayerView.Round(bool attack, bool def)
        {
            AttackPanel.Visible = attack;
            defendPanel.Visible = def;
        }

        public void SetHP(int value)
        {
            userHpProgress.Value = value;
            userHpLabel.Text = value.ToString();
            userHpLabel.Left = userHpProgress.Right + 5;
        }

        private void headDefendButton_Click(object sender, EventArgs e)
        {
            Block?.Invoke(sender,e);
        }
        

        private void BodyDefendButton_Click(object sender, EventArgs e)
        {
            Block?.Invoke(sender, e);
        }

        private void LegsDefendButton_Click(object sender, EventArgs e)
        {
            Block?.Invoke(sender, e);
        }


        private void attackHeadButton_Click(object sender, EventArgs e)
        {
            Attack?.Invoke(sender, e);
        }

        private void attackBodybutton_Click(object sender, EventArgs e)
        {
            Attack?.Invoke(sender, e);
        }

        private void attackLegsbutton_Click(object sender, EventArgs e)
        {
            Attack?.Invoke(sender, e);
        }
        
        public void Death()
        {
           
            DialogResult reloadOption = MessageBox.Show("Кажется, ты умер. Мудрое решение с твоей стороны.\n\nЗапустить новый бой?", "Oops!", MessageBoxButtons.YesNo);
            if (reloadOption == DialogResult.Yes)
            {
                FormLoad?.Invoke();
                
            }
            else
            {
                this.Close();
            }
        }

        
        private void ComputerDeath(object sender, FightCourseEventArgs args)
        {
            DialogResult reloadOption = MessageBox.Show("В этот раз тебе повезло. Поздравляю с победой.\n\nЗапустить новый бой?","Congratulations!", MessageBoxButtons.YesNo);
            if(reloadOption==DialogResult.Yes)
            {
                FormLoad?.Invoke();
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void Player1Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
