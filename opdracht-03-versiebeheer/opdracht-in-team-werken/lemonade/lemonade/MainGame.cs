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

    public partial class MainGame : Form
    {
        public static MoneyController _MoneyController;
        UpgradeController _upgradeController;
        int aantalRijen = 5;
        int aantalKolommen = 5;
       

        int time = 0;
        int day = 1;


        public MainGame()
        {
            InitializeComponent();
        }

        public void Addview()
        {
            int xPos, yPos;
            int index=0;
            for (int i = 0; i < aantalRijen; i++)
            {
                
                //huidigeGridView.Location = new Point(0, yPos);
                for (int j = 0; j < aantalKolommen; j++)
                {
                    GridController huidigeGridController = new GridController();
                    GridView huidigeGridView = huidigeGridController.getView();
                    yPos = huidigeGridView.Height * i;
                    xPos = huidigeGridView.Width * j;
                    huidigeGridView.Location = new Point(xPos, yPos);
                   huidigeGridController._model.TheList.Add(huidigeGridController);

                   huidigeGridController._model.TheList[index]._view.myIndex = index;
                   huidigeGridController._model.TheList[index]._model.WaardeButton = index * 500;
                   
                    index++;
                    panel1.Controls.Add(huidigeGridView);

                    //Controls.Add(huidigeGridView);

                    
                    
                }
                
                
            }
        
            
        }

        private void AddMoneyView()
        {
            _MoneyController = new MoneyController();
            MoneyView huidigeMoneyView = _MoneyController.getView();
            panel2.Controls.Add(huidigeMoneyView);

        }

        private void AddUpgradeView() {
            _upgradeController = new UpgradeController();
            UpgradeView huidigeUpgradeView = _upgradeController.getView();
            upgradePnl.Controls.Add(huidigeUpgradeView);
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            Console.WriteLine("load succes");
            AddMoneyView();
            Addview();
            AddUpgradeView();
            //lblDay.BackColor = Color.Transparent;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //_MoneyController.updateMoney();
            _MoneyController._model.Money += (_MoneyController._model.IncomeAfterUpgrade / 600);
            _MoneyController._view.moneyUpdate();
            lblIncome.Text = "Money per day = $" + (_MoneyController._model.IncomeAfterUpgrade).ToString();

            progressBar1.Value = time;

            if (time == 600)
            {
                time = 0;
                day++;
                lblDay.Text = "Day: " + day.ToString();
            }

                time++;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
