using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameshop1
{
    public class Shop
    {
        private List<Game> gamesStock;
        private int currentlyViewedGame = 0;

        public Shop()
        {
            gamesStock = new List<Game>();
        }

        public int CurrentlyViewedGame
        {
            get { return currentlyViewedGame; }
        }

        public int Numberofgames
        {
            get { return gamesStock.Count; }
        }

        public string DescribeCurrentGame()
        {
            string description;
            if (gamesStock.Count > 0)
            {
                description = gamesStock[currentlyViewedGame].Description();
            }
            else
            {
                description = "No games available in stock";
            }
            return description;
        }
        public void AddGame(Game game)
        {
            gamesStock.Add(game);
        }
        public void RemoveGameAt(int index)
        {
            if (index < gamesStock.Count)
            {
                gamesStock.RemoveAt(index);
                LegaliseCurrentlyViewedGame();
            }
        }
        private void LegaliseCurrentlyViewedGame()
        {
            if (currentlyViewedGame > (gamesStock.Count - 1))
            {
                currentlyViewedGame = gamesStock.Count - 1;
                if (currentlyViewedGame < 0)
                {
                    currentlyViewedGame = 0;
                }
            }
        }
        public bool IsPreviousGame()
        {
            if(currentlyViewedGame > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsNextGame()
        {
            if (currentlyViewedGame < gamesStock.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void StepToPreviousGame()
        {
            if (IsPreviousGame())
            {
                currentlyViewedGame--;
            }
        }
        public void StepToNextGame()
        {
            if (IsNextGame())
            {
                currentlyViewedGame++;
            }
        }
    }

}
