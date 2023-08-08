using System.ComponentModel;

namespace AppCustomerControl.Models
{
    public class Setor
    {
        [DisplayName("Código setor")]
        public int id { get; set; }

        [DisplayName("Nome do setor")]
        public string descricao { get; set; }
    }
}
