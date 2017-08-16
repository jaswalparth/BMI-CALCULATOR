using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Name: Parth Jaswal
     StudentNumber: 300932823
     date: Aug 15, 2017
     version 0.2: updated bmi calculator
     */
namespace BMI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {

            BmiCalculator BMI = new BmiCalculator();
            BMI.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
