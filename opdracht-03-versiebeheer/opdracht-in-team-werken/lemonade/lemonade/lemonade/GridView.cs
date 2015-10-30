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
    public partial class GridView : UserControl
    {
        public int myIndex;
        

        GridController _controller;
        public GridView(GridController controller)
        {
            _controller = controller;
            
            InitializeComponent();
            //Console.WriteLine("opvragen gridview methode");
        }

        public void GridView_Update(string i)
        {
            //button1.Text = "$" + _controller._model.WaardeButton.ToString();
            button1.Text = i.Substring(0,3);
            
        }
         

        private void GridView_Load(object sender, EventArgs e)
        {
            button1.Text = "$" + _controller._model.WaardeButton;


            button1.Enabled = false;

            if (myIndex == 0)
           {
                button1.Enabled = true;
              
           }
        }
        public void setEmpty(){

            button1.Text = "empty";
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _controller.CheckBuy();
           _controller._marketModel.Index = _controller._view.myIndex;
          
        }

        public void ButtonEnable()
        {
            _controller._model.TheList[_controller._model.Counter]._view.button1.Enabled = true;
        }
    }
}
