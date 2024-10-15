using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevFstPOSSuite.Windowforms
{
    public partial class POSNumPad : MetroFramework.Forms.MetroForm
    {
        public string EnteredNumber { get; set; }
        public POSNumPad()
        {
            InitializeComponent();
        }

        private void POSNumPad_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text.Length > 0)
            {
                numberTextBox.Text = numberTextBox.Text.Substring(0, numberTextBox.Text.Length - 1);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EnteredNumber = numberTextBox.Text;
            numberTextBox.Text = "";
            this.Visible = false;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
