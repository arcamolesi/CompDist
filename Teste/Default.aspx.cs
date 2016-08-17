using System;
using br.com.correios.apps; 
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
        br.com.correios.apps.AtendeClienteService obj = new br.com.correios.apps.AtendeClienteService();
        enderecoERP end = new enderecoERP();
        List<enderecoERP> listaEndereco = new List<enderecoERP>(); 
        end = obj.consultaCEP("19806-181");
       
        Label1.Text = end.id.ToString();
        Label2.Text = end.end + " "+ end.complemento +" " + end.complemento2;
        Label3.Text = end.cidade;
        Label4.Text = end.cep;
        listaEndereco.Add(end);

        GridView1.DataSource = listaEndereco; 
        GridView1.DataBind();
        
    }
}