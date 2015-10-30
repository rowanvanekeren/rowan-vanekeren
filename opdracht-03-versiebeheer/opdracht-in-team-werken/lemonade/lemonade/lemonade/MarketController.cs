using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lemonade
{
    public class MarketController
    {
       
        public MarketModel _model;
        public MarketView _view;


       public GridController  _gridController1;
        public MarketController()
        {
            _model = new MarketModel();
            _view = new MarketView(this);
         
        }

        public MarketView getView()
        {
            //TeerlingVieuw teerling = new TeerlingVieuw();
            return _view;

        }

        public void setText() {
          
            _view.button1.Text = _model.MarketData[0,0];
            _view.button2.Text = _model.MarketData[1,0];
            _view.button3.Text = _model.MarketData[2,0];
            _view.button4.Text = _model.MarketData[3,0];
            _view.button5.Text = _model.MarketData[4, 0];

            _view.label1.Text = _model.MarketData[0, 1];
            _view.label2.Text = _model.MarketData[0, 2];
            _view.label3.Text = _model.MarketData[1, 1];
            _view.label4.Text = _model.MarketData[1, 2];
            _view.label5.Text = _model.MarketData[2, 1];
            _view.label6.Text = _model.MarketData[2, 2];
            _view.label7.Text = _model.MarketData[3, 1];
            _view.label8.Text = _model.MarketData[3, 2];
            _view.label9.Text = _model.MarketData[4, 1];
            _view.label10.Text = _model.MarketData[4, 2];

        }


        public void BuyMarket(int getIndexMarket  )
        {
            _gridController1 = new GridController();
            //Console.WriteLine(_moneyController._model.Money);

            if (MainGame._MoneyController._model.Money >= Int32.Parse(_model.MarketData[getIndexMarket, 1]))
            {

                _gridController1._model.TheList[_model.Index]._view.GridView_Update(_model.MarketData[getIndexMarket, 0]);
                MainGame._MoneyController._model.Money -= Int32.Parse(_model.MarketData[getIndexMarket, 1]); //take away price of building from total money

                MainGame._MoneyController._model.Income += Int32.Parse(_model.MarketData[getIndexMarket, 2]); //add income of building to total income
                
                _gridController1._model.TheList[_model.Index]._model.BuildingIncome = Int32.Parse(_model.MarketData[getIndexMarket, 2]); //set building income in the grid model, so when we sell it, it can be subtracted from total income

                MainGame._MoneyController._view.moneyUpdate();
                Market.ActiveForm.Close();
                _gridController1._model.TheList[_model.Index]._model.IsBuilt = true;
                _gridController1._model.TheList[_model.Index]._model.SellPrice = Int32.Parse(_model.MarketData[getIndexMarket, 3]);

            }

        }




    }
}
