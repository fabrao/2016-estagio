using OrganizacaoWFApp.Controllers;
using OrganizacaoWFApp.DataBase;
using System;
using System.Windows.Forms;

namespace OrganizacaoWFApp.FormViews {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
            Usuario user = new Usuario("admin", "admin");
            DBOrganizacaoSys.lstUsuarios.Add(user);
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            VerificarLogin login = new VerificarLogin();
            lblErro.Text = "";
            if (login.VerificaUser(txtUsuario.Text, txtSenha.Text)) {
                DialogResult = DialogResult.Yes;
                Close();
            } else {
                lblErro.Text = "Usuário ou/e senha inválido(s)";
            }
        }
        private void btnSair_Click(object sender, EventArgs e) {
            Close();
        }
    }
}