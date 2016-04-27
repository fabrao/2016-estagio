using OrganizacaoWFApp.Controllers;
using System;
using System.Windows.Forms;

namespace OrganizacaoWFApp.FormViews {
    public partial class FrmPrincipal : Form {
        public FrmPrincipal() {
            bool result = false;
            using (FrmLogin frmLogin = new FrmLogin()) {
                if (frmLogin.ShowDialog() == DialogResult.Yes)
                    result = true;
            }
            if (result)
                InitializeComponent();
            else
              Shown += new EventHandler(exitToolStripMenuItem_Click);
        }

        #region EVENTOS
        private void mnuCadColaborador_Click(object sender, EventArgs e) {
            FrmColaborador frmCadColaborador = new FrmColaborador();
            frmCadColaborador.MdiParent = this;
            frmCadColaborador.Show();
        }
        private void mnuCadArea_Click(object sender, EventArgs e) {
            FrmArea frmCadArea = new FrmArea();
            frmCadArea.MdiParent = this;
            frmCadArea.Show();
        }
        private void mnuCadTipoProj_Click(object sender, EventArgs e) {
            FrmTipoProjeto frmCadTipoProjeto = new FrmTipoProjeto();
            frmCadTipoProjeto.MdiParent = this;
            frmCadTipoProjeto.Show();
        }
        private void mnuCadProj_Click(object sender, EventArgs e) {
            FrmProjeto frmCadProjeto = new FrmProjeto();
            frmCadProjeto.MdiParent = this;
            frmCadProjeto.Show();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            GerenciarCampos grCampos = new GerenciarCampos();
            if (grCampos.ConfirmaSair())
                Close();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }
        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmConsultar frmGerenciar = new FrmConsultar(0);
            frmGerenciar.MdiParent = this;
            frmGerenciar.Show();
        }
        private void areaToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmConsultar frmGerenciar = new FrmConsultar(1);
            frmGerenciar.MdiParent = this;
            frmGerenciar.Show();
        }
        private void tipoDeProjetoToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmConsultar frmGerenciar = new FrmConsultar(2);
            frmGerenciar.MdiParent = this;
            frmGerenciar.Show();
        }
        private void projetoToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmConsultar frmGerenciar = new FrmConsultar(3);
            frmGerenciar.MdiParent = this;
            frmGerenciar.Show();
        }
        #endregion
    }
}