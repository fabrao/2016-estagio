using System;

namespace OrganizacaoWFApp.Entidades {
    public class Projeto {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataConclusao { get; set; }
        public string Responsavel { get; set; }
        public string Area { get; set; }
        public string TipoProjeto { get; set; }
        public int TrabalhoEstimado { get; set; }

        public Projeto(int id, string nome, DateTime dataInicio, DateTime dataConclusao, string responsavel, string area, string tipoProjeto, int trabEstimado) {
            Id = id;
            Nome = nome;
            DataInicio = dataInicio;
            DataConclusao = dataConclusao;
            Responsavel = responsavel;
            Area = area;
            TipoProjeto = tipoProjeto;
            TrabalhoEstimado = trabEstimado;
        }
    }
}