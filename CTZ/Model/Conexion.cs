using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Modelo
{
    public  class Conexion
    {
        public static string source;
        public static string catalog;
        public static string user;
        public static string password;
        public static SqlConnection conexion;
        public static bool databaseProduction = false;
        public static bool databaseTest = true;

        public bool executeQuery(string query)
        {
            try
            {
                SqlCommand comand = new SqlCommand(query, conexion);
                conexion.Open();
                comand.ExecuteNonQuery();
                conexion.Close();
                Trace.WriteLine("PASS: SUCESS executeQuery()");
                return true;
            }
            catch (SqlException ex)
            {
                conexion.Close();
                Trace.WriteLine("PASS: FAILED executeQuery() " + ex.Message);
                return false;
            }
        }

        public int getScalar(string query)
        {
            try
            {
                SqlCommand comand = new SqlCommand(query, conexion);
                conexion.Open();
                int escalar = Convert.ToInt32(comand.ExecuteScalar());
                conexion.Close();
                Trace.WriteLine("PASS: SUCESS getScalar()");
                return escalar;

            }
            catch (SqlException ex)
            {
                conexion.Close();
                Trace.WriteLine("PASS: FAILED getScalar() " + ex.Message);
                return -1;
            }
        }

        public string getText(string query)
        {
            try
            {
                DataSet table = new DataSet();
                conexion.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(table);
                conexion.Close();
                Trace.WriteLine("PASS SUCES");
                return table.Tables[0].Rows[0][0].ToString();

            }
            catch (SqlException ex)
            {
                Trace.WriteLine("PASS FAILED getText ", ex.Message.ToString());
                conexion.Close();
                return null;
            }
            catch (IndexOutOfRangeException ex)
            {
                conexion.Close();
                Trace.WriteLine("PASS: FAILED ( " + ex.Message + " ) getText No encontro texto en esa posicion y devuelve '' ");
                return "";
            }
        }

        public DataTable getDataTable(string query)
        {
            try
            {
                DataSet table = new DataSet();
                conexion.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(table);
                conexion.Close();
                Trace.WriteLine("PASS SUCCES");
                return table.Tables[0];
            }
            catch (SqlException ex)
            {
                Trace.WriteLine("PASS FAILED getDataTable", ex.Message);
                conexion.Close();
                return null;
            }
        }
        
        public bool isThereSomeInformation(string query)
        {
            try
            {
                DataSet table = new DataSet();
                conexion.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(table);
                conexion.Close();
                Trace.WriteLine("PAAS SUCCES");
                return table.Tables[0].Rows.Count > 0 ? true : false;
            }
            catch (SqlException ex)
            {
                Trace.WriteLine("PAS FAILED", ex.Message);
                conexion.Close();
                return false;
            }
        }
    }
}
