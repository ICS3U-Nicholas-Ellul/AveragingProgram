using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AveragingProgram
{
    public partial class frmAverageCalculator : Form
    {
        int counter = 1;
        decimal totalNumber = 0;

        public frmAverageCalculator()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            decimal inputNumber = this.nudInput.Value;
            decimal average;

            if( inputNumber != -1)
            {
                this.lstListOfNumbers.Items.Add(inputNumber);
                totalNumber = totalNumber + inputNumber;
                average = totalNumber / counter;
                counter++;

                this.lblAverage.Text = "The average is: " + average;
            }
        }
 
    }
          public decimal RoundNumbers(decimal a,int b)
    {

    }
}
