using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class scientificCalculator : Form
    {
        
        public scientificCalculator()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create by Vojta 'IT' Horcicka");
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                calculateButton_Click(null, null);
            }
        }

        protected void work()
        {
            if (value.Text == "Work - W")
            {
                float firstValue;
                float secondValue;

                string first = textBox1.Text;
                string second = textBox2.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);

                textBox3.Text = ((firstValue * secondValue) + "");
                statusStrip.Text = "Calculation: F*s";

            }

            if (value.Text == "Distance - s")
            {
                float firstValue;
                float secondValue;

                string first = textBox1.Text;
                string second = textBox3.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);

                textBox2.Text = ((secondValue / firstValue) + "");
                statusStrip.Text = "Calculation: W/F";
            }

            if (value.Text == "Force - F")
            {
                float firstValue;
                float secondValue;

                string first = textBox2.Text;
                string second = textBox3.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);

                textBox1.Text = ((secondValue / firstValue) + "");
                statusStrip.Text = "Calculation: W/s";
            }
        }

        protected void surface()
        {
            if (value.Text == "Surface - S")
            {
                float firstValue;
                float secondValue;

                string first = textBox1.Text;
                string second = textBox2.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);

                textBox3.Text = (firstValue * secondValue) + "";
                statusStrip.Text = "Calculation: a*b";
            }

            if (value.Text == "Distance - a")
            {
                float firstValue;
                float secondValue;

                string first = textBox2.Text;
                string second = textBox3.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);

                textBox1.Text = ((secondValue / firstValue) + "");
                statusStrip.Text = "Calculation: S/b";
            }

            if (value.Text == "Distance - b")
            {
                float firstValue;
                float secondValue;

                string first = textBox1.Text;
                string second = textBox3.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);

                textBox2.Text = ((secondValue / firstValue) + "");
                statusStrip.Text = "Calculation: S/a";
            }
        }

        protected void power() {
            if (value.Text == "Power - P")
            {
                float firstValue;
                float secondValue;

                string first = textBox1.Text;
                string second = textBox2.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);

                textBox3.Text = ((firstValue / secondValue) + "");
                statusStrip.Text = "Calculation: W/t";
            }


                if (value.Text == "Work - W")
                {
                    float firstValue;
                    float secondValue;

                    string first = textBox2.Text;
                    string second = textBox3.Text;

                    firstValue = float.Parse(first);
                    secondValue = float.Parse(second);

                    textBox1.Text = ((firstValue * secondValue) + "");
                    statusStrip.Text = "Calculation: P*t";
                }

                if (value.Text == "Time - t")
                {
                    float firstValue;
                    float secondValue;

                    string first = textBox1.Text;
                    string second = textBox3.Text;

                    firstValue = float.Parse(first);
                    secondValue = float.Parse(second);

                    textBox2.Text = ((firstValue * secondValue) + "");
                    statusStrip.Text = "Calculation: P*W";
                }

    }

        protected void potEnergy()
        {
            if (value.Text == "Potential Energy - Ep")
            {
                float firstValue;
                float secondValue;
                float thirdValue;

                string first = textBox1.Text;
                string second = textBox2.Text;
                string third = textBox3.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);
                thirdValue = float.Parse(third);

                textBox4.Text = ((firstValue * secondValue * thirdValue) + "");
                statusStrip.Text = "Calculation: m*g*h";
            }

            if (value.Text == "Mass - m")
            {
                float firstValue;
                float secondValue;
                float thirdValue;

                string first = textBox2.Text;
                string second = textBox3.Text;
                string third = textBox4.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);
                thirdValue = float.Parse(third);

                textBox1.Text = ((thirdValue / (secondValue * firstValue)) + "");
                statusStrip.Text = "Calculation: Ep/(g*h)";
            }

            if (value.Text == "Gravitational Pull - g")
            {
                float firstValue;
                float secondValue;
                float thirdValue;

                string first = textBox1.Text;
                string second = textBox3.Text;
                string third = textBox4.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);
                thirdValue = float.Parse(third);

                textBox2.Text = ((thirdValue / (secondValue * firstValue)) + "");
                statusStrip.Text = "Calculation: Ep/(m*h)";
            }

            if (value.Text == "Height - h")
            {
                float firstValue;
                float secondValue;
                float thirdValue;

                string first = textBox1.Text;
                string second = textBox2.Text;
                string third = textBox4.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);
                thirdValue = float.Parse(third);

                textBox3.Text = ((thirdValue / (secondValue * firstValue)) + "");
                statusStrip.Text = "Calculation: Ep/(m*g)";
            }
        }

        protected void volume()
        {
            if (value.Text == "Volume - V")
            {
                float firstValue;
                float secondValue;
                float thirdValue;

                string first = textBox1.Text;
                string second = textBox2.Text;
                string third = textBox3.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);
                thirdValue = float.Parse(third);

                textBox4.Text = ((firstValue * secondValue * thirdValue) + "");
                statusStrip.Text = "Calculation: a*b*c";
            }

            if (value.Text == "Distance - a")
            {
                float firstValue;
                float secondValue;
                float thirdValue;

                string first = textBox2.Text;
                string second = textBox3.Text;
                string third = textBox4.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);
                thirdValue = float.Parse(third);

                textBox1.Text = ((thirdValue / (secondValue * firstValue)) + "");
                statusStrip.Text = "Calculation: S/(b*c)";
            }

            if (value.Text == "Distance - b")
            {
                float firstValue;
                float secondValue;
                float thirdValue;

                string first = textBox1.Text;
                string second = textBox3.Text;
                string third = textBox4.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);
                thirdValue = float.Parse(third);

                textBox2.Text = ((thirdValue / (secondValue * firstValue)) + "");
                statusStrip.Text = "Calculation: S/(a*c)";
            }

            if (value.Text == "Distance - c")
            {
                float firstValue;
                float secondValue;
                float thirdValue;

                string first = textBox1.Text;
                string second = textBox2.Text;
                string third = textBox4.Text;

                firstValue = float.Parse(first);
                secondValue = float.Parse(second);
                thirdValue = float.Parse(third);

                textBox3.Text = ((thirdValue / (secondValue * firstValue)) + "");
                statusStrip.Text = "Calculation: S/(a*b)";
            }
        }

        protected void add()
        {
            float firstValue;
            float secondValue;

            string first = textBox1.Text;
            string second = textBox2.Text;

            firstValue = float.Parse(first);
            secondValue = float.Parse(second);

            textBox3.Text = ((firstValue + secondValue) + "");
            statusStrip.Text = "Calculation: a+b";
        }

        protected void subtract()
        {
            float firstValue;
            float secondValue;

            string first = textBox1.Text;
            string second = textBox2.Text;

            firstValue = float.Parse(first);
            secondValue = float.Parse(second);

            textBox3.Text = ((firstValue - secondValue) + "");
            statusStrip.Text = "Calculation: a-b";
        }

        protected void multiply()
        {
            float firstValue;
            float secondValue;

            string first = textBox1.Text;
            string second = textBox2.Text;

            firstValue = float.Parse(first);
            secondValue = float.Parse(second);

            textBox3.Text = ((firstValue * secondValue) + "");
            statusStrip.Text = "Calculation: a*b";
        }

        protected void divide()
        {
            float firstValue;
            float secondValue;

            string first = textBox1.Text;
            string second = textBox2.Text;

            firstValue = float.Parse(first);
            secondValue = float.Parse(second);

            textBox3.Text = ((firstValue / secondValue) + "");
            statusStrip.Text = "Calculation: a/b";
        }

        protected void square()
        {
            float firstValue;

            string first = textBox1.Text;

            firstValue = float.Parse(first);

            textBox2.Text = ((firstValue * firstValue) + "");
            statusStrip.Text = "Calculation: sqr(a)";
        }

        protected void squareRoot()
        {
            float firstValue;

            string first = textBox1.Text;

            firstValue = float.Parse(first);

            textBox2.Text = ((Math.Sqrt(firstValue)) + "");
            statusStrip.Text = "Calculation: sqrRoot(a)";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            if (equation.Text == "Work") work();
            if (equation.Text == "Power") power();
            if (equation.Text == "Surface") surface();
            if (equation.Text == "Volume") volume();
            if (equation.Text == "Add") add();
            if (equation.Text == "Subtract") subtract();
            if (equation.Text == "Multiply") multiply();
            if (equation.Text == "Divide") divide();
            if (equation.Text == "Square Root") squareRoot();
            if (equation.Text == "Square") square();
            if (equation.Text == "Potential Energy") potEnergy();

        }

        private void physicsPanel_Click(object sender, EventArgs e)
        {
            this.equation.Items.Clear();
            //Adding equations
            this.equation.Items.AddRange(new object[] {
            "Work",
            "Power",
            "Calorimetric Equation",
            "Potential Energy"});
            this.textBox1.Enabled = false; this.textBox2.Enabled = false; this.textBox3.Enabled = false; this.textBox4.Enabled = false; this.textBox5.Enabled = false; this.textBox6.Enabled = false; this.textBox7.Enabled = false;
        }
        
        private void chemistryPanel_Click(object sender, EventArgs e)
        {
            this.equation.Items.Clear();
            //Adding equations
            this.equation.Items.AddRange(new object[] { "Molecular Weight", "Molecular Concentration" });           
        }

        private void mathPanel_Click(object sender, EventArgs e)
        {
            this.equation.Items.Clear();
            //Adding equations
            this.equation.Items.AddRange(new object[] {
            "Surface",
            "Volume",
            "Add",
            "Subtract",
            "Multiply",
            "Divide",
            "Square Root",
            "Square"});            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            #region Clean
            this.value.Items.Clear();
            this.textValue1.Text = ""; this.textValue2.Text = ""; this.textValue3.Text = ""; this.textValue4.Text = ""; this.textValue5.Text = ""; this.textValue6.Text = ""; this.textValue7.Text = "";
            this.textBox1.Text = ""; this.textBox2.Text = ""; this.textBox3.Text = ""; this.textBox4.Text = ""; this.textBox5.Text = ""; this.textBox6.Text = ""; this.textBox7.Text = "";
            this.label1.Text = ""; this.label2.Text = ""; this.label3.Text = ""; this.label4.Text = ""; this.label5.Text = ""; this.label6.Text = ""; this.label7.Text = "";
            this.textBox1.Enabled = false; this.textBox2.Enabled = false; this.textBox3.Enabled = false; this.textBox4.Enabled = false; this.textBox5.Enabled = false; this.textBox6.Enabled = false; this.textBox7.Enabled = false;
            #endregion

            #region Update Physics
            // Updating for work equation
            if (equation.Text == "Work") 
            { 
                this.value.Items.AddRange(new object[] { "Force - F", "Distance - s", "Work - W" });
                this.textValue1.Text = "F = "; this.textValue2.Text = "s = "; this.textValue3.Text = "W = ";
                this.label1.Text = "Newtons."; this.label2.Text = "Meters."; this.label3.Text = "Joules.";
                this.textBox1.Enabled = true; this.textBox2.Enabled = true; this.textBox3.Enabled = true;
            }

            // Updating for power equation
            if (equation.Text == "Power") 
            { 
                this.value.Items.AddRange(new object[] { "Work - W", "Time - t", "Power - P" });
                this.textValue1.Text = "W = "; this.textValue2.Text = "t = "; this.textValue3.Text = "P = ";
                this.label1.Text = "Joules."; this.label2.Text = "Seconds."; this.label3.Text = "Watts.";
                this.textBox1.Enabled = true; this.textBox2.Enabled = true; this.textBox3.Enabled = true;
            }

            if (equation.Text == "Calorimetric Equation")
            {
                this.value.Items.AddRange(new object[] { "Mass - m1", "Mass - m2", "Heat Capacity - c1", "Heat Capacity - c2", "Temperature - t1", "Temperature - t2", "Temperature - t" });
                this.textValue1.Text = "m1 = "; this.textValue2.Text = "m2 = "; this.textValue3.Text = "c1 = "; this.textValue4.Text = "c2 = "; this.textValue5.Text = "t1 = "; this.textValue6.Text = "t2 = "; this.textValue7.Text = "t = ";
                this.label1.Text = "Kilograms."; this.label2.Text = "Kilograms."; this.label3.Text = "Joules."; this.label4.Text = "Joules."; this.label5.Text = "°C."; this.label6.Text = "°C."; this.label7.Text = "°C.";
                this.textBox1.Enabled = true; this.textBox2.Enabled = true; this.textBox3.Enabled = true; this.textBox4.Enabled = true; this.textBox5.Enabled = true; this.textBox6.Enabled = true; this.textBox7.Enabled = true;
            }

            if (equation.Text == "Potential Energy")
            {
                this.value.Items.AddRange(new object[] { "Mass - m", "Gravitational Pull - g", "Height - h", "Potential Energy - Ep" });
                this.textValue1.Text = "m = "; this.textValue2.Text = "g = "; this.textValue3.Text = "h = "; this.textValue4.Text = "Ep = ";
                this.label1.Text = "Kilograms."; this.label2.Text = "N/kg."; this.label3.Text = "Meters."; this.label4.Text = "Joules.";
                this.textBox1.Enabled = true; this.textBox2.Enabled = true; this.textBox3.Enabled = true; this.textBox4.Enabled = true;
            }
            #endregion

            #region Update Math
            if (equation.Text == "Surface")
            {
                this.value.Items.AddRange(new object[] { "Distance - a", "Distance - b", "Surface - S" });
                this.textValue1.Text = "a = "; this.textValue2.Text = "b = "; this.textValue3.Text = "S = ";
                this.label1.Text = "Meters."; this.label2.Text = "Meters."; this.label3.Text = "Squared Meters.";
            }
            if (equation.Text == "Volume")
            {
                this.value.Items.AddRange(new object[] { "Distance - a", "Distance - b", "Distance - c", "Volume - V" });
                this.textValue1.Text = "a = "; this.textValue2.Text = "b = "; this.textValue3.Text = "c = "; this.textValue4.Text = "V = ";
                this.label1.Text = "Meters."; this.label2.Text = "Meters."; this.label3.Text = "Meters."; this.label4.Text = "Cubic Meters.";
            }
            if (equation.Text == "Add")
            {
                this.value.Items.AddRange(new object[] {"c"});
                this.textValue1.Text = "a = "; this.textValue2.Text = "b = "; this.textValue3.Text = "c = ";
                this.label1.Text = ""; this.label2.Text = ""; this.label3.Text = "";
            }
            if (equation.Text == "Square Root")
            {
                this.value.Items.AddRange(new object[] { "b" });
                this.textValue1.Text = "a = "; this.textValue2.Text = "b = ";
                this.label1.Text = ""; this.label2.Text = ""; this.label3.Text = "";
            }
            if (equation.Text == "Square")
            {
                this.value.Items.AddRange(new object[] { "b" });
                this.textValue1.Text = "a = "; this.textValue2.Text = "b = ";
                this.label1.Text = ""; this.label2.Text = ""; this.label3.Text = "";
            }


            #endregion
        }
    }
}
    
