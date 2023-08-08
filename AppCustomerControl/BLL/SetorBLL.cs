using AppCustomerControl.Models;

namespace AppCustomerControl.BLL
{
    public class SetorBLL
    {
        public static List<Setor> listaSetores()
        {
            List<Setor> list = new List<Setor>();
            var setor1 = new Setor()
            {
                id = 1,
                descricao = "Tecnologia",
                data_cadastro = DateTime.Now
            };
            var setor2 = new Setor()
            {
                id = 2,
                descricao = "RH",
                data_cadastro = DateTime.Now.AddDays(-5)
            };
            list.Add(setor1);
            list.Add(setor2);

            return list;
        }
    }
}
