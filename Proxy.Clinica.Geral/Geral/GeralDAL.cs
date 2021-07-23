using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Globalization;
using System.Management;
using System.IO;



namespace Geral
{
    public class GeralDAL
    {
        public GeralDAL()
        {
            //int x = 0;
            //string linha;
            strConexao = @"Data Source=GUILHERME2;Initial Catalog=TesteTI;User ID=sa; Password=satellite;";
            //System.IO.StreamReader file = new System.IO.StreamReader(@"C:\MedClinicas\Config.ini");
            //while ((linha = file.ReadLine()) != null)
            //{
            //    if (linha.Substring(0, 8) == "DataBase")
            //    {
                    
            //    }
            //    x++;
            //}
            //file.Close();
        }
        public string strConexao;
        public DataTable IniciaTabelaParam(DataTable dtParametro)
        {
            dtParametro.Clear();
            if (!dtParametro.Columns.Contains("parametro"))
            {
                dtParametro.Columns.Add("parametro", typeof(string));
            }
            if (!dtParametro.Columns.Contains("valor"))
            {
                dtParametro.Columns.Add("valor", typeof(object));
            }
            if (!dtParametro.Columns.Contains("tipo"))
            {
                dtParametro.Columns.Add("tipo", typeof(string));
            }
            
            return dtParametro;
        }
        public void PrenncheTabelaParam(DataTable dtParametro,string strParametro,object objValor,string strTipo)
        {
            DataRow drLinha = dtParametro.NewRow();
            drLinha["parametro"] = strParametro;
            drLinha["valor"] = objValor;
            drLinha["tipo"] = strTipo;
            dtParametro.Rows.Add(drLinha);
        }
        public DataTable ExecutaProcedure(string strProcedure,DataTable dtParametros)
        {
            DataSet ds = new DataSet();

            SqlConnection conexao = null;
            try
            {

                //conexao = new SqlConnection(strConexao);
                conexao = new SqlConnection(strConexao);

                SqlCommand cmd = new SqlCommand(strProcedure, conexao);

                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DataRow drLinha in dtParametros.Rows)
                {
                if (drLinha["valor"].ToString() != string.Empty)
                    {
                        switch (drLinha["tipo"].ToString())
                        {
                            case "texto": 
                                cmd.Parameters.AddWithValue(drLinha["parametro"].ToString(), Convert.ToString(drLinha["valor"]));
                                break;
                            case "int":
                                cmd.Parameters.AddWithValue(drLinha["parametro"].ToString(), Convert.ToInt32(drLinha["valor"]));
                                break;
                            case "data":
                                cmd.Parameters.AddWithValue(drLinha["parametro"].ToString(), Convert.ToDateTime(drLinha["valor"]));
                                break;
                            case "real":
                                cmd.Parameters.AddWithValue(drLinha["parametro"].ToString(), Convert.ToDouble(drLinha["valor"]));
                                break;
                            case "char":
                                cmd.Parameters.AddWithValue(drLinha["parametro"].ToString(), Convert.ToChar(drLinha["valor"]));
                                break;
                            case "foto":
                                cmd.Parameters.AddWithValue(drLinha["parametro"].ToString(), (byte[])drLinha["valor"]);
                                break;
                        } 
                    }
                    
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    return ds.Tables[0];
                }
                else
                {
                    ds.Tables.Add();
                    return ds.Tables[0];
                }


            }

            catch (Exception ex)
            {

                throw ex;

            }

            finally
            {

                conexao.Close();

            }

        }

        public string GeraSenha(string strSenha)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] senha;
            using (HashAlgorithm hash = SHA1.Create())
                senha = hash.ComputeHash(encoding.GetBytes(strSenha));
            StringBuilder hashValue = new StringBuilder(senha.Length * 2);
            foreach (byte b in senha)
            {
                hashValue.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);
            }
            return hashValue.ToString();
        }

        public bool ValidaCPF(string vrCPF) 
        {
            
            string valor = vrCPF.Replace(",", "");
            valor = valor.Replace("-", ""); 
            if (valor.Length != 11) 
                return false; 
            bool igual = true;
            for (int i = 1; i < 11 && igual; i++) 
                if (valor[i] != valor[0]) 
                    igual = false; 
            if (igual || valor == "12345678909") 
                return false; 
            int[] numeros = new int[11]; 
            for (int i = 0; i < 11; i++) 
                numeros[i] = int.Parse( valor[i].ToString()); 
            int soma = 0; 
            for (int i = 0; i < 9; i++) 
                soma += (10 - i) * numeros[i];
            int resultado = soma % 11; 
            if (resultado == 1 || resultado == 0) 
            {
                if (numeros[9] != 0) return false; 
            } 
            else if (numeros[9] != 11 - resultado) 
                return false; 
            soma = 0; 
            for (int i = 0; i < 10; i++) 
                soma += (11 - i) * numeros[i]; 
            resultado = soma % 11; 
            if (resultado == 1 || resultado == 0) 
            {
                if (numeros[10] != 0) return false; 
            } 
            else if (numeros[10] != 11 - resultado) 
                return false;
            return true;
        }

        public String CalculaIdade(DateTime dt)
        {
            Int32 intResult = (DateTime.Today.Year - dt.Year);
            string strResultado = "";
            if (DateTime.Now.Month < dt.Month || (DateTime.Now.Month == dt.Month && DateTime.Now.Day < dt.Day))
            {
                intResult = intResult - 1;
            }
            if (intResult > 1)
            {
                strResultado = "Idade: " + intResult.ToString()+ " anos";
            }
            else if (intResult == 1)
            {
                strResultado = "Idade: " + intResult.ToString() + " ano";
            }
            else if (intResult == 0)
            {
                Int32 intMes = (DateTime.Today.Month - dt.Month);
                if (intMes > 1)
                {
                    strResultado = "Idade: " + intMes.ToString() + " meses";
                }
                else if (intMes == 1)
                {
                    strResultado = "Idade: " + intMes.ToString() + " mês";
                }
                else if (intMes == 0)
                {
                    strResultado = "Idade";
                }
                
            }
            return strResultado;
        }
        public string VerificaSerialHD()
        {

            ManagementClass particaoClass = new ManagementClass("Win32_LogicalDisk");
            particaoClass.Get();
            ManagementObjectCollection particoes = particaoClass.GetInstances();
            String serialHD = "";
            foreach (ManagementObject particao in particoes)
            {
                if (particao["VolumeSerialNumber"] != null)
                {
                    serialHD = particao["VolumeSerialNumber"].ToString();
                    break;
                }
            }
            return serialHD;


        }
        public void EscreveLog(string strMsg)
        {
            string strPathFile = @"C:\inetpub\wwwroot\ControleTreinamento\log.txt";
            try
            {

                //Verifico se o arquivo que desejo abrir existe e passo como parâmetro a respectiva variável

                if (File.Exists(strPathFile))
                {

                    //Crio um using, dentro dele instancio o StreamWriter, uso a classe File e o método

                    //AppendText para concatenar o texto, passando como parâmetro a variável strPathFile

                    using (StreamWriter sw = File.AppendText(strPathFile))
                    {

                        //Uso o método Write para escrever o arquivo que será adicionado no arquivo texto

                        sw.Write("\r\n" + strMsg);

                    }

                }
                else
                {

                    //Se não existir exibo a mensagem

                    MessageBox.Show("Arquivo não encontrado!");

                }

            }
            catch (Exception ex)
            {

                throw (ex);

            }

        }

    }
}
