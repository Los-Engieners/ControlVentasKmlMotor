using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlVentasKmlMotor.EN;
using System.Data;
using System.Data.SqlClient;

namespace ControlVentasKmlMotor.DAL
{
    public class VehiculoDAL
    {
        #region METODOS GUARDAR, MODIFICAR Y ELIMINAR
        public static int Guardar(Vehiculo pVehiculo)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "INSERT INTO Vehiculos(IdModelo, IdColor, FechaLanzamiento, Precio, Existencias, Imagen, Estado) VALUES (@IdModelo, @IdColor, @FechaLanzamiento, @Precio, @Existencias, @Imagen,  1)";
            comando.Parameters.AddWithValue("@IdModelo", pVehiculo.IdModelo);
            comando.Parameters.AddWithValue("@IdColor", pVehiculo.IdColor);
            comando.Parameters.AddWithValue("@FechaLanzamiento", pVehiculo.FechaLanzamiento);
            comando.Parameters.AddWithValue("@Precio", pVehiculo.Precio);
            comando.Parameters.AddWithValue("@Existencias", pVehiculo.Existencias);
            comando.Parameters.AddWithValue("@Imagen", pVehiculo.Imagen);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(Vehiculo pVehiculo)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Vehiculos SET IdModelo=@IdModelo, IdColor=@IdColor, FechaLanzamiento=@FechaLanzamiento, Precio=@Precio, Imagen=@Imagen WHERE Id=@Id";
            comando.Parameters.AddWithValue("@IdModelo", pVehiculo.IdModelo);
            comando.Parameters.AddWithValue("@IdColor", pVehiculo.IdColor);
            comando.Parameters.AddWithValue("@FechaLanzamiento", pVehiculo.FechaLanzamiento);
            comando.Parameters.AddWithValue("@Precio", pVehiculo.Precio);
            comando.Parameters.AddWithValue("@Imagen", pVehiculo.Imagen);
            comando.Parameters.AddWithValue("@Id", pVehiculo.Id);
            return ComunDB.EjecutarComando(comando);
        }

        public static SqlCommand DescontarStock(Vehiculo pVehiculo, SqlTransaction pTransaction)
        {
            SqlCommand comando = ComunDB.ObtenerComando(pTransaction);
            comando.CommandText = @"UPDATE Vehiculos SET Existencias = Existencias - 1 WHERE Id = @Id";
            comando.Parameters.AddWithValue("@Id", pVehiculo.Id);
            return comando;
        }
        public static int Eliminar(Vehiculo pVehiculo)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Vehiculos SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pVehiculo.Id);
            return ComunDB.EjecutarComando(comando);
        }

        public static int ActualizarExistencias(Vehiculo pVehiculo)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Vehiculos SET Existencias=@Existencias WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Existencias", pVehiculo.Existencias);
            comando.Parameters.AddWithValue("@Id", pVehiculo.Id);
            return ComunDB.EjecutarComando(comando);
        }
        #endregion

        public static Vehiculo ObtenerPorId(short pId)
        {
            Vehiculo obj = new Vehiculo();

            string consulta = "SELECT v.Id, v.IdModelo, v.IdColor, v.FechaLanzamiento, v.Precio, v.Existencias, v.Imagen, v.Estado FROM Vehiculos v WHERE v.Id = @Id ";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);

            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                obj.Id = reader.GetInt16(0);
                obj.IdModelo = reader.GetByte(1);
                obj.IdColor = reader.GetByte(2);
                obj.FechaLanzamiento = reader.GetString(3);
                obj.Precio = reader.GetDecimal(4);
                obj.Existencias = reader.GetByte(5);
                obj.Imagen = reader.GetString(6);
                obj.Estado = reader.GetByte(7);

            }
            return obj;
        }

    
        public static List<Vehiculo> Buscar(Vehiculo pVehiculo)
        {
            List<Vehiculo> lista = new List<Vehiculo>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = @"SELECT TOP 100 v.Id, v.IdModelo, v.IdColor, v.FechaLanzamiento, v.Precio, v.Existencias, v.Imagen, v.Estado FROM Vehiculos v ";

                // Filtros
                if (pVehiculo.IdModelo > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.IdModelo = @IdModelo ";
                    comando.Parameters.AddWithValue("@IdModelo", pVehiculo.IdModelo);

                }
                if (pVehiculo.IdColor > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.IdColor = @IdColor";
                    comando.Parameters.AddWithValue("@IdColor", pVehiculo.IdColor);

                }
                if (pVehiculo.FechaLanzamiento != null && pVehiculo.FechaLanzamiento.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.FechaLanzamiento = @FechaLanzamiento ";
                    comando.Parameters.AddWithValue("@FechaLanzamiento", pVehiculo.FechaLanzamiento);

                }
                if (pVehiculo.Precio > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.Precio = @Precio";
                    comando.Parameters.AddWithValue("@Precio", pVehiculo.Precio);

                }
                if (pVehiculo.Existencias> 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.Existencias = @Existencias ";
                    comando.Parameters.AddWithValue("@Existencias", pVehiculo.Existencias);

                }
                if (pVehiculo.Imagen != null && pVehiculo.Imagen.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.Imagen = @Imagen ";
                    comando.Parameters.AddWithValue("@Imagen", pVehiculo.Imagen);

                }
                if (pVehiculo.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pVehiculo.Estado);

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
                    Vehiculo obj = new Vehiculo ();
                    obj.Id = reader.GetInt16(0);
                    obj.IdModelo = reader.GetByte(1);
                    obj.IdColor = reader.GetByte(2);
                    obj.FechaLanzamiento = reader.GetString(3);
                    obj.Precio = reader.GetDecimal(4);
                    obj.Existencias = reader.GetByte(5);
                    obj.Imagen = reader.GetString(6);
                    obj.Estado = reader.GetByte(7);
                    //Agregar a la lista
                    lista.Add(obj);
                }
                comando.Connection.Dispose();

            }
            #endregion
            return lista;

        }
    }
}
