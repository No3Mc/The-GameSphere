using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameshop1
{
    public class PSGame : Game
    {
        public PSGame(string console, string gameTitle, string gameDev, DateTime releaseDate, decimal originalprice, Condition condition)
                : base(console, gameTitle, gameDev, releaseDate, originalprice, condition)
        {

        }

        public override decimal CalculateApproximateValue()
        {
            decimal value = 0;
            if (condition == Condition.mint)
            {
                value = originalPrice * 0.8m; //80% of the original price
            }
            else if (condition == Condition.good)
            {
                value = originalPrice * 0.7m; //70% of the original price
            }
            else if (condition == Condition.fair)
            {
                value = originalPrice * 0.5m; //50% of the original price
            }
            else if (condition == Condition.poor)
            {
                value = originalPrice * 0.4m; //40% of the original price
            }

            int age = CalculateApproximateAgeInYears();

            for (int i = 0; i < age; i++)
            {
                value = value * 0.8m;
            }

            value = Decimal.Round(value, 0);
            value = value - (value % 100);
            value = value + 99;
            return value;
        }
    }
}
