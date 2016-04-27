using OrganizacaoWFApp.Controllers;
using OrganizacaoWFApp.Entidades;
using System;
using System.Windows.Forms;

namespace OrganizacaoWFApp.FormViews {
    public partial class FrmProjeto : Form {
        GerenciarCampos grCampos = new GerenciarCampos();
        private bool modoEdicao = false;
        private Projeto editProjeto;
        private int index;
        public FrmProjeto() {
            InitializeComponent();
            grCampos.AlterarFormatoDateTimePicker(dtpProjInicio, dtpProjConclusao);
            cboProjResponsavel.DataSource = Consultar.LstNomesColaboradores(DateTime.Now);
            cboProjArea.DataSource = Consultar.LstNomesAreas();
            cboProjTipo.DataSource = Consultar.LstNomesTiposProjetos();
            dtpProjInicio.Value = DateTime.Now;
            dtpProjConclusao.Value = DateTime.Now;

            cboProjResponsavel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProjArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProjTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public FrmProjeto(Projeto entidade) {
            InitializeComponent();
            grCampos.AlterarFormatoDateTimePicker(dtpProjInicio, dtpProjConclusao);
            cboProjResponsavel.DataSource = Consultar.LstNomesColaboradores(entidade.DataConclusao);
            cboProjArea.DataSource = Consultar.LstNomesAreas();
            cboProjTipo.DataSource = Consultar.LstNomesTiposProjetos();
            lblPrincipal.Text = " Editar: Projeto";
            editProjeto = entidade;
            modoEdicao = true;
            Consultar consulta = new Consultar();
            index = consulta.IndexOfEntity(entidade);

            txtProjNome.Text = entidade.Nome;
            dtpProjInicio.Value = entidade.DataInicio;
            dtpProjConclusao.Value = entidade.DataConclusao;
            cboProjResponsavel.SelectedText = entidade.Responsavel;
            cboProjArea.SelectedText = entidade.Area;
            nudProjTempo.Value = Convert.ToDecimal(entidade.TrabalhoEstimado);
            if (entidade.TipoProjeto.Equals(""))
                chkTipo.Checked = true;
            else {
                chkTipo.Checked = false;
                cboProjTipo.SelectedText = entidade.TipoProjeto;
            }
            cboProjResponsavel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProjArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProjTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #region EVENTOS
        private void btnSalvar_Click(object sender, EventArgs e) {
            bool verificacaoNome = grCampos.ExistemCamposVazios(txtProjNome, errorNome);
            bool vericacaoDatas = grCampos.VerficaData1MenorIgualData2(dtpProjInicio, "Data de início", dtpProjConclusao, "Data de conclusão", errorDataInicio, errorDataConclusao);
            bool verificaCboVazias = grCampos.ComboBoxIsEmpty(cboProjResponsavel, errorResponsavel) || grCampos.ComboBoxIsEmpty(cboProjArea, errorArea);
            if (!verificacaoNome && vericacaoDatas && !verificaCboVazias) {
                string stgProjTipo = "";
                try {
                    stgProjTipo = cboProjTipo.SelectedItem.ToString();
                } catch { }
                if (chkTipo.Checked)
                    stgProjTipo = "";
                if (!modoEdicao) {
                    Cadastrar.NovoProjeto(txtProjNome.Text, dtpProjInicio, dtpProjConclusao, cboProjResponsavel.SelectedItem.ToString(), cboProjArea.SelectedItem.ToString(), stgProjTipo, Convert.ToInt32(nudProjTempo.Value));
                    ResetaCampos();
                } else {
                    editProjeto = new Projeto(editProjeto.Id, txtProjNome.Text, dtpProjInicio.Value, dtpProjConclusao.Value, cboProjResponsavel.SelectedItem.ToString(), cboProjArea.SelectedItem.ToString(), stgProjTipo, Convert.ToInt32(nudProjTempo.Value));
                    Editar edt = new Editar();
                    edt.EntityEdit(index, editProjeto);
                }
            }else
                MessageBox.Show("Todos os campos * são obrigatórios. Para mais informações, verifique as notificações", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnSair_Click(object sender, EventArgs e) {
            if (grCampos.ConfirmaSair())
                Close();
        }
        private void chkTipo_CheckStateChanged(object sender, EventArgs e) {
            if (chkTipo.Checked) {
                cboProjTipo.Enabled = false;
            } else {
                cboProjTipo.Enabled = true;
            }
        }
        private void dtpProjConclusao_Leave(object sender, EventArgs e) {
            cboProjResponsavel.ResetText();
            cboProjResponsavel.DataSource = Consultar.LstNomesColaboradores(dtpProjConclusao.Value);
        }
        #endregion

        private void ResetaCampos() {
            txtProjNome.Text = "";
            dtpProjInicio.Value = DateTime.Now;
            dtpProjConclusao.Value = DateTime.Now;
            cboProjResponsavel.SelectedIndex = 0;
            cboProjArea.SelectedIndex = 0;
            try {
                cboProjTipo.SelectedIndex = 0;
            } catch { }
            nudProjTempo.Value = 1;
        }
    }
}