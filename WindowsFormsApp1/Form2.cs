using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form2 : Form
    {
      
        public Form2()
        {
            InitializeComponent();
        }
        //Return button
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Calculater = new Form1();
            Calculater.Show();

        }
        
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        //Clear button
        private void Button2_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }


        //Method : Calculate ,show answer
        private void Button1_Click(object sender, EventArgs e)
        {
            txtOutput.Text = (0.621371 * Double.Parse(txtInput.Text)).ToString();
            lblAnswer.Text = " To   miles ";
            lblNum.Text = " Km ";
        }

        private void BtnKm_Click(object sender, EventArgs e)
        {
            txtOutput.Text = (1.6093 * Double.Parse(txtInput.Text)).ToString();
            lblAnswer.Text = " To   Km ";
            lblNum.Text = " miles ";
        }

        private void BtnPound_Click(object sender, EventArgs e)
        {
            txtOutput.Text = (2.20462 * Double.Parse(txtInput.Text)).ToString();
            lblAnswer.Text = " To   lb ";
            lblNum.Text = " Kg ";
        }

        private void Btnkg_Click(object sender, EventArgs e)
        {
            txtOutput.Text = (0.454 * Double.Parse(txtInput.Text)).ToString();
            lblAnswer.Text = " To   Kg ";
            lblNum.Text = " lb ";
        }
    }

    internal class function
    { 
    }
}
