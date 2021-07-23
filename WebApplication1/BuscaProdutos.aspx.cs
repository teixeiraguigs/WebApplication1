using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.RN;
using System.Data;

namespace WebApplication1
{
    public partial class BuscaProdutos : System.Web.UI.Page
    {

        CadProdutosRN objProdutos = new CadProdutosRN();

        protected void Page_Load(object sender, EventArgs e)
        {
            preencheddlCategoria(sender);
           // ddlCategoria.SelectedValue = "";
            pesquisar();
        }

        private void pesquisar()
        {
            Int32? intAux = null;
            if (ddlCategoria.SelectedValue == string.Empty)
            {
                intAux = null;
            }
            else
            {
                intAux = Convert.ToInt32(ddlCategoria.SelectedValue);
            }

            DataTable dtResult = new DataTable();
            dtResult = objProdutos.BuscaProdutos(txtProduto.Text, intAux);

            if (dtResult.Rows.Count > 0)
            {
                gridProdutos.DataSource = dtResult;
                gridProdutos.DataBind();
            }
            else
            {
                gridProdutos.DataSource = null;
                gridProdutos.DataBind();

            }
        }

        private void preencheddlCategoria(object sender)
        {
            DataTable dt = new DataTable();
            dt = objProdutos.BuscaCategorias();
            if(dt.Rows.Count > 0)
            {
                ddlCategoria.DataValueField = "ID";
                ddlCategoria.DataTextField = "DESCRICAO";
                ddlCategoria.DataSource = dt;
                ddlCategoria.DataBind();
            }
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

    }
}