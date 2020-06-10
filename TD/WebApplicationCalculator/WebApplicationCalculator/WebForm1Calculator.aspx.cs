using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationCalculator.ServiceReference1;

namespace WebApplicationCalculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private CalculatorSoapClient calculatorSoapReference;
        protected void Page_Load(object sender, EventArgs e)
        {
            calculatorSoapReference = new CalculatorSoapClient();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.Add.Checked == true)
            {
                this.Label3.Text = calculatorSoapReference.Add(int.Parse(TextBox1.Text), int.Parse(this.TextBox2.Text)).ToString();
            } else if (this.Divide.Checked == true)
            {
                this.Label3.Text = calculatorSoapReference.Divide(int.Parse(TextBox1.Text), int.Parse(this.TextBox2.Text)).ToString();

            }
            else if (this.Multiply.Checked == true)
            {
                this.Label3.Text = calculatorSoapReference.Multiply(int.Parse(TextBox1.Text), int.Parse(this.TextBox2.Text)).ToString();

            }
            else
            {
                this.Label3.Text = calculatorSoapReference.Subtract(int.Parse(TextBox1.Text), int.Parse(this.TextBox2.Text)).ToString();

            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}