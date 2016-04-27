using System;

namespace OrganizacaoWFApp.Entidades {
    public class Area {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Area(int id, string nome) {
            Id = id;
            Nome = nome;
        }
    }
}