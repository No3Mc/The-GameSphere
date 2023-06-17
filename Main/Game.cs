using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameshop1
{
    public abstract class Game : IComparable
    {
        //rates of the game 
        public enum Condition
        {
            poor,
            fair,
            good,
            mint
        };
        protected string console;
        protected string gameTitle;
        protected string gameDev;
        protected DateTime releaseDate;
        protected decimal originalPrice;
        protected Condition condition;
        
        //constructor 
        public Game(string console, string gameTitle, string gameDev, DateTime releaseDate, decimal originalPrice, Condition condition)
        {
            this.console = console;
            this.gameTitle = gameTitle;
            this.gameDev = gameDev;
            this.releaseDate = releaseDate;
            this.originalPrice = originalPrice;
            this.condition = condition;
        }
        public int CalculateApproximateAgeInYears()
        {
            DateTime now = DateTime.Now;
            TimeSpan ageAsTimeSpan = now.Subtract(releaseDate);
            int ageInYears = ageAsTimeSpan.Days / 365;
            return ageInYears;
        }

        public string Consol
        {
            get { return console; }
            set { console = value; }
        }


        public abstract decimal CalculateApproximateValue();
        public virtual string Description()
        {
            string conditionName = Enum.GetName(typeof(Condition), condition);
            string description = string.Format("console: {0}{1}gameTitle: {2}{3}gameDev: {4}{5}Condition: {6}{7}Current Value: {8:c}",
                console,
                Environment.NewLine,
                gameTitle,
                Environment.NewLine,
                gameDev,
                Environment.NewLine,
                conditionName,
                Environment.NewLine,
                CalculateApproximateValue());
            return description;
        }
        int IComparable.CompareTo(object obj)
        {
            Game otherGame = (Game)obj;
            decimal differenceInPrice = this.CalculateApproximateValue() - otherGame.CalculateApproximateValue();
            return Math.Sign(differenceInPrice);
        }
    }
}
