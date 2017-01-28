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
 	App name:Assignment 1;   	
    Author's name: Ming Ying;
    App	Creation Date; 2017.1.28
    App description: it is built for calculating the bonus money that employee's made for themselfs.
     
     
     */
namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            hoursWorked.Text = "0";
            totalSales.Text = "0";
            salesBonus.Text = "0";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void hoursWorked_TextChanged(object sender, EventArgs e)
        {
            int tmp;
            if (!int.TryParse(hoursWorked.Text, out tmp))
            {
                MessageBox.Show("Please enter the number");
                hoursWorked.Text = "0";
            }
            if(int.Parse(hoursWorked.Text)>160)
            {
                MessageBox.Show("The hours worked cant be more than 160.");
                hoursWorked.Text = "0";
            }
            if (int.Parse(hoursWorked.Text) < 0)
            {
                MessageBox.Show("The hours worked cant be negative number.");
                hoursWorked.Text = "0";
            }
        }

        private void totalSales_TextChanged(object sender, EventArgs e)
        {
            double tmp;
            if (!double.TryParse(totalSales.Text, out tmp))
            {
                MessageBox.Show("Please enter the number ");
                totalSales.Text = "0";
            }
            

            

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            /*PHW = percentage of hours worked
             TBA = total bonus amount
             SB = salesBonus
         
             */
         
            double PHW = double.Parse(hoursWorked.Text)/160;
            double TBA = double.Parse(totalSales.Text) * 0.02;
            double SB = PHW * TBA;
            salesBonus.Text = SB.ToString("c3");
            




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The form has been sent to printer!");
        }
    }
}
