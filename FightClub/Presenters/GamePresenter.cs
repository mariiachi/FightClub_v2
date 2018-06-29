using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    class GamePresenter : IPresenter
    {
        private IUserView userForm;
        private IPlayerView compForm;
        private ILog logForm;
        private IGame gameModel;
        
        public GamePresenter(string name)
        {
            gameModel = new Game(name);

            userForm = new Player1Form(name);
            logForm = new LogForm();
            compForm = new Player2Form();

            userForm.FormLoad += () => LoadForm();
            userForm.Shown += PlaceForms;
            compForm.FormLoad += () => LoadForm();

            userForm.Block += UserBlock;
            userForm.Attack += UserAttack;

            gameModel.Bind(UserWound, CompWound, UserDeath, CompDeath, UserBlock, CompBlock);
            
        }

        private void PlaceForms (object sender, EventArgs e)
        {
            compForm.Location = new Point(userForm.Location.X + userForm.Width + 20, userForm.Location.Y);
            logForm.Location = new Point(userForm.Location.X, userForm.Location.Y + userForm.Height + 20);
            
        }

        public void Run()
        {
            userForm.Show();
            compForm.Show();
            logForm.Show();
        }

        private void LoadForm()
        {
            logForm.ClearLog();
            logForm.AddNewLog("Новичок обязан принять бой.");
            logForm.AddNewLog("Защищайся.");
            userForm.SetHP(100);
            compForm.SetHP(100);
            gameModel.SetMaxHP();
            userForm.Round(false, true);
            compForm.Round(true, false);
            
        }

        private void UserBlock (object sender, EventArgs e)
        {
            userForm.Round(true, false);
            compForm.Round(false, true);
            var blockedPart = sender as Button;
            gameModel.UserBlock(blockedPart.Text);
            gameModel.CompAttack();
        }

        private void UserAttack(object sender, EventArgs e)
        {
            userForm.Round(false, true);
            compForm.Round(true, false);
            gameModel.CompBlock();
            var hitPart = sender as Button;
            gameModel.UserAttack(hitPart.Text);
            
        }

        private void UserDeath(object sender, FightCourseEventArgs args)
        {
            userForm.SetHP(gameModel.CurrentUserHP);
            userForm.Round(false, false);
            compForm.Round(false, false);
            logForm.AddNewLog("Кажется, ты умер. " + args.Name + "  HP: " + args.Hp + ".");
            logForm.AddNewLog("Мудрое решение с твоей стороны.");
            userForm.Death();
            
        }

        private void CompDeath(object sender, FightCourseEventArgs args)
        {
            compForm.SetHP(gameModel.CurrentCompHP);
            userForm.Round(false, false);
            compForm.Round(false, false);
            logForm.AddNewLog("В этот раз тебе повезло. " + args.Name + "  HP: " + args.Hp + ".");
            logForm.AddNewLog("Поздравляю с победой.");
            compForm.Death();
            
        }

        private void UserWound(object sender, FightCourseEventArgs args)
        {
            userForm.SetHP(gameModel.CurrentUserHP);
            logForm.AddNewLog("Ауч! Это было больно. " + args.Name + "  HP: " + args.Hp + ".");
        }

        private void CompWound(object sender, FightCourseEventArgs args)
        {
            compForm.SetHP(gameModel.CurrentCompHP);
            logForm.AddNewLog("Неплохой удар. " + args.Name + "  HP: " + args.Hp + ".");
        }

        private void UserBlock(object sender, FightCourseEventArgs args)
        {
            logForm.AddNewLog("Хороший блок! " + args.Name + "  HP: " + args.Hp + ".");
        }

        private void CompBlock(object sender, FightCourseEventArgs args)
        {
            logForm.AddNewLog("Я не хочу умереть без единого шрама. " + args.Name + "  HP: " + args.Hp + ".");
        }

    }
}
