﻿using System;
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

     */
namespace BMI
{
    public partial class BmiCalculator : Form
    {
        public BmiCalculator()
        {
            InitializeComponent();
        }
        private double _height;
        private double _weight;
        public double _Result;
        double height;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cm.Text = "inch";
                kg.Text = "lbs";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cm.Text = "cm";
                kg.Text = "kg";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            value.BackColor = Color.White;
            // if radio button metric or imperial is selected then
            if (radioButton2.Checked)
            {
                radioButton1_CheckedChanged(sender, e);
                height = _height / 100;
                textBox2.ReadOnly.ToString();
                textBox1.ReadOnly.ToString();
                _Result = (_weight / (height * height));
                value.Text = _Result.ToString();
               value.BackColor = Color.White;
            }
            if (radioButton1.Checked)
            {
                radioButton1_CheckedChanged(sender, e);
                textBox2.ReadOnly.ToString();
                textBox1.ReadOnly.ToString();
                _Result = (_weight / (_height * _height)) * 702;
                value.Text = _Result.ToString();
               value.BackColor = Color.White;
            }
            if (_Result <= 18.5)
            {
                value.Text = _Result + " You are Underweight";
            }
            else if (_Result <= 24.9)
            {
                value.Text = _Result + "You are Healthy";
            }
            else if (_Result <= 29.9)
            {
                value.Text = _Result + " You are Overweight";
            }
            else if (_Result >= 30.0)
            {
                value.Text = _Result + "You are Obese";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _height = double.Parse(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _weight = double.Parse(textBox1.Text);
        }
    }
}

