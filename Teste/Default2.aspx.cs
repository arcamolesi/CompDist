using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        localService.ServicosSoma srvSomar = new localService.ServicosSoma();
        int v1 = Convert.ToInt32(TextBox1.Text);
        int v2 = Convert.ToInt32(TextBox2.Text);
        int sm = srvSomar.Somar(v1, v2);
        Label1.Text = sm.ToString(); 
    }
}