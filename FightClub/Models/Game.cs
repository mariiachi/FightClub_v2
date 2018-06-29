using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    interface IGame
    {
        int CurrentUserHP { get; }
        int CurrentCompHP { get; }
        void SetMaxHP();
        void Bind(FightCourseHandler usWound, FightCourseHandler cmWound, FightCourseHandler usDeath, FightCourseHandler cmDeath, FightCourseHandler usBlock, FightCourseHandler cmBlock);
        bool UserBlock(string part);
        bool UserAttack(string part);
        void CompAttack();
        void CompBlock();

    }

    public class Game: IGame
    {

        private Fighter user;
        private Fighter comp;
        private Random rnd = new Random();

        public int CurrentUserHP
        {
            get { return user.Hp; }
        }

        public int CurrentCompHP
        {
            get { return comp.Hp; }
        }

        public Game(string name)
        {
            user = new Fighter(name);
            comp = new Fighter("Тайлер Дёрден");
            
        }
        
        public void SetMaxHP()
        {
            user.Hp = 100;
            comp.Hp = 100;
        }

        public void Bind(FightCourseHandler usWound, FightCourseHandler cmWound, FightCourseHandler usDeath, FightCourseHandler cmDeath, FightCourseHandler usBlock, FightCourseHandler cmBlock)
        {
            user.Wound += usWound;
            comp.Wound += cmWound;
            user.Death += usDeath;
            comp.Death += cmDeath;
            user.Block += usBlock;
            comp.Block += cmBlock;
        }

        public bool UserBlock (string part)
        {
            switch (part)
            {
                case "Голова":
                    user.SetBlock(BodyPart.Head);
                    break;
                case "Корпус":
                    user.SetBlock(BodyPart.Body);
                    break;
                case "Ноги":
                    user.SetBlock(BodyPart.Legs);
                    break;
            }

            if (user.Hp != 0 && comp.Hp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UserAttack(string part)
        {
            switch (part)
            {
                case "Голова":
                    comp.GetHit(BodyPart.Head);
                    break;
                case "Корпус":
                    comp.GetHit(BodyPart.Body);
                    break;
                case "Ноги":
                    comp.GetHit(BodyPart.Legs);
                    break;
            }

            if (user.Hp != 0 && comp.Hp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CompAttack()
        {
            int i = rnd.Next(0, 3);
            user.GetHit((BodyPart)i);
        }

        public void CompBlock()
        {
            int i = rnd.Next(0, 3);
            comp.SetBlock((BodyPart)i);
        }

    }
    
}
