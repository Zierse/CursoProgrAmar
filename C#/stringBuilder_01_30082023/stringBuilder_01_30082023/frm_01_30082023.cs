using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PreferenciasBusiness;

namespace stringBuilder_01_30082023
{
    public partial class frm_01_30082023 : Form
    {
        Preferenciasb objPreferencias;

        string strDescricaoAntiga;

        bool bolIncluir = false;

        public frm_01_30082023()
        {
            InitializeComponent();
        }

        private void btnDesvCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Escolha OK ou CANCELAR!", "AVISO", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Você escolheu OK!", "AVISO");
            }
            else
            {
                MessageBox.Show("Você escolheu CANCELAR!", "AVISO");
            }
        }

        private void btnImpTxtWhile_Click(object sender, EventArgs e)
        {
            try
            {
                lstbxPreferencias.Items.Clear();

                objPreferencias = new Preferenciasb();

                lstbxPreferencias.Items.AddRange(objPreferencias.ImpTxtWhile().ToArray());
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBdCon_Click(object sender, EventArgs e)
        {
            try
            {
                lstbxPreferencias.Items.Clear();

                objPreferencias = new Preferenciasb();

                lstbxPreferencias.Items.AddRange(objPreferencias.BdCon().ToArray());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBdDesc_Click(object sender, EventArgs e)
        {
            try
            {
                lstbxPreferencias.Items.Clear();

                objPreferencias = new Preferenciasb();

                lstbxPreferencias.Items.AddRange(objPreferencias.BdDesc().ToArray());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultarBd_Click(object sender, EventArgs e)
        {
            ConsultarBd();
        }
        public void ConsultarBd(string strparConsultarPref = null)
        {
            try
            {
                objPreferencias = new Preferenciasb();

                bndsrcPreferencias.DataSource = objPreferencias.ConsultarBd(strparConsultarPref);

                dtgdvwPreferencias.DataSource = bndsrcPreferencias;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIncluirBd_Click(object sender, EventArgs e)
        {
            IncluirBd(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
            ConsultarBd();

        }
        public void IncluirBd(string strparIncluirPref)
        {
            try
            {
                objPreferencias = new Preferenciasb();

                if (objPreferencias.IncluirBd(strparIncluirPref))
                {
                    MessageBox.Show("Inclusão Realizada!","AVISO");
                }
                else
                {
                    MessageBox.Show("Inclusão Falhou!","AVISO");

                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluirBd_Click(object sender, EventArgs e)
        {
            ExcluirBd(strDescricaoAntiga);
            ConsultarBd();

        }
        public void ExcluirBd(string strparExcluirPref)
        {
            try
            {
                objPreferencias = new Preferenciasb();

                if (objPreferencias.ExcluirBd(strparExcluirPref))
                {
                    MessageBox.Show("Exclusão Realizada!", "AVISO");
                }
                else
                {
                    MessageBox.Show("Exclusão Falhou!", "AVISO");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAlterarBd_Click(object sender, EventArgs e)
        {
            AlterarBd(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString(), strDescricaoAntiga);
            ConsultarBd();

        }
        public void AlterarBd(string strparPrefNova, string strparPrefAntiga)
        {
            try
            {
                objPreferencias = new Preferenciasb();

                if (objPreferencias.AlterarBd(strparPrefNova, strparPrefAntiga))
                {
                    MessageBox.Show("Alteração Realizada!", "AVISO");
                }
                else
                {
                    MessageBox.Show("Alteração Falhou!", "AVISO");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frm_01_30082023_Load(object sender, EventArgs e)
        {
            ConsultarBd();
        }

        private void dtgdvwPreferencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strDescricaoAntiga = dtgdvwPreferencias.CurrentCell.Value.ToString();
        }

        private void bndnavbtnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarBd(bndnavtxtPesquisar.Text);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir " + strDescricaoAntiga + " ? ", "AVISO", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ExcluirBd(strDescricaoAntiga);
            }
            ConsultarBd();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bolIncluir = true;
        }

        private void bndnavbtnConfirmar_Click(object sender, EventArgs e)
        {
            if (bolIncluir)
            {
                if (MessageBox.Show("Deseja Incluir " + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + " ? ", "AVISO", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    IncluirBd(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
                }
                bolIncluir = false;
            }
            else if (MessageBox.Show("Deseja Alterar " + strDescricaoAntiga + " para " + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + " ? ", "AVISO", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                AlterarBd(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString(), strDescricaoAntiga);
            }
            ConsultarBd();
        }
    }
}
