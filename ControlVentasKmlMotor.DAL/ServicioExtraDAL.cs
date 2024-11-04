using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.DAL
{
    public class ServicioExtraDAL
    {
        #region METODOS GUARDAR, MODIFICAR Y ELIMINAR
        public static int Guardar(ServicioExtra pServicio)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "INSERT INTO Servicios(Nombre, Precio, Estado) VALUES (@Nombre, @Precio, 1)";
            comando.Parameters.AddWithValue("@Nombre", pServicio.Nombre);
            comando.Parameters.AddWithValue("@Precio", pServicio.Precio);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(ServicioExtra pServicio)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Servicios SET Nombre=@Nombre, Precio=@Precio WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Nombre", pServicio.Nombre);
            comando.Parameters.AddWithValue("@Precio", pServicio.Precio);
            comando.Parameters.AddWithValue("@Id", pServicio.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(ServicioExtra pServicio)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Servicios SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pServicio.Id);
            return ComunDB.EjecutarComando(comando);
        }
        #endregion

        #region Metodos de buscada
        public static ServicioExtra ObtenerPorId(short pId)
        {
            ServicioExtra obj = new ServicioExtra();

            string consulta = "SELECT s.Id, s.Nombre, s.Precio, s.Estado FROM Servicios s WHERE s.Id = @Id ";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);

            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                obj.Id = reader.GetInt16(0);
                obj.Nombre = reader.GetString(1);
                obj.Precio = reader.GetDecimal(2);
                obj.Estado = reader.GetByte(3);

            }
            return obj;
        }

        public static List<ServicioExtra> Buscar(ServicioExtra pServicio)
        {
            List<ServicioExtra> lista = new List<ServicioExtra>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = @"SELECT TOP 100 s.Id, s.Nombre, s.Precio, s.Estado FROM Servicios s ";

                // Filtros
            
                if (pServicio.Nombre != null && pServicio.Nombre.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " s.Nombre = @Nombre ";
                    comando.Parameters.AddWithValue("@Nombre", pServicio.Nombre);

                }
                if (pServicio.Precio > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " s.Precio = @Precio";
                    comando.Parameters.AddWithValue("@Precio", pServicio.Precio);

                }
                if (pServicio.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " s.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pServicio.Estado);

                }

                //AGREGAR FILTROS Verificar WHERE
                if (whereSQL.Trim().Length > 0)
                {
                    whereSQL = " WHERE " + whereSQL;
                }
                comando.CommandText = consulta + whereSQL;

                SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
                while (reader.Read())
                {
                    ServicioExtra obj = new ServicioExtra();
                    obj.Id = reader.GetInt16(0);
                    obj.Nombre = reader.GetString(1);
                    obj.Precio = reader.GetDecimal(2);
                    obj.Estado = reader.GetByte(3);
                    //Agregar a la lista
                    lista.Add(obj);
                }
                comando.Connection.Dispose();

            }
            #endregion
            return lista;


            #endregion
        }
}   }
