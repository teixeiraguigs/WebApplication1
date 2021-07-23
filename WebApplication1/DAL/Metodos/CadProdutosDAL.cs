using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1.DAL.Procedure;

namespace WebApplication1.DAL.Metodos
{
    public class CadProdutosDAL
    {
        PROC_CADPRODUTOS objProdutos = new PROC_CADPRODUTOS();

        public DataTable BuscaUsuarioLogin(string strLogin)
        {
            try
            {
                return objProdutos.ProcedureProdutos(null, null, null, null, null, null, strLogin, null, 0);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable BuscaUsuarioLoginSenha(string strLogin, string strSenha)
        {
            try
            {
                return objProdutos.ProcedureProdutos(null, null, null, null, null, null, strLogin, strSenha, 1);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable BuscaCategorias()
        {
            try
            {
                return objProdutos.ProcedureProdutos(null, null, 1, null, null, null, null, null, 2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable BuscaProdutos(string strProduto, Int32? intIDCategoria)
        {
            try
            {
                return objProdutos.ProcedureProdutos(null, strProduto, null, null, null, intIDCategoria, null, null, 3);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable InsereProduto(string strProduto, Int32? intIDCategoria, float fltValor)
        {
            try
            {
                return objProdutos.ProcedureProdutos(null, strProduto, null, fltValor, null, intIDCategoria, null, null, 4);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable InsereCategoria(string strCategoria)
        {
            try
            {
                return objProdutos.ProcedureProdutos(null, strCategoria, null, null, null, null, null, null, 5);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable BuscaCategoria(string strCategoria)
        {
            try
            {
                return objProdutos.ProcedureProdutos(null, strCategoria, null, null, null, null, null, null, 6);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable BuscaProdutosCadastrados(string strProduto)
        {
            try
            {
                return objProdutos.ProcedureProdutos(null, strProduto, null, null, null, null, null, null, 7);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}