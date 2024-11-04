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
    public class ClienteDAL
    {
        #region METODOS GUARDAR, MODIFICAR Y ELIMINAR
        public static int Guardar(Cliente pCliente)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "INSERT INTO Clientes (IdGenero, Nombre, Apellido, DUI, Telefono, FechaNacimiento, Direccion, Estado) VALUES (@IdGenero, @Nombre, @Apellido, @DUI, @Telefono, @FechaNacimiento, @Direccion, 1)";
            comando.Parameters.AddWithValue("@IdGenero", pCliente.IdGenero);
            comando.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
            comando.Parameters.AddWithValue("@Apellido", pCliente.Apellido);
            comando.Parameters.AddWithValue("@DUI", pCliente.DUI);
            comando.Parameters.AddWithValue("@Telefono", pCliente.Telefono);
            comando.Parameters.AddWithValue("@FechaNacimiento", pCliente.FechaNacimiento);
            comando.Parameters.AddWithValue("@Direccion", pCliente.Direccion);
             return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(Cliente pCliente)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Clientes SET IdGenero=@IdGenero, Nombre=@Nombre, Apellido=@Apellido, DUI=@DUI, Telefono=@Telefono, FechaNacimiento=@FechaNacimiento, Direccion=@Direccion WHERE Id=@Id";
            comando.Parameters.AddWithValue("@IdGenero", pCliente.IdGenero);
            comando.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
            comando.Parameters.AddWithValue("@Apellido", pCliente.Apellido);
            comando.Parameters.AddWithValue("@DUI", pCliente.DUI);
            comando.Parameters.AddWithValue("@Telefono", pCliente.Telefono);
            comando.Parameters.AddWithValue("@FechaNacimiento", pCliente.FechaNacimiento);
            comando.Parameters.AddWithValue("@Direccion", pCliente.Direccion);
            comando.Parameters.AddWithValue("@Id", pCliente.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(Cliente pCliente)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Clientes SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pCliente.Id);
            return ComunDB.EjecutarComando(comando);
        }
        #endregion

        #region Metodos de Busqueda
        public static Cliente ObtenerPorId(Int32 pId)
        {
            Cliente obj = new Cliente();

            string consulta = @"SELECT c.Id, c.IdGenero, c.Nombre, c.Apellido, c.DUI, c.Telefono, c.FechaNacimiento, c.Direccion, c.Estado
                                FROM Clientes c 
                                WHERE c.Id = @Id ";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);

            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                obj.Id = reader.GetInt32(0);
                obj.IdGenero = reader.GetByte(1);
                obj.Nombre = reader.GetString(2);
                obj.Apellido = reader.GetString(3);
                obj.DUI = reader.GetString(4);
                obj.Telefono = reader.GetString(5);
                obj.FechaNacimiento = reader.GetDateTime(6);
                obj.Direccion = reader.GetString(7);
                obj.Estado = reader.GetByte(8);
            }
            return obj;
        }
        #endregion

        #region Lista Cliente
        public static List<Cliente> Buscar(Cliente pCliente)
        {
            List<Cliente> lista = new List<Cliente>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = @"SELECT TOP 100 c.Id, c.IdGenero, c.Nombre, c.Apellido,  c.DUI, c.Telefono, c.FechaNacimiento, c.Direccion, c.Estado
                                    FROM Clientes c ";

                // Filtros
                if (pCliente.IdGenero > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " c.IdGenero = @IdGenero ";
                    comando.Parameters.AddWithValue("@IdGenero", pCliente.IdGenero);
                }
                
               

                if (pCliente.Nombre != null && pCliente.Nombre.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " c.Nombre LIKE @Nombre ";
                    comando.Parameters.AddWithValue("@Nombre", "%" + pCliente.Nombre + "%");
                }

                if (pCliente.Apellido != null && pCliente.Apellido.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " c.Apellido LIKE @Apellido ";
                    comando.Parameters.AddWithValue("@Apellido", "%" + pCliente.Apellido + "%");
                }

                if (pCliente.DUI != null && pCliente.DUI.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " c.DUI LIKE @DUI ";
                    comando.Parameters.AddWithValue("@DUI", "%" + pCliente.DUI + "%");
                }

                if (pCliente.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " c.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pCliente.Estado);

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
                    Cliente obj = new Cliente();
                    obj.Id = reader.GetInt32(0);
                    obj.IdGenero = reader.GetByte(1);
                    obj.Nombre = reader.GetString(2);
                    obj.Apellido = reader.GetString(3);
                    obj.DUI = reader.GetString(4);
                    obj.Telefono = reader.GetString(5);
                    obj.FechaNacimiento = reader.GetDateTime(6);
                    obj.Direccion = reader.GetString(7);
                    obj.Estado = reader.GetByte(8);
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
