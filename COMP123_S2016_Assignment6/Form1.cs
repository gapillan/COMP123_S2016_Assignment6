using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Assignment6
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            double height;
            double weight;
            double results; 

             try
            {
                if (HeightTextBox.Text == "" || WeightTextBox.Text == "")
                {                   
                    MessageBox.Show("*Required: Please fill in all the fields");

                    if ((HeightTextBox.Text == "") || (HeightTextBox.Text == "" && WeightTextBox.Text == ""))
                    {
                        HeightTextBox.Focus();
                    }
                    else
                    {
                        WeightTextBox.Focus();
                    }                    
                }

                try
                {
                    height = Convert.ToDouble(HeightTextBox.Text);
                    weight = Convert.ToDouble(WeightTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please type numbers");
                    HeightTextBox.Clear();
                    WeightTextBox.Clear();
                    HeightTextBox.Focus();
                }

                height = Convert.ToDouble(HeightTextBox.Text);
                weight = Convert.ToDouble(WeightTextBox.Text);


                if ((height <= 0 || weight <= 0) || (height <= 0) || (weight <= 0))
                {
                    MessageBox.Show("Numbers can not be less or equal to 0");

                    if ((height <= 0) || (height <= 0 && weight <= 0))
                    {
                        HeightTextBox.Clear();
                        HeightTextBox.Focus();
                    }
                    else
                    {
                        WeightTextBox.Clear();
                        WeightTextBox.Focus();
                    }
                }

                else {
                    if (ImperialBtn.Checked == true)
                    {
                        results = ((weight * 703)) / ((height * height));
                        ResultsTextBox.Text = Convert.ToString(results);
                        HeightTextBox.Enabled = false;
                        WeightTextBox.Enabled = false;

                        if (results < 18.5)
                        {
                            ResultShowTextBox.Text = Convert.ToString("Underweight");
                        }

                        if ((results > 18.5) && (results < 24.9))
                        {
                            ResultShowTextBox.Text = Convert.ToString("Normal");
                        }

                        if ((results > 25) && (results < 29.9))
                        {
                            ResultShowTextBox.Text = Convert.ToString("Overweight");
                        }

                        if (results > 30)
                        {
                            ResultShowTextBox.Text = Convert.ToString("Obese");
                        }

                    }

                    if (MetricBtn.Checked == true)
                    {
                        results = (weight / (height * height));
                        ResultsTextBox.Text = Convert.ToString(results);
                        HeightTextBox.Enabled = false;
                        WeightTextBox.Enabled = false;

                        if (results < 18.5)
                        {
                            ResultShowTextBox.Text = Convert.ToString("Underweight");
                        }

                        if ((results > 18.5) && (results < 24.9))
                        {
                            ResultShowTextBox.Text = Convert.ToString("Normal");
                        }

                        if ((results > 25) && (results < 29.9))
                        {
                            ResultShowTextBox.Text = Convert.ToString("Overweight");
                        }

                        if (results> 30)
                        {
                            ResultShowTextBox.Text = Convert.ToString("Obese");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Press OK to continue");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            /** 
             *<summary>
             *This shows clearing of the fields
             *<summary>
             */
            HeightTextBox.Clear();
            WeightTextBox.Clear();
            ResultsTextBox.Clear();
            ResultShowTextBox.Clear();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
