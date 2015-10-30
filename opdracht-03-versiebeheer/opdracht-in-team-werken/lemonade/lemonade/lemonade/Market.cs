using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lemonade
{
    public partial class Market : Form
    {
        public Market()
        {
            InitializeComponent();
        }

        private void Market_Load(object sender, EventArgs e)
        {
            AddMoneyView(); 
        }

        private void AddMoneyView()
        {
            MarketController huidigeMarketController = new MarketController();
            MarketView huidigeMarketView = huidigeMarketController.getView();
            pnlMarket.Controls.Add(huidigeMarketView);

        }

   

        private void pnlMarket_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
