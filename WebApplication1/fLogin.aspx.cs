using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Geral;
using WebApplication1.RN;

namespace WebApplication1
{
    public partial class fLogin : System.Web.UI.Page
    {

        GeralDAL objGeral = new GeralDAL();
        CadProdutosRN objProdutos = new CadProdutosRN();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtEmail.Attributes.Add("autocomplete", "off");
                txtSenha.Attributes.Add("autocomplete", "off");

            }
        }

        private void Login(object sender)
        {
            string strMsg = VerificaCampos();
            if (strMsg == string.Empty)
            {
                DataTable dtUsuario = new DataTable();
                dtUsuario = objProdutos.BuscaUsuarioLogin(txtEmail.Text);
                if (dtUsuario.Rows.Count > 0)// Verifica se já criou usuario 
                {
                    DataTable dtValidaUsuario = new DataTable();
                    dtValidaUsuario = objProdutos.BuscaUsuarioLoginSenha(txtEmail.Text, txtSenha.Text);
                    if (dtValidaUsuario.Rows.Count > 0)
                    {
                        Response.Redirect("BuscaProdutos.aspx");
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", "alert('Login ou Senha Invalido')", true);
                    }
                }
                else// senão criou o usuario no sistema
                {
                    ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", "alert('Usuário não cadastrado no sistema')", true);

                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", "alert('" + strMsg + "')", true);
            }
        }

        private string VerificaCampos()
        {
            String strMsg = "";

            if (txtEmail.Text == string.Empty)
            {
                strMsg += "\\nCampo Email Obrigatorio";
            }
            if (txtSenha.Text == string.Empty)
            {
                strMsg += "\\nCampo Senha Obrigatorio";
            }

            return strMsg.ToString();
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
                Login(sender);
        }

    }
}