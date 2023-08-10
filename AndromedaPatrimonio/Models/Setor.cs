using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AndromedaPatrimonio.Models
{
    public class Setor
    {
        [DisplayName("Código setor")]
        public int? id { get; set; }

        [DisplayName("Nome do setor")]
        [Required(ErrorMessage = "Informe a descrição")]
        [StringLength(20)]
        public string descricao { get; set; }

        [DisplayName("Data do cadastro")]
        [Required(ErrorMessage = "Informe a data do cadastro")]
        public DateTime data_cadastro { get; set; }
    }
}
