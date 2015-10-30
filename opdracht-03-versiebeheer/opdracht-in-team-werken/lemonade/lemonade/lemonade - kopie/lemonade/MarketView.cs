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
    public partial class MarketView : UserControl
    {
        int marketIndex = 0;
      MarketController _controller;
        public MarketView(MarketController controller)
        {
            _controller = controller;
            InitializeComponent();
         
        }
        /* List<Button> b ;
       private void makebuttons() {
            b = new List<Button>();
            int x = 10;
            int y = 10;
            int height = 30;
            int width = 50;
            int margin = 4;
            for (int i = 0; i < 5; i++)
            {
                b.Add(new Button());
                b[i].Text = "button " + i;
                b[i].Size = new Size(width, height);
                b[i].Location = new Point(x, y + i * (height + margin));
                Controls.Add(b[i]);
            }
        }*/
        private void MarketView_Load(object sender, EventArgs e)
        {
            marketIndex = 0;
            _controller.setText();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marketIndex = 0;
            _controller.BuyMarket(marketIndex);
            Console.WriteLine("index = " + _controller._model.Index);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            marketIndex = 1;
            _controller.BuyMarket(marketIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            marketIndex = 2;
            _controller.BuyMarket(marketIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            marketIndex = 3;
            _controller.BuyMarket(marketIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            marketIndex = 4;
            _controller.BuyMarket(marketIndex);
        }
        
    }
}
