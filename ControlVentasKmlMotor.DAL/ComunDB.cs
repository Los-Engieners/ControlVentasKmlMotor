using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.DAL      
{
    public class ComunDB
    {
       //public static string strConexion = @"Data Source=LUISPUYAUT\SQLEXPRESS;Initial Catalog=BdKmlMotor;Integrated Security=True";

        public static string strConexion = @"workstation id=DbKmlMotor.mssql.somee.com;packet size=4096;user id=CP23007_SQLLogin_1;pwd=xk5lyxcsyh;data source=DbKmlMotor.mssql.somee.com;persist security info=False;initial catalog=DbKmlMotor;TrustServerCertificate=True";

        private static SqlConnection ObtenerConexion()
        {  
            SqlConnection conexion = new SqlConnection(strConexion);
            conexion.Open();
            return conexion;
        }

        public static SqlCommand ObtenerComando()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = ObtenerConexion();
            return comando;
        }

        public static int EjecutarComando(SqlCommand pComando)
        {
            int resultado = pComando.ExecuteNonQuery();
            pComando.Connection.Close();
            return resultado;
        }

        public static SqlDataReader EjecutarComandoReader(SqlCommand pComando)
        {
            SqlDataReader reader = pComando.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        public static SqlTransaction CrearTransaction()
        {
            SqlConnection conexion = ObtenerConexion();
            return conexion.BeginTransaction();
        }

        public  static SqlCommand ObtenerComando(SqlTransaction pTransaction)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = pTransaction.Connection;
            comando.Transaction = pTransaction;
            return comando;
        }

    }
}
