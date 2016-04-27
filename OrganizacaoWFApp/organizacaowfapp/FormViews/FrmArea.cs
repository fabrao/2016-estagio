using OrganizacaoWFApp.Controllers;
using OrganizacaoWFApp.Entidades;
using System;
using System.Windows.Forms;

namespace OrganizacaoWFApp.FormViews {
    public partial class FrmArea : Form {
        private bool modoEdicao = false;
        private Area editArea;
        private int index;
        public FrmArea() {
            InitializeComponent();
        }
        public FrmArea(Area entidade) {
            InitializeComponent();
            editArea = entidade;
            modoEdicao = true;
            lblPrincipal.Text = " Alterar: Área";
            Consultar consulta = new Consultar();
            index = consulta.IndexOfEntity(entidade);
            txtAreaNome.Text = entidade.Nome;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            GerenciarCampos grCampos = new GerenciarCampos();
            
            if (!grCampos.ExistemCamposVazios(txtAreaNome, errorProvider1)) {
                if (!modoEdicao) {
                    Cadastrar.NovaArea(txtAreaNome.Text);
                    txtAreaNome.Text = "";
                } else {
                    editArea = new Area(editArea.Id, txtAreaNome.Text);
                    Editar edt = new Editar();
                    edt.EntityEdit(index, editArea);
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