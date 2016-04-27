using OrganizacaoWFApp.Entidades;
using OrganizacaoWFApp.DataBase;
using System;
using System.Windows.Forms;

namespace OrganizacaoWFApp.Controllers {
    public class Cadastrar {
        public static void NovoColaborador(string nome, DateTimePicker dataNasc, DateTimePicker dataEntrada, DateTime? dataSaida, string sexo, int cargaHoraria) {
            DateTime dtNasc = new DateTime(dataNasc.Value.Year, dataNasc.Value.Month, dataNasc.Value.Day);
            DateTime dtEntr = new DateTime(dataEntrada.Value.Year, dataEntrada.Value.Month, dataEntrada.Value.Day);
            DateTime? dtSaid;
            try {
                dtSaid = new DateTime(dataSaida.Value.Year, dataSaida.Value.Month, dataSaida.Value.Day);
            } catch {
                dtSaid = null;
            }

            Colaborador colaborador = new Colaborador(DBOrganizacaoSys.contIdColaborador, nome, dtNasc, dtEntr, dtSaid, sexo, cargaHoraria);
            //ColaboradorRepositorio cr = new ColaboradorRepositorio();
            //string stg = cr.Inserir(colaborador);
            DBOrganizacaoSys.lstColaboradores.Add(colaborador);
            DBOrganizacaoSys.contIdColaborador++;
            MessageBox.Show("''" + colaborador.Nome + "'' cadastrado com sucesso", "Informação", MessageBoxButtons.OK);
        }
        public static void NovaArea(string nome) {
            Area area = new Area(DBOrganizacaoSys.contIdArea, nome);
            DBOrganizacaoSys.lstAreas.Add(area);
            DBOrganizacaoSys.contIdArea++;
            MessageBox.Show("''" + area.Nome + "'' cadastrada com sucesso", "Informação", MessageBoxButtons.OK);
        }
        public static void NovoTipoProjeto(string nome, string descricao) {
            TipoProjeto tipoProjeto = new TipoProjeto(DBOrganizacaoSys.contIdTipoProjeto, nome, descricao);
            DBOrganizacaoSys.lstTipoProjeto.Add(tipoProjeto);
            DBOrganizacaoSys.contIdTipoProjeto++;
            MessageBox.Show("''" + tipoProjeto.Nome + "'' cadastrado com sucesso", "Informação", MessageBoxButtons.OK);
        }
        public static void NovoProjeto(string nome, DateTimePicker dataInicio, DateTimePicker dataConclusao, string responsavel, string area, string tipoProjeto, int trabEstimado) {
            DateTime dtInic = new DateTime(dataInicio.Value.Year, dataInicio.Value.Month, dataInicio.Value.Day);
            DateTime dtConc = new DateTime(dataConclusao.Value.Year, dataConclusao.Value.Month, dataConclusao.Value.Day);

            Projeto projeto = new Projeto(DBOrganizacaoSys.contIdProjeto, nome, dtInic, dtConc, responsavel, area, tipoProjeto, trabEstimado);
            DBOrganizacaoSys.lstProjetos.Add(projeto);
            DBOrganizacaoSys.contIdProjeto++;
            MessageBox.Show("''" + projeto.Nome + "'' cadastrado com sucesso", "Informação", MessageBoxButtons.OK);
        }
    }
}