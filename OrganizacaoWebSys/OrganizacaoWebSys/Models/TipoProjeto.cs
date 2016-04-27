using System.ComponentModel.DataAnnotations;

namespace OrganizacaoWebSys.Models {
    public class TipoProjeto {
        public int ID { get; set; }

        [Required(ErrorMessage = "*Nome deve ser preenchido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 3 a 30 caracteres")]

        public string Nome { get; set; }
        [StringLength(250, MinimumLength = 5, ErrorMessage = "*Descrição deve ter entre 5 a 250 caracteres")]
        public string Descricao { get; set; }
    }
}