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
    public partial class Form1 : Form
    {//FORM main

        string input="";
        public string Operator ;
        double Result = 0;

        

//select culuculate icons(operater)


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //select 10bottuns 
        private void Btn1_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            string text = btn.Text;
            input += text;   //input belong to the commanded number
            txtAnswer.Text = input;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            double number1 = Result;
            double number2 ;

            //culculater system
            if (input != "")
            {

                number2 = double.Parse(input);


                if (Operator == "+")
                    Result = number1 + number2;
                if (Operator == "-")
                    Result = number1 - number2;
                if (Operator == "*")
                    Result = number1 * number2;
                if (Operator == "/")
                    Result = number1 / number2;
                if (Operator == null)
                    Result = number2;
            }
            txtAnswer.Text = Result.ToString();
            input = "";

            Button btn = (Button)sender;
            Operator = btn.Text;

            if (Operator == "=")
                Operator = "";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Conversion = new Form2();
            Conversion.Show();
            
        }

        private void BtnClear_Click_1(object sender, EventArgs e)
        {
            txtAnswer.Clear();
            Result = 0;
            Operator = null;
        }
    }
}
