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
    public partial class UpgradeView : UserControl
    {
        UpgradeController _controller;
        float firstUpgrade = 2000f;
        float secondUpgrade = 5000f;
        float thirdUpgrade = 10000f;
        public UpgradeView( UpgradeController controller )
        {
            _controller = controller;
            InitializeComponent();
        }

        private void UpgradeView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainGame._MoneyController._model.Money >= firstUpgrade) {
                MainGame._MoneyController._model.Money -= firstUpgrade;
                MainGame._MoneyController._model.Multiplier *= 2;
                button1.Enabled = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MainGame._MoneyController._model.Money >= secondUpgrade)
            {
                MainGame._MoneyController._model.Money -= secondUpgrade;
                MainGame._MoneyController._model.Multiplier *= 2;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MainGame._MoneyController._model.Money >= thirdUpgrade)
            {
                MainGame._MoneyController._model.Money -= thirdUpgrade;
                MainGame._MoneyController._model.Multiplier *= 2;
                button3.Enabled = false;
            }
        }
    }
}
