using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias 
using ControlVentasKmlMotor.EN;
using System.Data;
using System.Data.SqlClient;

namespace ControlVentasKmlMotor.DAL
{
    public class MarcaDAL
    {
        #region Metodos Guardar, Modificar y Eliminar
        public static int Guardar (Marca pMarca)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "INSERT INTO Marcas(Nombre, Estado) VALUES (@Nombre, 1)";
            comando.Parameters.AddWithValue("@Nombre", pMarca.Nombre);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(Marca pMarca)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Marcas SET Nombre=@Nombre WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Nombre", pMarca.Nombre);
            comando.Parameters.AddWithValue("@Id", pMarca.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(Marca pMarca)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Marcas SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pMarca.Id);
            return ComunDB.EjecutarComando(comando);
        }
        #endregion
        #region METODOS DE BUSQUEDA
        public static Marca ObtenerPorId(byte pId)
        {
            Marca obj = new Marca();

            string consulta = "SELECT m.Id, m.Nombre, m.Estado FROM Marcas m WHERE m.Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);

            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                obj.Id = reader.GetByte(0);
                obj.Nombre = reader.GetString(1);
                obj.Estado = reader.GetByte(2);
            }
            return obj;
        }
        #endregion
        #region Metodos de Busqueda
        public static List<Marca> Buscar(Marca pMarca)
        {
            List<Marca> lista = new List<Marca>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = "SELECT TOP 100 m.Id, m.Nombre, m.Estado FROM Marcas m ";

                //Validar filtros
                if (pMarca.Nombre != null && pMarca.Nombre.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " m.Nombre LIKE @Nombre ";
                    comando.Parameters.AddWithValue("@Nombre", "%" + pMarca.Nombre + "%");
                }
                if (pMarca.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " m.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pMarca.Estado);
                }
                if (whereSQL.Trim().Length > 0)
                {
                    whereSQL = " WHERE " + whereSQL;
                }
                comando.CommandText = consulta + whereSQL;

                SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
                while (reader.Read())
                {
                    Marca obj = new Marca();
                    obj.Id = reader.GetByte(0);
                    obj.Nombre = reader.GetString(1);
                    obj.Estado = reader.GetByte(2);
                    lista.Add(obj);

                }
                comando.Connection.Dispose();


            }
            #endregion
            return lista;
        }
        #endregion
    }

}


