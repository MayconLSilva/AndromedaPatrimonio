using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppCustomerControl.Models
{
    public class Setor
    {
        [DisplayName("Código setor")]
        public int id { get; set; }

        [DisplayName("Nome do setor")]
        [Required(ErrorMessage = "Informe o nome do banco")]
        [StringLength(20)]
        public string descricao { get; set; }
    }
}
