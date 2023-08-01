using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string op;
        public Form1()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            op = "x";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            op = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            op = "-";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            op = "/";
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (op == "+")
            {
                txtResult.Text = (Convert.ToInt32(txtVal1.Text) + Convert.ToInt32(txtVal2.Text)).ToString();
            }

            else if (op == "-")
            {
                txtResult.Text = (Convert.ToInt32(txtVal1.Text) - Convert.ToInt32(txtVal2.Text)).ToString();
            }

            else if (op == "x")
            {
                txtResult.Text = (Convert.ToInt32(txtVal1.Text) * Convert.ToInt32(txtVal2.Text)).ToString();
            }

            else
            {
                txtResult.Text = (Convert.ToInt32(txtVal1.Text) / Convert.ToInt32(txtVal2.Text)).ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVal1.Text = "0";
            txtVal2.Text = "0";
            txtResult.Text = "0";
            txtVal1.Focus();
            txtVal2.SelectAll();
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
