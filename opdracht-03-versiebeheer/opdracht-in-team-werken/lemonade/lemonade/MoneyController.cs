using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade
{
    public class MoneyController
    {
        
        public MoneyView _view;
        public MoneyModel _model;
        
        public MoneyController(){

            _view = new MoneyView(this);
            _model = new MoneyModel();



    }
        public MoneyView getView()
        {

            return _view;
        }

        public void updateMoney() {
            _model.Money += (_model.Income / 600);
            _view.moneyUpdate();
           
        }
     
    }
 }
