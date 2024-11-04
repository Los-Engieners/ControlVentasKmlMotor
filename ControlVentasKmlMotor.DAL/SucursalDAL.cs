using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.DAL
{
    public class SucursalDAL
    {
        #region METODOS GUARDAR, MODIFICAR Y ELIMINAR
        public static int Guardar(Sucursal pSucursal)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "INSERT INTO Sucursales(Nombre, Direccion, Estado) VALUES (@Nombre, @Direccion, 1)";
            comando.Parameters.AddWithValue("@Nombre", pSucursal.Nombre);
            comando.Parameters.AddWithValue("@Direccion", pSucursal.Direccion);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(Sucursal pSucursal)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Sucursales SET Nombre=@Nombre, Direccion=@Direccion  WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Nombre", pSucursal.Nombre);
            comando.Parameters.AddWithValue("@Direccion", pSucursal.Direccion);
            comando.Parameters.AddWithValue("@Id", pSucursal.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(Sucursal pSucursal)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Sucursales SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pSucursal.Id);
            return ComunDB.EjecutarComando(comando);
        }
        #endregion

        public static Sucursal ObtenerPorId(byte pId)
        {
            Sucursal obj = new Sucursal();

            string consulta = "SELECT s.Id, s.Nombre, s.Direccion, s.Estado FROM Sucursales s WHERE s.Id = @Id ";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);

            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                obj.Id = reader.GetByte(0);
                obj.Nombre = reader.GetString(1);
                obj.Direccion = reader.GetString(2);
                obj.Estado = reader.GetByte(3);
            }
            return obj;
        }

        #region
        public static List<Sucursal> Buscar(Sucursal pSucursal)
        {
            List<Sucursal> lista = new List<Sucursal>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = "SELECT TOP 100 s.Id, s.Nombre, s.Direccion, s.Estado FROM Sucursales s ";

                // Filtros
                if (pSucursal.Nombre != null && pSucursal.Nombre.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " s.Nombre LIKE @Nombre ";
                    comando.Parameters.AddWithValue("@Nombre", "%" + pSucursal.Nombre + "%");
                }
                if (pSucursal.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " s.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pSucursal.Estado);
                }
                //Verificar WHERE
                if (whereSQL.Trim().Length > 0)
                {
                    whereSQL = " WHERE " + whereSQL;
                }
                comando.CommandText = consulta + whereSQL;

                SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
                while (reader.Read())
                {
                    Sucursal obj = new Sucursal();
                    obj.Id = reader.GetByte(0);
                    obj.Nombre = reader.GetString(1);
                    obj.Direccion = reader.GetString(2);
                    obj.Estado = reader.GetByte(3);
                    //Agregar a la lista
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
