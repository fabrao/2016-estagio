using OrganizacaoWFApp.Entidades;
using OrganizacaoWFApp.DataBase;
using System.Windows.Forms;

namespace OrganizacaoWFApp.Controllers {
    public class Remover {
        public void RemoverLinhaGrid(DataGridView grd, string entidade) {
            if (grd.CurrentRow != null) {
                DialogResult result = MessageBox.Show("Deseja apagar ''" + grd.CurrentRow.Cells["Nome"].Value + "''", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes) {
                    switch (entidade) {
                        case "colaborador":
                            bool contemResponsavelVinculado = DBOrganizacaoSys.lstProjetos.Exists(Projeto => Projeto.Responsavel.Equals(grd.CurrentRow.Cells["Nome"].Value));
                            if (!contemResponsavelVinculado) {
                                Colaborador colab = (Colaborador)grd.CurrentRow.DataBoundItem;
                                grd.Rows.Remove(grd.CurrentRow);
                                //ColaboradorRepositorio cr = new ColaboradorRepositorio();
                                //string stg = cr.Deletar(colab);
                                MessageBox.Show("''" + colab.Nome + "'' removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else
                                MessageBox.Show("''" + grd.CurrentRow.Cells["Nome"].Value + "''" + "está vinculado a um ou mais projetos", "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case "area":
                            bool contemAreaVinculada = DBOrganizacaoSys.lstProjetos.Exists(Projeto => Projeto.Area.Equals(grd.CurrentRow.Cells["Nome"].Value));
                            if (!contemAreaVinculada) {
                                Area area = (Area)grd.CurrentRow.DataBoundItem;
                                grd.Rows.Remove(grd.CurrentRow);
                                DBOrganizacaoSys.lstAreas.Remove(area);
                                MessageBox.Show("''" + area.Nome + "'' removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else
                                MessageBox.Show("''" + grd.CurrentRow.Cells["Nome"].Value + "''" + "está vinculado a um ou mais projetos", "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case "tipoProjeto":
                            bool contemTipoProjetoVinculado = DBOrganizacaoSys.lstProjetos.Exists(Projeto => Projeto.TipoProjeto.Equals(grd.CurrentRow.Cells["Nome"].Value));
                            if (!contemTipoProjetoVinculado) {
                                TipoProjeto tipoProjeto = (TipoProjeto)grd.CurrentRow.DataBoundItem;
                                grd.Rows.Remove(grd.CurrentRow);
                                DBOrganizacaoSys.lstTipoProjeto.Remove(tipoProjeto);
                                MessageBox.Show("''" + tipoProjeto.Nome + "'' removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else
                                MessageBox.Show("''" + grd.CurrentRow.Cells["Nome"].Value + "''" + "está vinculado a um ou mais projetos", "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case "projeto":
                            Projeto projeto = (Projeto)grd.CurrentRow.DataBoundItem;
                            grd.Rows.Remove(grd.CurrentRow);
                            DBOrganizacaoSys.lstProjetos.Remove(projeto);
                            MessageBox.Show("''" + projeto.Nome + "'' removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
        }
    }
}