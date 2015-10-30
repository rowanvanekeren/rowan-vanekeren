using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YatzeeTeerling
{
    public partial class Yahtzee : Form
    {
        public Yahtzee()
        {
            InitializeComponent();
        }
        
        public int aantalTeerlingen = 4;
       public  List<teerlingController> teerlingen = new List<teerlingController>();
       public teerlingController _controller = new teerlingController();

    
        private void Yahtzee_Load(object sender, EventArgs e)
        {
           
           

            for (int teerlingnummer = 0; teerlingnummer < aantalTeerlingen; ++teerlingnummer)
            {
                teerlingController nieuwTeerling = new teerlingController();
                teerlingen.Add(nieuwTeerling);
                Console.WriteLine( teerlingnummer );
            }

            for (int teerlingnummer = 0; teerlingnummer < aantalTeerlingen; ++teerlingnummer)
            {
                teerlingController huidigeTeerling = teerlingen[teerlingnummer];

                TeerlingVieuw huidigeTeerlingview = huidigeTeerling.getView();

                int xPos = huidigeTeerlingview.Width * teerlingnummer;

                huidigeTeerlingview.Location = new Point(xPos, 0);

                Controls.Add(huidigeTeerlingview);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_controller._model.globaalWorp <= 3) { 
            
            foreach (teerlingController teerling in teerlingen)
            {
                
                teerling.werpTeerling();
                Console.WriteLine(teerling._model.aantalOgen);
                teerling.getView().UpdateUi();
                teerling.Score(teerling._model.aantalOgen);
            }
            _controller._model.globaalWorp++;

            }
            else
            {
                _controller.highscores();
                ScoreForm scoreform = new ScoreForm();
                button2.Visible = true;
                scoreform.Show();
                button1.Visible = false;

                


                
            }


            //for (int teerlingnummer = 0; teerlingnummer < aantalTeerlingen ; ++teerlingnummer)
           // {
             //   teerlingen[teerlingnummer].werpTeerling();
             //   teerlingen[teerlingnummer].getView().UpdateUi();
              
          //  }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            _controller._model.globaalWorp = 0;
            button2.Visible = false;
            _controller._model.totalScore = 0;
            button1.Visible = true;
            
        }
    }
}
