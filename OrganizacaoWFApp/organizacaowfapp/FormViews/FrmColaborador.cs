using OrganizacaoWFApp.Controllers;
using OrganizacaoWFApp.Entidades;
using System;
using System.Windows.Forms;

namespace OrganizacaoWFApp.FormViews {
    public partial class FrmColaborador : Form {
        GerenciarCampos grCampos = new GerenciarCampos();
        private bool modoEdicao = false;
        private Colaborador editColaborador;
        private int index;
        public FrmColaborador() {
            InitializeComponent();
            ResetaCampos();
            grCampos.AlterarFormatoDateTimePicker(dtpColabNasc, dtpColabEntrada, dtpColabSaida);
            cboColabSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public FrmColaborador(Colaborador entidade) {
            InitializeComponent();
            grCampos.AlterarFormatoDateTimePicker(dtpColabNasc, dtpColabEntrada, dtpColabSaida);
            editColaborador = entidade;
            modoEdicao = true;
            lblPrincipal.Text = " Editar: Colaborador";
            Consultar consulta = new Consultar();
            index = consulta.IndexOfEntity(entidade);

            txtColabNome.Text = entidade.Nome;
            dtpColabNasc.Value = entidade.DataNascimento;
            dtpColabEntrada.Value = entidade.DataEntrada;
        
            cboColabSexo.Text = entidade.Sexo;
            nudColabCargaHoraria.Value = Convert.ToDecimal(entidade.CargaHoraria);
            if (entidade.DataSaida == null)
                chkAtivo.Checked = true;
            else {
                chkAtivo.Checked = false;
                dtpColabSaida.Value = (DateTime)entidade.DataSaida;
            }
            cboColabSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #region EVENTOS
        private void btnSalvar_Click(object sender, EventArgs e) {
            DateTime? dtSaida = dtpColabSaida.Value;
            bool verificaNome = grCampos.ExistemCamposVazios(txtColabNome, errorNome);
            bool verificaDatas1 = grCampos.VerficaData1MenorIgualData2(dtpColabNasc, "Data de Nascimento", dtpColabEntrada, "Data de Entrada", errorDataNascimento, errorDataEntrada);
            bool verificaDatas2 = true;
            if (!chkAtivo.Checked)
                verificaDatas2 = grCampos.VerficaData1MenorIgualData2(dtpColabEntrada, "Data de Entrada", dtpColabSaida, "Data de Saída", errorDataEntrada, errorDataSaida);
            else
                errorDataSaida.Clear();
            if (!verificaNome && verificaDatas1 && verificaDatas2) {
                if (chkAtivo.Checked)
                    dtSaida = null;
                if (!modoEdicao) {
                    Cadastrar.NovoColaborador(txtColabNome.Text, dtpColabNasc, dtpColabEntrada, dtSaida, cboColabSexo.SelectedItem.ToString(), Convert.ToInt32(nudColabCargaHoraria.Value));
                    ResetaCampos();
                } else {
                    editColaborador = new Colaborador(editColaborador.Id, txtColabNome.Text, dtpColabNasc.Value, dtpColabEntrada.Value, dtSaida, cboColabSexo.SelectedItem.ToString(), Convert.ToInt32(nudColabCargaHoraria.Value));
                    Editar edt = new Editar();
                    edt.EntityEdit(index, editColaborador);
                }
            }else
                MessageBox.Show("Todos os campos * são obrigatórios. Para mais informações verifique as notificações", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnSair_Click(object sender, EventArgs e) {
            if (grCampos.ConfirmaSair())
                Close();
        }
        private void chkAtivo_CheckStateChanged(object sender, EventArgs e) {
            if (chkAtivo.Checked) {
                dtpColabSaida.Enabled = false;
            } else
                dtpColabSaida.Enabled = true;
        }
        #endregion

        private void ResetaCampos() {
            txtColabNome.Text = "";
            dtpColabNasc.Value = DateTime.Now;
            dtpColabEntrada.Value = DateTime.Now;
            dtpColabSaida.Value = DateTime.Now;
            cboColabSexo.SelectedIndex = 0;
            nudColabCargaHoraria.Value = 1;
        }

    }
}