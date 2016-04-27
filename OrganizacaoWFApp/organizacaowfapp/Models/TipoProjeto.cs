using System;

namespace OrganizacaoWFApp.Entidades {
    public class TipoProjeto {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public TipoProjeto(int id, string nome, string descricao) {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}