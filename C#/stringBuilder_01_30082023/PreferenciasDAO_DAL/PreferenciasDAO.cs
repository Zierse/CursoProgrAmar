using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace PreferenciasDAO_DAL
{
    public class PreferenciasDAO
    {
        OleDbCommand objComando;
        OleDbConnection objConexao;
        OleDbDataReader objLeitorBd;

        OleDbDataAdapter objAdaptador;
        DataTable objTabela;

        public List<string> BdCon()
        {
            try
            {
                List<string> resultado = new List<string>();

                StringBuilder strSql = new StringBuilder();

                objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\Learning TI\CURSO_AB\preferencias_2_190420221.mdb'");
                objConexao.Open();

                strSql.Append("SELECT ");
                strSql.Append(" Descricao");
                strSql.Append(" FROM ");
                strSql.Append(" Preferencias_3");

                objComando = new OleDbCommand(strSql.ToString(), objConexao);

                objLeitorBd = objComando.ExecuteReader();

                while (objLeitorBd.Read())
                {
                    resultado.Add(objLeitorBd["Descricao"].ToString());
                }

                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Consulta ==> " + ex.Message);
            }
            finally
            {
                objLeitorBd.Close();

                objConexao.Close();
            }

        }

        public List<string> BdDesc()
        {
            try
            {
                List<string> resultado = new List<string>();

                StringBuilder strSql = new StringBuilder();

                objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\Learning TI\CURSO_AB\preferencias_2_190420221.mdb'");

                strSql.Append("SELECT ");
                strSql.Append(" Descricao");
                strSql.Append(" FROM ");
                strSql.Append(" Preferencias_3");

                objComando = new OleDbCommand(strSql.ToString(), objConexao);

                objAdaptador = new OleDbDataAdapter(objComando);

                objTabela = new DataTable();

                objAdaptador.Fill(objTabela);

                foreach (DataRow linhaDaTabela in objTabela.Rows)
                {
                    resultado.Add(linhaDaTabela["Descricao"].ToString());
                }

                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Consulta ==> " + ex.Message);
            }

        }

        public DataTable ConsultarBd(string strparConsultarPref = null)
        {
            try
            {
                List<string> resultado = new List<string>();

                StringBuilder strSql = new StringBuilder();

                objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\Learning TI\CURSO_AB\preferencias_2_190420221.mdb'");

                strSql.Append("SELECT ");
                strSql.Append(" Descricao");
                strSql.Append(" FROM ");
                strSql.Append(" Preferencias_3");

                if (string.IsNullOrEmpty(strparConsultarPref))
                {
                    objComando = new OleDbCommand(strSql.ToString(), objConexao);
                }
                else
                {
                    strSql.Append(" WHERE");
                    strSql.Append(" Descricao = '" + strparConsultarPref + "'");

                    objComando = new OleDbCommand(strSql.ToString(), objConexao);
                }

                objAdaptador = new OleDbDataAdapter(objComando);

                objTabela = new DataTable();

                objAdaptador.Fill(objTabela);

                return objTabela;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Consulta ==> " + ex.Message);
            }

        }

        public bool IncluirBd(string strparIncluirPref)
        {
            try
            {
                bool bolResultado = false;

                StringBuilder strSql = new StringBuilder();

                objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\Learning TI\CURSO_AB\preferencias_2_190420221.mdb'");
                objConexao.Open();

                strSql.Append("INSERT INTO ");
                strSql.Append(" Preferencias_3 ");
                strSql.Append(" (Descricao)");
                strSql.Append(" VALUES ");
                strSql.Append(" ('" + strparIncluirPref + "')");

                objComando = new OleDbCommand(strSql.ToString(), objConexao);

                if (objComando.ExecuteNonQuery() > 0)
                {
                    bolResultado = true;
                }
                else
                {
                    bolResultado = false;
                }

                return bolResultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Consulta ==> " + ex.Message);
            }
            finally
            {
                objConexao.Close();
            }

        }

        public bool ExcluirBd(string strparExcluirPref)
        {
            try
            {
                bool bolResultado = false;

                StringBuilder strSql = new StringBuilder();

                objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\Learning TI\CURSO_AB\preferencias_2_190420221.mdb'");
                objConexao.Open();

                strSql.Append("DELETE");
                strSql.Append(" FROM");
                strSql.Append(" Preferencias_3");
                strSql.Append(" WHERE");
                strSql.Append(" Descricao = '" + strparExcluirPref + "'");


                objComando = new OleDbCommand(strSql.ToString(), objConexao);

                if (objComando.ExecuteNonQuery() > 0)
                {
                    bolResultado = true;
                }
                else
                {
                    bolResultado = false;
                }

                return bolResultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Consulta ==> " + ex.Message);
            }
            finally
            {
                objConexao.Close();
            }

        }

        public bool AlterarBd(string strparPrefNova, string strparPrefAntiga)
        {
            try
            {
                bool bolResultado = false;

                StringBuilder strSql = new StringBuilder();

                objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\Learning TI\CURSO_AB\preferencias_2_190420221.mdb'");
                objConexao.Open();

                strSql.Append("UPDATE");
                strSql.Append(" Preferencias_3");
                strSql.Append(" SET");
                strSql.Append(" Descricao = '" + strparPrefNova + "'");
                strSql.Append(" WHERE");
                strSql.Append(" Descricao = '" + strparPrefAntiga + "'");


                objComando = new OleDbCommand(strSql.ToString(), objConexao);

                if (objComando.ExecuteNonQuery() > 0)
                {
                    bolResultado = true;
                }
                else
                {
                    bolResultado = false;
                }

                return bolResultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Consulta ==> " + ex.Message);
            }
            finally
            {
                objConexao.Close();
            }

        }

    }
}
