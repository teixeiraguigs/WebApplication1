using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1.DAL.Metodos;

namespace WebApplication1.RN
{
    public class CadProdutosRN
    {
        CadProdutosDAL objProdutos = new CadProdutosDAL();


        public DataTable BuscaUsuarioLogin(string strLogin)
        {
            try
            {
                return objProdutos.BuscaUsuarioLogin(strLogin);
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
                return objProdutos.BuscaUsuarioLoginSenha(strLogin, strSenha);
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
                return objProdutos.BuscaCategorias();
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
                return objProdutos.BuscaProdutos(strProduto, intIDCategoria);
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
                return objProdutos.InsereProduto(strProduto, intIDCategoria, fltValor);
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
                return objProdutos.InsereCategoria(strCategoria);
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
                return objProdutos.BuscaCategoria(strCategoria);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable BuscaProdutosCadastrados(string strCategoria)
        {
            try
            {
                return objProdutos.BuscaProdutosCadastrados(strCategoria);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}