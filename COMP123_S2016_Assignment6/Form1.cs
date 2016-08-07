using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Author: Golden Pamela Apillanes 
 * Student#: 300867201
 * Date: August 4th 2016
 * Description: Assignment 6 - BMI Calculator
 */
namespace COMP123_S2016_Assignment6
{
    /**
     * <summary> 
     * This class is the "driver" class for our program
     * </summary>
     * 
     * @class Program
     */
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

        /** 
         * <summary> 
         * This eventhandler submits the content of the form when clicked 
         * </summary>
         * 
         * @method SubmitBtn_Click 
         * @param {object} sender
         * @param {EventArgs} e
         */
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            double height;
            double weight;
            double BMI; 

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
                        BMI = ((weight * 703)) / ((height * height));
                        ResultsTextBox.Text = Convert.ToString(BMI);
                        HeightTextBox.Enabled = false;
                        WeightTextBox.Enabled = false;

                        if (BMI < 18.5)
                        {
                            ResultShowTextBox.Text = Convert.ToString("Underweight");
                        }

                        if ((BMI > 18.5) && (BMI < 24.9))
                        {
                            ResultShowTextBox.Text = Convert.ToString("Normal");
                        }

                        if ((BMI > 25) && (BMI < 29.9))
                        {
                            ResultShowTextBox.Text = Convert.ToString("Overweight");
                        }

                        if (BMI > 30)
                        {
                            ResultShowTextBox.Text = Convert.ToString("Obese");
                        }

                    }

                    if (MetricBtn.Checked == true)
                    {
                        BMI = (weight / (height * height));
                        ResultsTextBox.Text = Convert.ToString(BMI);
                        HeightTextBox.Enabled = false;
                        WeightTextBox.Enabled = false;

                        if (BMI < 18.5)
                        {
                            ResultShowTextBox.Text = Convert.ToString("Underweight");
                        }

                        if ((BMI > 18.5) && (BMI < 24.9))
                        {
                            ResultShowTextBox.Text = Convert.ToString("Normal");
                        }

                        if ((BMI > 25) && (BMI < 29.9))
                        {
                            ResultShowTextBox.Text = Convert.ToString("Overweight");
                        }

                        if (BMI> 30)
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

        /** 
         * <summary> 
         * This evenhandler clears the content of the form when clicked 
         * </summary>
         * 
         * @method CleartBtn_Click 
         * @param {object} sender
         * @param {EventArgs} e
         */
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            HeightTextBox.Clear();
            WeightTextBox.Clear();
            ResultsTextBox.Clear();
            ResultShowTextBox.Clear();
        }

        /** 
         * <summary> 
         * This evenhandler closes the content of the form when clicked 
         * </summary>
         * 
         * @method CloseBtn_Click 
         * @param {object} sender
         * @param {EventArgs} e
         */
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Program?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
