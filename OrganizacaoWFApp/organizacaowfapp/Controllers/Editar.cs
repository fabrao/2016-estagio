using OrganizacaoWFApp.Entidades;
using OrganizacaoWFApp.DataBase;
using System.Windows.Forms;

namespace OrganizacaoWFApp.Controllers {
    public class Editar {
        public void EntityEdit(int index, Colaborador newObjt) {
            try {
                //ColaboradorRepositorio cr = new ColaboradorRepositorio();
                //string stg = cr.Editar(newObjt);
                DBOrganizacaoSys.lstColaboradores.RemoveAt(index);
                DBOrganizacaoSys.lstColaboradores.Insert(index, newObjt);
                MessageBox.Show("Alteração realizada com exito", "Sucesso", MessageBoxButtons.OK);
            } catch {
                MessageBox.Show("Ocorreu um erro ao realizar as alterações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EntityEdit(int index, Area newObjt) {
            try {
                DBOrganizacaoSys.lstAreas.RemoveAt(index);
                DBOrganizacaoSys.lstAreas.Insert(index, newObjt);
                MessageBox.Show("Alteração realizada com exito", "Sucesso", MessageBoxButtons.OK);
            } catch {
                MessageBox.Show("Ocorreu um erro ao realizar as alterações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EntityEdit(int index, TipoProjeto newObjt) {
            try {
                DBOrganizacaoSys.lstTipoProjeto.RemoveAt(index);
                DBOrganizacaoSys.lstTipoProjeto.Insert(index, newObjt);
                MessageBox.Show("Alteração realizada com exito", "Sucesso", MessageBoxButtons.OK);
            } catch {
                MessageBox.Show("Ocorreu um erro ao realizar as alterações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EntityEdit(int index, Projeto newObjt) {
            try {
                DBOrganizacaoSys.lstProjetos.RemoveAt(index);
                DBOrganizacaoSys.lstProjetos.Insert(index, newObjt);
                MessageBox.Show("Alteração realizada com exito", "Sucesso", MessageBoxButtons.OK);
            } catch {
                MessageBox.Show("Ocorreu um erro ao realizar as alterações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}