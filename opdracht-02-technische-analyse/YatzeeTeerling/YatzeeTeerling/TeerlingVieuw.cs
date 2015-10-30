using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YatzeeTeerling
{
    public partial class TeerlingVieuw : UserControl
    {
      
        teerlingController _controller;
        public TeerlingVieuw( teerlingController controller)
        {
            InitializeComponent();
            _controller = controller;
        }
      
        private void werpButton_Click(object sender, EventArgs e)
        {

            _controller.Teller();
            if (_controller._model.aantalWorpen <= 3)
            {
                
                _controller.werpTeerling();
            }
            else
            {
                Reset.Visible = true;
            }

            

            teerlingLabel.Text = _controller._model.aantalOgen.ToString();

    
        }

        private void teerlingLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void TeerlingVieuw_Load(object sender, EventArgs e)
        {
      
        }

        public void UpdateUi ()
        {
            //Console.WriteLine(_controller._model.aantalOgen.ToString());
            teerlingLabel.Text = _controller._model.aantalOgen.ToString();
        }

        
        private void Vastzetten_Click(object sender, EventArgs e)
        {

            
            
           
            _controller.vastzetten();
            teerlingLabel.BackColor = (_controller._model.vastzetten == true) ? Color.Red : default(Color);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            _controller._model.aantalWorpen = 0;
            Reset.Visible = false;
        }
    }
}
