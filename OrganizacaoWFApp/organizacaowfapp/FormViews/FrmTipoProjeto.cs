using OrganizacaoWFApp.Controllers;
using OrganizacaoWFApp.Entidades;
using System;
using System.Windows.Forms;

namespace OrganizacaoWFApp.FormViews {
    public partial class FrmTipoProjeto : Form {
        private bool modoEdicao = false;
        private TipoProjeto editTipoProj;
        private int index;
        public FrmTipoProjeto() {
            InitializeComponent();
        }
        public FrmTipoProjeto(TipoProjeto entidade) {
            InitializeComponent();
            editTipoProj = entidade;
            modoEdicao = true;
            lblPrincipal.Text = " Alterar: Tipo de Projeto";
            Consultar consulta = new Consultar();
            index = consulta.IndexOfEntity(entidade);
            txtTProjNome.Text = entidade.Nome;
            txtTProjDescricao.Text = entidade.Descricao;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            GerenciarCampos grCampos = new GerenciarCampos();
            if (!grCampos.ExistemCamposVazios(txtTProjNome, errorProvider)) {
                if (!modoEdicao) {
                    Cadastrar.NovoTipoProjeto(txtTProjNome.Text, txtTProjDescricao.Text);
                    txtTProjNome.Text = "";
                    txtTProjDescricao.Text = "";
                } else {
                    editTipoProj = new TipoProjeto(editTipoProj.Id, txtTProjNome.Text, txtTProjDescricao.Text);
                    Editar edt = new Editar();
                    edt.EntityEdit(index, editTipoProj);
                }
            }else
                MessageBox.Show("Todos os campos * são obrigatórios. Para mais informações verifique as notificações", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void btnSair_Click(object sender, EventArgs e) {
            GerenciarCampos grCampos = new GerenciarCampos();
            if (grCampos.ConfirmaSair())
                Close();
        }
    }
}