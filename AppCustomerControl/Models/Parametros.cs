namespace AppCustomerControl.Models
{
    public class Parametros
    {
        public static int id_usuario { get; set; }
        public static string login_usuario { get; set; }

        public  Parametros(int IDUsuario, string LoginUsuario)
        {
            id_usuario = IDUsuario;
            login_usuario = LoginUsuario;
        }

        
    }
}
