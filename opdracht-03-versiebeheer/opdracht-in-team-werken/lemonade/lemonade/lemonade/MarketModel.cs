using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade
{
    public class MarketModel
    {
        static int _index;



        public int Index { get { return _index; } set { _index = value; } }
        // name, buy price, profit/day, sell price
        string[,] marketData = new string[5, 4] { 
        { "Lemonade", "300", "200", "150" },
        { "Burger", "600", "400", "300" },
        { "Gin Tonic", "1200", "800", "600" }, 
        { "Oysters", "2400", "1600", "1200" }, 
        { "Champagne", "4800", "3200", "2400" } 
 
        };

        public string[,] MarketData
        {
            get { return marketData; }
            set { marketData = value; }
        }
    }
}
