using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Servicos.Service1Client srv = new Servicos.Service1Client();
        int val1 = Convert.ToInt32(TextBox1.Text);
        int val2 = Convert.ToInt32(TextBox2.Text);
        int sm = srv.Soma(val1, val2);
        Label1.Text = sm.ToString();  

    }
}