namespace AndromedaPatrimonio.Models
{
    public class Parametros
    {
        public static int id_usuario { get; set; }
        public static string login_usuario { get; set; }
        public static int id_empresa { get; set; }
        public static string nome_empresa { get; set; }
        public static string nome_empresa_completo { get; set; }

        public static void atualiza(UsuarioAtual objUsuario)
        {
            id_usuario = objUsuario.id_usuario;
            login_usuario = objUsuario.login_usuario;
            id_empresa = objUsuario.id_empresa;
            nome_empresa = objUsuario.nome_empresa;
            nome_empresa_completo = string.Concat(id_empresa, " - " ,objUsuario.nome_empresa);

        }

        
    }
}
