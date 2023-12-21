using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_20_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void handMakeClickCacl(object sender, EventArgs e)
        {
            

        }

        private void calc_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = number1.Value;
                decimal num2 = Convert.ToDecimal(number2.Text);
                decimal res = 0;

                char oper = operation.Text[0];
                if (operation.Text.Length != 1)
                    throw new Exception();

                switch (oper)
                {
                    case '+':
                        res = num1 + num2;
                        break;

                    case '-':
                        res = num1 - num2;
                        break;

                    case '*':
                        res = num1 * num2;
                        break;

                    case '/':
                        res = num1 - num2;
                        break;

                    default:
                        throw new Exception();

                }

                result.Text = res.ToString();

            }
            catch (Exception exception)
            {
                result.Text = "Некорректные данные";
            }
        }
    }
}
