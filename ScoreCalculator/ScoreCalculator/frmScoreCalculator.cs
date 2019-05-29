using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class frmScoreCalculator : Form
    {
        int scoreTotal = 0;
        int scoreCount = 0;

        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = 0;
            int average = 0;

            score = Convert.ToInt32(txtScore.Text);
            scoreCount++;
            scoreTotal = scoreTotal + score;
            average =  scoreTotal / scoreCount;

            txtScoreTotal.Text = Convert.ToString(scoreTotal);
            txtScoreCount.Text = Convert.ToString(scoreCount);
            txtAverage.Text = Convert.ToString(average);

            txtScore.Focus();
        }

        private void btnClearScore_Click(object sender, EventArgs e)
        {
             scoreTotal = 0;
             scoreCount = 0;

            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            txtScore.Text = "";

            txtScore.Focus();
        }
    }
}
