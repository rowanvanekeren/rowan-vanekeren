using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lemonade
{
    public class GridController
    {
        public MarketController _marketControl = new MarketController();
        public MarketModel _marketModel = new MarketModel();
        
        public GridView _view;
        public GridModel _model;
       

        public GridController()
        {
            _view = new GridView(this);
            _model = new GridModel();
       
            
        }

        public GridView getView()
        {
            //TeerlingVieuw teerling = new TeerlingVieuw();
            return _view;

        }

        public void CheckBuy()
        {
            Console.WriteLine(_model.WaardeButton);

            if (!_model.IsBought)
            {
                if (MainGame._MoneyController._model.Money >= _model.WaardeButton)
                {
                    _model.Counter++;
                    _view.ButtonEnable();
                    _view.setEmpty();
                    _model.IsBought = true;
                    MainGame._MoneyController._model.Money -= _model.WaardeButton;
                    MainGame._MoneyController._view.moneyUpdate();
                }

            }
            else if (_model.IsBought && !_model.IsBuilt)
            {
               
                Market market = new Market();
                
                market.Show();
                
            }
            else if (_model.IsBuilt){
                if (MessageBox.Show ("Are you sure you want to sell this building for $" + _model.SellPrice + "?", "Sell building",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
                {
                    _view.setEmpty();
                    MainGame._MoneyController._model.Money += _model.SellPrice;
                    MainGame._MoneyController._view.moneyUpdate();
                    _model.IsBuilt = false;
                    MainGame._MoneyController._model.Income -= _model.BuildingIncome;
                }
            
            
            }

            



        }

      


        

    }  
}
