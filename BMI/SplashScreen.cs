﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
