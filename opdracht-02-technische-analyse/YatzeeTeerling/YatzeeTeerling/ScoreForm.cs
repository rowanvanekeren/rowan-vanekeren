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
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
            ScoreBoardView score = new ScoreBoardView();
            Controls.Add(score);
        }
        
        
        


    }
}
