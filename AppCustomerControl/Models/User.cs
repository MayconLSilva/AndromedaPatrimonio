using System.ComponentModel;

namespace AppCustomerControl.Models
{
    public class User
    {
        public int id { get; set; }
        [DisplayName("Nome")]
        public string nome { get; set; }

        [DisplayName("Login")]
        public string login { get; set; }

        [DisplayName("Password")]
        public string password { get; set; }
    }
}
