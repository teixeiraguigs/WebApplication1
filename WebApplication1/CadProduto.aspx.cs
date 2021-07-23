using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.RN;
using System.Globalization;

namespace WebApplication1
{
    public partial class CadProduto : System.Web.UI.Page
    {
        CadProdutosRN objProdutos = new CadProdutosRN();
        protected void Page_Load(object sender, EventArgs e)
        {
            preencheddlCategoria(sender);
        }
        private void preencheddlCategoria(object sender)
        {
            DataTable dt = new DataTable();
            dt = objProdutos.BuscaCategorias();
            if (dt.Rows.Count > 0)
            {
                ddlCategoria.DataValueField = "ID";
                ddlCategoria.DataTextField = "DESCRICAO";
                ddlCategoria.DataSource = dt;
                ddlCategoria.DataBind();
            }
        }

        private void InsereProduto(object sender)
        {
            DataTable dt = new DataTable();
            dt = objProdutos.BuscaProdutosCadastrados(txtDescricao.Text);
            if (dt.Rows.Count > 0)
            {
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", "alert('Ja exite este produto')", true);
                limpaCampos();

            }
            else
            {
                string converterFloat = txtPreco.Text;
                float fltPreco = float.Parse(converterFloat);
                objProdutos.InsereProduto(txtDescricao.Text, Convert.ToInt32(ddlCategoria.SelectedValue),
                    fltPreco);
                limpaCampos();
            }
            
        }

        private void limpaCampos()
        {
            txtDescricao.Text = "";
            txtPreco.Text = "";
        }
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            InsereProduto(sender);
        }
    }
}