using OrganizacaoWFApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace OrganizacaoWFApp.DataBase {
    public class ColaboradorRepositorio : Contexto, IRepositorio<Colaborador> {
        public Colaborador BuscarID(int id) {
            throw new NotImplementedException();
        }

        public string Deletar(Colaborador entidade) {
            try {
                LimparParametro();
                AdicionarParametros("@ID", entidade.Id);
                string retorno = ExecutarComando(CommandType.StoredProcedure, "usbRemoverColaborador").ToString();
                return retorno;
            } catch (Exception ex) {
                return ex.Message;
            }
        }

        public string Editar(Colaborador entidade) {
            try {
                LimparParametro();
                AdicionarParametros("colaborador_id", entidade.Id);
                AdicionarParametros("colaborador_nome", entidade.Nome);
                AdicionarParametros("colaborador_dataNascimento", entidade.DataNascimento);
                AdicionarParametros("colaborador_dataAdmissao", entidade.DataEntrada);
                AdicionarParametros("colaborador_dataDemissao", entidade.DataSaida);
                AdicionarParametros("colaborador_sexo", entidade.Sexo);
                AdicionarParametros("colaborador_cargaHoraria", entidade.CargaHoraria);
                string retorno = ExecutarComando(CommandType.StoredProcedure, "usbEditarColaborador").ToString();
                return retorno;
            } catch (Exception ex) {
                return ex.Message;
            }
        }

        public string Inserir(Colaborador entidade) {
            try {
                LimparParametro();
                AdicionarParametros("@nome", entidade.Nome);
                AdicionarParametros("@dataNascimento", entidade.DataNascimento);
                AdicionarParametros("@dataContratacao", entidade.DataEntrada);
              //  if (!entidade.DataSaida.Value.ToString().Contains("/"))
              //      AdicionarParametros("@dataDemissao", entidade.DataSaida);
                //else
                AdicionarParametros("@dataDemissao", entidade.DataSaida);

                AdicionarParametros("@sexo", entidade.Sexo);
                AdicionarParametros("@cargaHoraria", entidade.CargaHoraria);
                string returno = ExecutarComando(CommandType.StoredProcedure, "usbInserirColaborador").ToString();
                return returno;
            } catch (Exception ex) {
                return ex.Message;
            }
        }

        public IEnumerable<Colaborador> ListarTodos() {
            try {
                DataTable dtColaborador = new DataTable();
                dtColaborador = ExecutarConsulta(CommandType.StoredProcedure, "usbListarTodosColaboradores");
                IList<Colaborador> colaboradores = new List<Colaborador>();
                foreach (DataRow linha in dtColaborador.Rows) {
                    Colaborador colab = new Colaborador();
                    colab.Id = Convert.ToInt32(linha["IDC"]);
                    colab.Nome = linha["NOME"].ToString();
                    colab.DataNascimento = Convert.ToDateTime(linha["DATANASCIMENTO"]);
                    colab.DataEntrada = Convert.ToDateTime(linha["DATACONTRATACAO"]);
                    try {
                        colab.DataSaida = Convert.ToDateTime(linha["DATADEMISSAO"]);
                    } catch {
                        colab.DataSaida = null;
                    }
                    colab.Sexo = linha["SEXO"].ToString();
                    colab.CargaHoraria = Convert.ToInt32(linha["CARGAHORARIA"]);
                    colaboradores.Add(colab);
                }
                return colaboradores;
            }catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }
    }
}