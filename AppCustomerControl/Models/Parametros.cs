namespace AppCustomerControl.Models
{
    public class Parametros
    {
        public static int id_usuario { get; set; }
        public static string login_usuario { get; set; }

        public static void atualiza(UsuarioAtual objUsuario)
        {
            id_usuario = objUsuario.id_usuario;
            login_usuario = objUsuario.login_usuario;
        }

        
    }
}
