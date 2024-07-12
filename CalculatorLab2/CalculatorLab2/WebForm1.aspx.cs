using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorLab2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        com.dneonline.www.Calculator myWS = new com.dneonline.www.Calculator();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a, b, apot;
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            apot = myWS.Add(a, b);
            Label1.Text = Convert.ToString(apot);

        }

        protected void btnaferesh_Click(object sender, EventArgs e)
        {
            int a, b, apot;
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            apot = myWS.Subtract(a,b);
            Label1.Text = Convert.ToString(apot);
        }

        protected void brndiairesh_Click(object sender, EventArgs e)
        {
            int a, b, apot;
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            if (b != 0)
            {
                apot = myWS.Divide(a, b);
                Label1.Text = Convert.ToString(apot);
            }
            else if (a != 0)
                Label1.Text = "Αδύνατη πράξη";
            else
                Label1.Text = "Αοριστία";
        }

        protected void brnpollaplasiasmos_Click(object sender, EventArgs e)
        {
            int a, b, apot;
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            apot = myWS.Multiply(a, b);
            Label1.Text = Convert.ToString(apot);
        }

        protected void clear_Click(object sender, EventArgs e)
        {

        }
    }
}