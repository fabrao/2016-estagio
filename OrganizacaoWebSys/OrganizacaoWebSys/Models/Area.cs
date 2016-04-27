using System.ComponentModel.DataAnnotations;

namespace OrganizacaoWebSys.Models {
    public class Area {
        public int ID { get; set; }

        [Required(ErrorMessage = "*Nome deve ser preeenchido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "*Nome deve ter entre 3 a 30 caracteres")]
        public string Nome { get; set; }

    }
}