﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstUI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnEquals_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            string operatorChoice;

            number1 = int.Parse(txtNum1.Text);
            number2 = int.Parse(txtNum2.Text);
            operatorChoice = txtOperator.Text;

            switch (operatorChoice)
            {
                case "+":
                    txtAnswer.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txtAnswer.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    txtAnswer.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    txtAnswer.Text = (number1 / number2).ToString();
                    break;
           
            }


            }

        }
    }

