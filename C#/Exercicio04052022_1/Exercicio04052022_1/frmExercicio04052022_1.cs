using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;


namespace Exercicio04052022_1
{
    public partial class frmExercicio04052022_1 : Form
    {
        StreamReader objLeitorTxt;
        string strLinhaLida;

        OleDbCommand objComando;
        OleDbConnection objConexao;
        OleDbDataReader objLeitorBD;

        OleDbDataAdapter objAdaptador;
        DataTable objTabela;
        
        public frmExercicio04052022_1()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parabéns! Você exibiu uma Mensagem!", "AVISO");
        }

        private void btnDesvCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clique em OK ou CANCELAR!", "DESVIO CONDICIONAL", MessageBoxButtons.OKCancel)== System.Windows.Forms.DialogResult.OK)
            {
            MessageBox.Show("Você clicou em OK!", "RESULTADO");
            }
            else
            {
            MessageBox.Show("Você clicou em CANCELAR!", "RESULTADO");
            }
        }

        private void btnDesvCondEnc_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDoClique = MessageBox.Show("Clique em SIM, NÃO ou CANCELAR!", "DESVIO CONDICIONAL ENCADEADO", MessageBoxButtons.YesNoCancel);

            if (resultadoDoClique == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Você clicou em SIM!", "RESULTADO");            
            }
            else if (resultadoDoClique == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("Você clicou em NÃO!", "RESULTADO");
            }
            else
            {
                MessageBox.Show("Você clicou em CANCELAR!", "RESULTADO");            
            }

        }

        private void btnSwitchCase_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Clique em SIM, NÃO ou CANCELAR!", "SWITCH CASE", MessageBoxButtons.YesNoCancel))
            { 
                case System.Windows.Forms.DialogResult.Yes:
                    MessageBox.Show("Você clicou em SIM!", "RESULTADO");
                    break;

                case System.Windows.Forms.DialogResult.No:
                    MessageBox.Show("Você clicou em NÃO!", "RESULTADO");
                    break;

                case System.Windows.Forms.DialogResult.Cancel:
                    MessageBox.Show("Você clicou em CANCELAR!", "RESULTADO");
                    break;

                default:
                    MessageBox.Show("ESCOLHA INVALIDA!\n ESCOLHA SIM, NÃO OU CANCELAR", "ESCOLHA INVALIDA");
                    break;
            }
        }

        private void btnImpTxtWhile_Click(object sender, EventArgs e)
        {
            ImpTxtWhile();
        }
        public void ImpTxtWhile()
        {
            objLeitorTxt = new StreamReader(@"D:\Learning TI\CURSO_AB\preferencia.txt");
            strLinhaLida = objLeitorTxt.ReadLine();

            while (strLinhaLida != null)
            {
                lstbxPreferencias.Items.Add(strLinhaLida);
                strLinhaLida = objLeitorTxt.ReadLine();
            }

            objLeitorTxt.Close();

        }

        private void btnImpTxtDoWhile_Click(object sender, EventArgs e)
        {
            ImpTxtDoWhile();
        }
        public void ImpTxtDoWhile()
        {
            objLeitorTxt = new StreamReader(@"D:\Learning TI\CURSO_AB\preferencia.txt");
            strLinhaLida = objLeitorTxt.ReadLine();

            do
            {
                lstbxPreferencias.Items.Add(strLinhaLida);
                strLinhaLida = objLeitorTxt.ReadLine();
            } while (strLinhaLida != null);

            objLeitorTxt.Close();
        }

        private void btnImpTxtFor_Click(object sender, EventArgs e)
        {
            ImpTxtFor();
        }
        public void ImpTxtFor()
        {
            objLeitorTxt = new StreamReader(@"D:\Learning TI\CURSO_AB\preferencia.txt");

            for (strLinhaLida = objLeitorTxt.ReadLine();strLinhaLida != null;strLinhaLida = objLeitorTxt.ReadLine())
            {
                lstbxPreferencias.Items.Add(strLinhaLida);
            }

            objLeitorTxt.Close();
        }

        private void btnImpTxtForeach_Click(object sender, EventArgs e)
        {
            ImpTxtForeach();
        }
        public void ImpTxtForeach()
        {
            objLeitorTxt = new StreamReader(@"D:\Learning TI\CURSO_AB\preferencia.txt");
            string[] arquivoCompleto = objLeitorTxt.ReadToEnd().Split('\n');

            objLeitorTxt.Close();

            foreach (string linhaLida in arquivoCompleto)
            {
                lstbxPreferencias.Items.Add(linhaLida);
            }

            objLeitorTxt.Close();
        }

        private void btnImpBdCon_Click(object sender, EventArgs e)
        {
            ImpBdCon();
        }
        public void ImpBdCon()
        { 
        objConexao = new OleDbConnection (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\Learning TI\CURSO_AB\preferencias_2_190420221.mdb'");

        objConexao.Open();

        objComando = new OleDbCommand();

        objComando.Connection = objConexao;

        objComando.CommandText = "SELECT Descricao FROM Preferencias_3";

        objLeitorBD = objComando.ExecuteReader();

        while (objLeitorBD.Read())
        {
            lstbxPreferencias.Items.Add(objLeitorBD["Descricao"].ToString());
        }

        objLeitorBD.Close();

        objConexao.Close();

        }

        private void btnImpBdDesc_Click(object sender, EventArgs e)
        {
            ImpBdDesc();
        }
        public void ImpBdDesc()
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\Learning TI\CURSO_AB\preferencias_2_190420221.mdb'");

            objComando = new OleDbCommand();

            objComando.Connection = objConexao;

            objComando.CommandText = "SELECT Descricao FROM Preferencias_3";

            objAdaptador = new OleDbDataAdapter();

            objAdaptador.SelectCommand = objComando;

            objTabela = new DataTable();

            objAdaptador.Fill(objTabela);

            foreach (DataRow objLinhaDaTabela in objTabela.Rows)
            {
                lstbxPreferencias.Items.Add(objLinhaDaTabela["Descricao"].ToString());                
            }
        }

    }
}
