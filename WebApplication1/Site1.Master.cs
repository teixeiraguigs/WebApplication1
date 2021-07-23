using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Session["Cracha"] = null;
            Session["Tipo"] = null;
            Response.Redirect("fLogin.aspx");
        }

        protected void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            Response.Redirect("BuscaProdutos.aspx");
        }

        protected void btnCadCategoria_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadCategoriaProduto.aspx");
        }

        protected void btnCadProduto_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadProduto.aspx");
        }
    }
}