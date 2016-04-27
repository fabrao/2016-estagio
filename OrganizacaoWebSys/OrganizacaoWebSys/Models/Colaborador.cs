using System;
using System.ComponentModel.DataAnnotations;

namespace OrganizacaoWebSys.Models {
    public class Colaborador {
        public int ID { get; set; }

        [Required(ErrorMessage = "*Nome deve ser preenchido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "*Nome deve ter entre 5 a 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "*Data de Contratação deve ser informada")]
        public DateTime DataContratacao { get; set; }

        public DateTime? DataDemissao { get; set; }

        [Required(ErrorMessage = "*Data de Nascimento deve ser informada")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "*Sexo deve ser informado")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "*Carga Horária deve ser informada")]
        [Range(1, 44, ErrorMessage = "*Caga Horária deve estar entre 1 a 44 horas semanais")]
        public int CargaHoraria { get; set; }
    }
}