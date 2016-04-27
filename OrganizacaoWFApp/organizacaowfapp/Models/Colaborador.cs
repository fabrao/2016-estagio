using System;

namespace OrganizacaoWFApp.Entidades {
    public class Colaborador {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public string Sexo { get; set; }
        public int CargaHoraria { get; set; }

        public Colaborador(int id, string nome, DateTime dataNascimento, DateTime dataEntrada, DateTime? dataSaida, string sexo, int cargaHoraria) {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
            Sexo = sexo;
            CargaHoraria = cargaHoraria;
        }

        public Colaborador() {
        }
    }
}