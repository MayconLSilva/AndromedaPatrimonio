using AndromedaPatrimonio.Models;

namespace AndromedaPatrimonio.BLL
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
            var setor3 = new Setor()
            {
                id = 3,
                descricao = "Administrativo",
                data_cadastro = DateTime.Now.AddDays(-5)
            };
            var setor4 = new Setor()
            {
                id = 4,
                descricao = "Financeiro",
                data_cadastro = DateTime.Now.AddDays(-5)
            };
            list.Add(setor1);
            list.Add(setor2);
            list.Add(setor3);
            list.Add(setor4);

            return list;
        }
    
        public static List<Empresa> listaEmpresas()
        {
            var listEmpresa = new List<Empresa>();
            listEmpresa.Add(new Empresa(1, "WinRar Digital"));
            listEmpresa.Add(new Empresa(2, "CDS Informatica"));

            return listEmpresa;
        }
    }
}
