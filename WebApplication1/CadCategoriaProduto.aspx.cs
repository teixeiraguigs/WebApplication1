using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.RN;

namespace WebApplication1
{
    public partial class CadCategoriaProduto : System.Web.UI.Page
    {
        CadProdutosRN objProdutos = new CadProdutosRN();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void InsereCategoria(object sender)
        {
            DataTable dt = new DataTable();
            dt = objProdutos.BuscaCategoria(txtDescricao.Text);
            if(dt.Rows.Count > 0)
            {
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", "alert('Ja exite esta categoria')", true);
                limpaCampos();

            }
            else
            {
                objProdutos.InsereCategoria(txtDescricao.Text);
                limpaCampos();
            }
            
        }

        private void limpaCampos()
        {
            txtDescricao.Text = "";
        }
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            InsereCategoria(sender);
        }
    }
}