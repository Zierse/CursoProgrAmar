using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using PreferenciasDAO_DAL;


namespace PreferenciasBusiness
{
    public class Preferenciasb
    {
        StreamReader objLeitorTxt;
        string strLinhaLida;

        PreferenciasDAO objPreferenciasDAO;

        public List<string> ImpTxtWhile()
        {
            try
            {
                List<string> resultado = new List<string>();

                objLeitorTxt = new StreamReader(@"D:\Learning TI\CURSO_AB\preferencia.txt");
                strLinhaLida = objLeitorTxt.ReadLine();

                while (strLinhaLida != null)
                {
                    resultado.Add(strLinhaLida);
                    strLinhaLida = objLeitorTxt.ReadLine();
                }


                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na Consulta ==> " + ex.Message);
            }
        }

        public List<string> BdCon()
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();

                return objPreferenciasDAO.BdCon();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public List<string> BdDesc()
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();

                return objPreferenciasDAO.BdDesc();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public DataTable ConsultarBd(string strparConsultarPref = null)
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();

                return objPreferenciasDAO.ConsultarBd(strparConsultarPref);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool IncluirBd(string strparIncluirPref)
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();

                return objPreferenciasDAO.IncluirBd(strparIncluirPref);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public bool ExcluirBd(string strparExcluirPref)
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();

                return objPreferenciasDAO.ExcluirBd(strparExcluirPref);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool AlterarBd(string strparPrefNova, string strparPrefAntiga)
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();

                return objPreferenciasDAO.AlterarBd(strparPrefNova, strparPrefAntiga);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
