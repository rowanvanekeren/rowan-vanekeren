using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade
{
   public class GridModel
    {

      static List<GridController> gridjes = new List<GridController>();
      static int _counter = 0;
      bool _isBought = false;

      int sellPrice = 0;
      public int SellPrice { get { return sellPrice; } set { sellPrice = value; } }

      int buildingIncome = 0;
      public int BuildingIncome { get { return buildingIncome; } set { buildingIncome = value; } }

       public int Counter { get { return _counter; } set { _counter = value; } }

      bool isBuilt = false;
      public bool IsBuilt { get { return isBuilt; } set { isBuilt = value; } }

      public List<GridController> TheList
      {
          get { return gridjes; }
          set { gridjes = new List<GridController>(value); }
      }
      // bool _enabled;
        int _waardeButton;
        public int WaardeButton {
            get {
                return _waardeButton;
            } 
            set{
                _waardeButton = value;
            } 
        }
        public bool IsBought { get { return _isBought; } set { _isBought = value; } }


       // public bool Gridbool { get {return _enabled } set { _enabled = value } }
    }
}
