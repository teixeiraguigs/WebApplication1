using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Geral;
using System.Data;

namespace WebApplication1.DAL.Procedure
{
    public class PROC_CADPRODUTOS
    {
        DataTable dtParametro = new DataTable();
        GeralDAL objGeral = new GeralDAL();


        public DataTable ProcedureProdutos(Int32? intID, string strDescricao, Int32? intStatus, float? fltPreco, Int32? intIDUsuario, Int32? intIDCategoria,
                                            string strLogin, string strSenha, Int32? intAcao)
        {
            DataSet ds = new DataSet();
            try
            {
                dtParametro = objGeral.IniciaTabelaParam(dtParametro);
                objGeral.PrenncheTabelaParam(dtParametro, "@ID", intID, "int");
                objGeral.PrenncheTabelaParam(dtParametro, "@DESCRICAO", strDescricao, "texto");
                objGeral.PrenncheTabelaParam(dtParametro, "@STATUS", intStatus, "int");
                objGeral.PrenncheTabelaParam(dtParametro, "@PRECO", fltPreco, "float");
                objGeral.PrenncheTabelaParam(dtParametro, "@IDUSUARIO", intIDUsuario, "int");
                objGeral.PrenncheTabelaParam(dtParametro, "@IDCATEGORIA", intIDCategoria, "int");
                objGeral.PrenncheTabelaParam(dtParametro, "@LOGIN", strLogin, "texto");
                objGeral.PrenncheTabelaParam(dtParametro, "@SENHA", strSenha, "texto");
                objGeral.PrenncheTabelaParam(dtParametro, "@ACAO", intAcao, "int");
                return objGeral.ExecutaProcedure("CadProdutos.PROC_CADPRODUTOS", dtParametro);


            }

            catch (Exception ex)
            {

                throw ex;

            }
        }
    }
}