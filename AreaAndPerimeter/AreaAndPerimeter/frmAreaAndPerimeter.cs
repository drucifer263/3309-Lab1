using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class frmAreaAndPerimeter : Form
    {
        public frmAreaAndPerimeter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal length = Convert.ToDecimal(txtLength.Text);
            decimal width =  Convert.ToDecimal(txtWidth.Text);

            decimal area = 0;
            decimal perimeter = 0;

            area = length * width;
            perimeter = (2 * length) + (2 * width);

            txtArea.Text = Convert.ToString(area);
            txtPerimeter.Text = Convert.ToString(perimeter);
            txtLength.Focus();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
