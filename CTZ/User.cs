using CTZ.Controlador;
using CTZ.Modelo;
using CTZ.Modelo.Browser;
using System.Data;

namespace CTZ
{
    public static class User
    {
        static UserRepository repository = new UserRepository();   
        static C_User controlador = new C_User(repository);
        public static int IdUsuario { get; set; }
        public static int IdArea { get; set; }
        public static int IdRol { get; set; }
        public static string Nombre { get; set; }
        public static string Mail { get; set; }

        public static string host = "smtp.inolab.com";

        public static int port = 1025;

        public static string name = "notificaciones@inolab.com";

        public static string pass = "Notificaciones2021*";

        public static DataTable loginUser(string user, string password)
        {
            return controlador.loginUser(user, password);
        }

        public static bool validateUser(string user, string password)
        {
            return controlador.validateUser(user, password);
        }
    }
}


