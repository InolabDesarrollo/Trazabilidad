using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSpire
{
    internal class Functions
    {
        public string connectionBrowser = "Data Source=INOLABSERVER01;Initial Catalog=Browser;Persist Security Info=True;User ID=ventas;Password=V3ntas_17";
        public object ConfigurationManager { get; private set; }

        public string Date2(DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public bool Log(string user, string pass)
        {
            string sql =
              "SELECT * FROM Usuarios Where Usuario='" + user + "' and Password_='" + pass + "' and Activo='1'";
            //MessageBox.Show(sql);
            SqlConnection conn = new SqlConnection(connectionBrowser);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public bool Log(int Id, int Rol)
        {
            string sql =
              "SELECT * FROM Usuarios Where IdUsuario='" + Id.ToString() + "' and Activo='1' and IdRol=" + Rol + ";";
            //MessageBox.Show(sql);
            SqlConnection conn = new SqlConnection(connectionBrowser);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public int getArea(string user, string pass)
        {
            string sql = "select IdArea from Usuarios where Usuario='" + user + "' and Password_='" + pass + "' ";
            SqlConnection conn = new SqlConnection(connectionBrowser);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int re;
            if (reader.Read())
            {
                return re = Int32.Parse(reader.GetValue(0).ToString());
            }
            else
            {
                return 0;
            }
        }

        public int getRol(string user, string pass)
        {
            string sql = "select IdRol from Usuarios where Usuario='" + user + "' and Password_='" + pass + "' ";
            SqlConnection conn = new SqlConnection(connectionBrowser);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int re;
            if (reader.Read())
            {
                return re = Int32.Parse(reader.GetValue(0).ToString());
            }
            else
            {
                return 0;
            }
        }

        public int getIdUsuario(string user, string pass)
        {
            string sql = "select IdUsuario from Usuarios where Usuario='" + user + "' and Password_='" + pass + "' ";
            SqlConnection conn = new SqlConnection(connectionBrowser);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int re;
            if (reader.Read())
            {
                return re = Int32.Parse(reader.GetValue(0).ToString());
            }
            else
            {
                return 0;
            }
        }

        public string getNombre(string user, string pass)
        {
            string sql = "select Nombre from Usuarios where Usuario='" + user + "' and Password_='" + pass + "' ";
            SqlConnection conn = new SqlConnection(connectionBrowser);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            string re;
            if (reader.Read())
            {
                return re = reader.GetValue(0).ToString();
            }
            else
            {
                return "0";
            }
        }

        public void alert(string message, string caption)
        {
            var w = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(0.85))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

            MessageBox.Show(w, message, caption);
        }

        public bool SetSql(string sql, string connection)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            Console.WriteLine("/*************SetSql**************/");
            Console.WriteLine(sql);
            Console.WriteLine("/*************SetSql**************/");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int temp = Convert.ToInt32(cmd.ExecuteNonQuery().ToString());
            conn.Close();
            if (temp > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DateTime ToDate(string date)
        {
            DateTime dd;
            if (DateTime.TryParse(date, out dd))
            {
                return dd;
            }
            else
            {
                return dd;
            }
        }
    }
}