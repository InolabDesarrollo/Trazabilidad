namespace CTZ
{
    public static class Usr
    {
        //K=IdUsuario,Rick=IdArea,Joi=IdRol
        public static int K { get; set; }

        public static int Rick { get; set; }
        public static int Joi { get; set; }
        public static string Nombre { get; set; }
        public static string Mail { get; set; }
        public static bool Flag { get; set; }
        public static string host = "smtp.inolab.com";
        public static int port = 1025;
        public static string name = "notificaciones@inolab.com";
        public static string pass = "Notificaciones2021*";
    }
}