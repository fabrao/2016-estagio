using System;
using System.ComponentModel.DataAnnotations;

namespace OrganizacaoWebSys.Models {
    public class Projeto {
        public int ID { get; set; }

        [Required(ErrorMessage = "*O campo Nome deve ser preenchido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 3 a 30 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "*Data de início do projeto deve ser informada")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "*Data de término do projeto deve ser informada")]
        public DateTime DataTerino { get; set; }

        [Required(ErrorMessage = "*Um responsável deve ser selecionado")]
        public string Responsavel { get; set; }

        [Required(ErrorMessage = "*Uma area deve ser selecionada")]
        public string Area { get; set; }

        public string TipoProjeto { get; set; }

        [Required(ErrorMessage = "*O tempo de trabalho deve ser informado")]
        [Range(1, 3000, ErrorMessage = "*O intervalo de deve ser entre 1 a 3000 horas")]
        public int TempoEstimado { get; set; }
    }
}