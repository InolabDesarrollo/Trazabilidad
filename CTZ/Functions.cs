using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ
{
    internal class Functions
    {
        public string connectionString = "Data Source=INOLABSERVER01;Initial Catalog=Documentacion;Persist Security Info=True;User ID=ventas;Password=V3ntas_17";
        public string connectionStringBrowser = "Data Source=INOLABSERVER01;Initial Catalog=Browser;Persist Security Info=True;User ID=ventas;Password=V3ntas_17";

        public SqlDataReader GetLog(string usr, string pass)
        {
            string sql =
              "select IdUsuario,IdRol,IdArea,Mail from Usuarios where Usuario='" + usr + "' and Password_='" + pass + "' and Activo='1'";
            //MessageBox.Show(sql);
            SqlConnection conn = new SqlConnection(connectionStringBrowser);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader;
            }
            return null;
        }

        public void Material(MaterialSkin.Controls.MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.Blue200,
                TextShade.WHITE);
        }

        public void alert(string message, string caption)
        {
            var w = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(0.85))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

            MessageBox.Show(w, message, caption);
        }

        public bool SetSql(string queryString, bool alt)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                //
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    if (alt)
                    {
                        alert("Guardado.", "");
                    }

                    return true;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido algun problema. Comuniquese con el administrador.\n");
                    return false;
                }
            }
        }

        public bool SetSql(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                //
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                int res = command.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Guardado.");
                    return true;
                }
                if (res >= 1)
                {
                    MessageBox.Show("Guardado.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido algun problema. Comuniquese con el administrador.");
                    return false;
                }
            }
        }

        public void populateFromSqlString(MaterialComboBox cbx, string sql, string display, string value, string add)
        {
            try
            {
                cbx.DataSource = null;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCmd = new SqlCommand(sql, sqlConnection);
                    sqlConnection.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        cbx.Items.Add(sqlReader[add].ToString());
                    }
                    cbx.DisplayMember = display;
                    cbx.ValueMember = value;

                    sqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        public void populateFromSqlStringDS(MaterialComboBox cbx, string sql, string display, string value, string table)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCmd = new SqlCommand(sql, sqlConnection);
                    sqlConnection.Open();

                    SqlDataAdapter da1 = new SqlDataAdapter(sql, sqlConnection);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);

                    cbx.DataSource = dt1;
                    cbx.DisplayMember = display;
                    cbx.ValueMember = value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        public DataSet GetCertU(string iduso, string ident)
        {
            DataSet dt = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter("GetCertUI", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@ident", SqlDbType.VarChar).Value = ident;
                da.SelectCommand.Parameters.Add("@idu", SqlDbType.Int).Value = iduso;

                da.Fill(dt);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                MessageBox.Show(x.ToString());
            }
            return dt;
        }

        public DataSet GetModeloIm(string idm)
        {
            DataSet dt = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter("GetModeloIm", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@idm", SqlDbType.VarChar).Value = idm;

                da.Fill(dt);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                MessageBox.Show(x.ToString());
            }
            return dt;
        }

        public DataSet GetCertU(string iduso)
        {
            DataSet dt = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter("GetCertU", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@idus", SqlDbType.Int).Value = iduso;

                da.Fill(dt);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.GetBaseException().ToString(), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataSet GetCertU1(string iduso)
        {
            /* string sql = "select distinct(certificado.IdCertificado),certificado.certificado as 'cer' from Certificado " +
                           "inner join detalleCert on detalleCert.idUso = " + uso.SelectedValue + " and detalleCert.idCert = certificado.IdCertificado " +
                           "where detalleCert.actual !=1 " +
                            " order by certificado.certificado asc";*/
            DataSet dt = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter("GetCertU1", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@idus", SqlDbType.Int).Value = iduso;

                da.Fill(dt);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.GetBaseException().ToString(), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataSet GetDataFromDatabaseinDataSet(string marca)
        {
            DataSet ds = new DataSet();
            try
            {
                // database Connection String
                using (SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    using (SqlDataAdapter SqlDa = new SqlDataAdapter(marca, sqlCon))
                    {
                        SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

                        SqlDa.Fill(ds);
                    }
                }
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool MatchFloat(string text)
        {
            string flot = @"^[+-]?\d+(\.\d+)?$";
            //string input = firstdoc.GetCellValueAsString(i, j);
            Match m = Regex.Match(text, flot, RegexOptions.IgnoreCase);
            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string DateToString(DateTime date)
        {
            return date.ToString("yyyy-MM-dd ");
        }

        public string DateToString1(DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public bool IsValid(string txt)
        {
            if (String.IsNullOrWhiteSpace(txt) || String.IsNullOrEmpty(txt))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isDate(string date)
        {
            DateTime datevalue;
            if (DateTime.TryParse(date, out datevalue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SqlDataReader GetRead(string query)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader;
            }
            else
            {
                return null;
            }
        }

        public SqlDataReader GetRead(string query, string conection)
        {
            SqlConnection conn = new SqlConnection(conection);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader;
            }
            else
            {
                return null;
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

        public DataSet DS(string conn, string query)
        {
            DataSet dt = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(conn);
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);

                return dt;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.GetBaseException().ToString(), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }
        }
    }
}