using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {

    public partial class scientificCalculator : Form {

        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

        public scientificCalculator()
        {
            InitializeComponent();
        }

        

        
        public bool calculations()
        {
           
            return false;
        }
        
        public void equalition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create by Vojta 'IT' Horcicka");
        }

        private void physicsPanel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (equation.Text == "Work")
            {
                if (value.Text == "Work - W")
                {
                    float firstValue;
                    float secondValue;

                    string first = value1.Text;
                    string second = value2.Text;

                    firstValue = float.Parse(first);
                    secondValue = float.Parse(second);

                    try { }
                    catch (Exception)
                    {
                        MessageBox.Show("Exception thrown!");
                    }
                        MessageBox.Show("Total " + (firstValue * secondValue) + " Joules.");
                        stripLabel.Text = "Calculation: F*s";   
                    }
        }

                if (value.Text == "Trajectory - s")
                {
                    float firstValue;
                    float secondValue;

                    string first = value1.Text;
                    string second = value3.Text;

                    firstValue = float.Parse(first);
                    secondValue = float.Parse(second);

                    MessageBox.Show("Total: " + (secondValue / firstValue) + " Meters.");
                }

                if (value.Text == "Force - F")
                {
                    float firstValue;
                    float secondValue;

                    string first = value2.Text;
                    string second = value3.Text;

                    firstValue = float.Parse(first);
                    secondValue = float.Parse(second);

                    MessageBox.Show("Total: " + (secondValue / firstValue) + " Newtons.");
                }
            }
        }
    }

