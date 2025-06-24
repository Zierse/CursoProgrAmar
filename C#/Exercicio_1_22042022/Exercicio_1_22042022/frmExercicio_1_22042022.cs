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

namespace Exercicio_1_22042022
{
    public partial class frmExercicio_1_22042022 : Form
    {
        StreamReader objLeitorTxt;
        string strLinhaLida;

        OleDbConnection objConexao;
        OleDbCommand objComando;
        OleDbDataReader objLeitorBd;

        public frmExercicio_1_22042022()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parabéns! Você exibiu uma Mensagem!", "AVISO");
        }

        private void btnDesvCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clique em OK ou Cancelar!", "DESVIO CONDICIONAL", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Você clicou em OK!", "RESULTADO");
            }
            else
            {
                MessageBox.Show("Você clicou em Cancelar!", "RESULTADO");            
            }
        }

        private void btnDesvCondEnc_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDoClique = (MessageBox.Show("Clique em Sim, Não ou Cancelar!", "DESVIO CONDICIONAL ENCADEADO", MessageBoxButtons.YesNoCancel));

            if (resultadoDoClique == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Você clicou em Sim!", "RESULTADO");           
            }
            else if (resultadoDoClique == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("Você clicou em Não!", "RESULTADO");
            }
            else
            {
                MessageBox.Show("Você clicou em Cancelar!", "RESULTADO");
            }
        }

        private void btnSwitchCase_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Clique em Sim, Não ou Cancelar!", "ESTRUTURA SWITCH CASE", MessageBoxButtons.YesNoCancel))
            {
                case System.Windows.Forms.DialogResult.Yes:
                MessageBox.Show("Você clicou em Sim!", "RESULTADO");           
                    break;

                    case System.Windows.Forms.DialogResult.No:
                MessageBox.Show("Você clicou em Não!", "RESULTADO");           
                    break;

                    case System.Windows.Forms.DialogResult.Cancel:
                MessageBox.Show("Você clicou em Cancelar!", "RESULTADO");           
                    break;

                default:
                     MessageBox.Show("ESCOLHA INVALIDA!\nESCOLHA SIM, NÃO OU CANCELAR!", "ESCOLHA INVALIDA");
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
            }
            while (strLinhaLida != null);

            objLeitorTxt.Close();

        }

        private void btnImpTxtFor_Click(object sender, EventArgs e)
        {
            ImpTxtFor();
        }
        public void ImpTxtFor()
        {
            objLeitorTxt = new StreamReader(@"D:\Learning TI\CURSO_AB\preferencia.txt");

            for (strLinhaLida = objLeitorTxt.ReadLine(); strLinhaLida != null; strLinhaLida = objLeitorTxt.ReadLine())
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
            foreach (string LinhaLida in arquivoCompleto)
            {
                lstbxPreferencias.Items.Add(LinhaLida);
            }

        }

        private void btnImpBdConectado_Click(object sender, EventArgs e)
        {
            ImpBdConectado();
        }
        public void ImpBdConectado()
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\Learning TI\CURSO_AB\preferencias_2_190420221.mdb'");

            objConexao.Open();

            objComando = new OleDbCommand();

            objComando.Connection = objConexao;

            objComando.CommandText = "SELECT Descricao FROM Preferencias_3";

            objLeitorBd = objComando.ExecuteReader();

            while (objLeitorBd.Read())
            {
                lstbxPreferencias.Items.Add(objLeitorBd["Descricao"].ToString());
            }

            objLeitorBd.Close();

            objConexao.Close();
        }
    }
}
