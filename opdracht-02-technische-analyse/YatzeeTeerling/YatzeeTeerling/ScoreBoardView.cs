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
    public partial class ScoreBoardView : UserControl
    {
        public ScoreBoardView()
        {
            InitializeComponent();
        }

        private void ScoreBoardView_Load(object sender, EventArgs e)
        {
            teerlingController controller = new teerlingController();
            CurrentScore.Text = controller._model.totalScore.ToString();

            score1.Text = controller._model.MyNumbers[0].ToString();
                score2.Text =controller._model.MyNumbers[1].ToString();
                score3.Text =controller._model.MyNumbers[2].ToString();
                score4.Text = controller._model.MyNumbers[3].ToString();

        }
    }
}
