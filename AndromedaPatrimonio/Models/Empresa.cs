using System.ComponentModel;

namespace AndromedaPatrimonio.Models
{
    public class Empresa
    {
        [DisplayName("Código empresa")]
        public int id { get; set; }

        [DisplayName("Nome Fantasia")]
        public string nome_fantasia { get; set; }

        public Empresa(int ID, string NOMEFANTASIA) 
        {
            id = ID;
            nome_fantasia = NOMEFANTASIA;
        }
    }
}
