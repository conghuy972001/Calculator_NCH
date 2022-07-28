using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_NCH
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
                textBox.Clear();

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + button.Text;
            }else


            textBox.Text = textBox.Text + button.Text;
            isOperationPerformed = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox.Text);
            //labelCO.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            resultValue = 0;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;
                case "×":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;
                case "÷":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;
            }
        }
    }
}
