using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lemonade
{
    public partial class MoneyView : UserControl
    {
        
        MoneyController _controller;
        public MoneyView(MoneyController controller)
        {
      
            _controller = controller;
        
            InitializeComponent();
        }

        public void moneyUpdate()
        {
            _controller._model.IncomeAfterUpgrade = _controller._model.Income * _controller._model.Multiplier;
            label1.Text = "$" + Math.Floor(_controller._model.Money).ToString();
            //Console.WriteLine("money per day =" + _controller._model.Income);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MoneyView_Load(object sender, EventArgs e)
        {
            label1.Text = "$" + _controller._model.Money.ToString();
            
        }



      
    }
}
