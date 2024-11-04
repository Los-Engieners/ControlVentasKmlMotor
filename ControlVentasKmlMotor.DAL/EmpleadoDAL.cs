using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.DAL
{
    public class EmpleadoDAL
    {
        public static string Encriptar(String pString)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(pString));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public static Empleado Login(Empleado pUsuario)
        {
            Empleado obj = new Empleado();

            string consulta = @"SELECT e.Id, e.IdCargo, e.Nombre, e.CorreoElectronico, e.Clave
                                FROM Empleados e
                                WHERE e.CorreoElectronico = @CorreoElectronico AND e.Clave = @Clave";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;

            //Encriptar Contraseña
            pUsuario.Clave = Encriptar(pUsuario.Clave);
            comando.Parameters.AddWithValue("@CorreoElectronico", pUsuario.CorreoElectronico);
            comando.Parameters.AddWithValue("@Clave", pUsuario.Clave);
            //Ejecutar consulta en el servidor
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            //Verificar el resultado        
            while (reader.Read())
            {
                obj.Id = reader.GetByte(0);
                obj.IdCargo = reader.GetByte(1);
                obj.CorreoElectronico = reader.GetString(2);
                obj.Clave = reader.GetString(3);

            }
            return obj;
        }

        #region METODOS  GUARDAR MODIFICAR Y ELIMINAR
        public static int Guardar(Empleado pEmpleado)
        {
            pEmpleado.Clave = Encriptar(pEmpleado.Clave);

            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = @"INSERT INTO Empleados (IdGenero, IdSucursal, IdCargo, Nombre, Apellido, CorreoElectronico, Clave, Estado)
                                    VALUES (@IdGenero, @IdSucursal, @IdCargo, @Nombre, @Apellido, @CorreoElectronico, @Clave, 1)";
            comando.Parameters.AddWithValue("@IdGenero", pEmpleado.IdGenero);
            comando.Parameters.AddWithValue("@IdSucursal", pEmpleado.IdSucursal);
            comando.Parameters.AddWithValue("@IdCargo", pEmpleado.IdCargo);
            comando.Parameters.AddWithValue("@Nombre", pEmpleado.Nombre);
            comando.Parameters.AddWithValue("@Apellido", pEmpleado.Apellido);
            comando.Parameters.AddWithValue("@CorreoElectronico", pEmpleado.CorreoElectronico);
            comando.Parameters.AddWithValue("@Clave", pEmpleado.Clave);
            return ComunDB.EjecutarComando(comando);

        }

        public static int Modificar(Empleado pEmpleado)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = @"UPDATE Empleados SET IdGenero=@IdGenero, IdSucursal=@IdSucursal, IdCargo=@IdCargo, Nombre=@Nombre,
                                    Apellido=@Apellido, CorreoElectronico=@CorreoElectronico, Clave=@Clave WHERE Id=@Id";
            comando.Parameters.AddWithValue("@IdGenero", pEmpleado.IdGenero);
            comando.Parameters.AddWithValue("@IdSucursal", pEmpleado.IdSucursal);
            comando.Parameters.AddWithValue("@IdCargo", pEmpleado.IdCargo);
            comando.Parameters.AddWithValue("@Nombre", pEmpleado.Nombre);
            comando.Parameters.AddWithValue("@Apellido", pEmpleado.Apellido);
            comando.Parameters.AddWithValue("@CorreoElectronico", pEmpleado.CorreoElectronico);
            comando.Parameters.AddWithValue("@Clave", pEmpleado.Clave);
            comando.Parameters.AddWithValue("@Id", pEmpleado.Id);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Empleado pEmpleado)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Empleados SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pEmpleado.Id);
            return ComunDB.EjecutarComando(comando);
        }
        #endregion
        #region Metodos de Busqueda
        public static Empleado ObtenerPorId(byte pId)
        {
            Empleado obj = new Empleado();

            string consulta = @"SELECT e.Id, e.IdGenero, e.IdSucursal, e.IdCargo, e.Nombre, e.Apellido, e.CorreoElectronico, e.Clave, e.Estado
                                FROM Empleados e 
                                WHERE e.Id = @Id ";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);

            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                obj.Id = reader.GetByte(0);
                obj.IdGenero = reader.GetByte(1);
                obj.IdSucursal = reader.GetByte(2);
                obj.IdCargo = reader.GetByte(3);
                obj.Nombre = reader.GetString(4);
                obj.Apellido = reader.GetString(5);
                obj.CorreoElectronico = reader.GetString(6);
                obj.Clave = reader.GetString(7);
                obj.Estado = reader.GetByte(8);
            }
            return obj;
        }
        #endregion

        #region Lista Empleados
        public static List<Empleado> Buscar(Empleado pEmpleado)
        {
            List<Empleado> lista = new List<Empleado>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = @"SELECT TOP 100 e.Id, e.IdGenero, e.IdSucursal, e.IdCargo, e.Nombre, e.Apellido, e.CorreoElectronico, e.Clave, e.Estado
                                    FROM Empleados e ";

                // Filtros
                if (pEmpleado.IdGenero > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " e.IdGenero = @IdGenero ";
                    comando.Parameters.AddWithValue("@IdGenero", pEmpleado.IdGenero);
                }
                if (pEmpleado.IdSucursal > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " e.IdSucursal = @IdSucursal ";
                    comando.Parameters.AddWithValue("@ISucursal", pEmpleado.IdSucursal);
                }
                if (pEmpleado.IdCargo > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " e.IdCargo = @IdCargo ";
                    comando.Parameters.AddWithValue("@IdCargo", pEmpleado.IdCargo);
                }

                if (pEmpleado.Nombre != null && pEmpleado.Nombre.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " e.Nombre LIKE @Nombre ";
                    comando.Parameters.AddWithValue("@Nombre", "%" + pEmpleado.Nombre + "%");
                }

                if (pEmpleado.Apellido   != null && pEmpleado.Apellido.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " e.Apellido LIKE @Apellido ";
                    comando.Parameters.AddWithValue("@Apellido", "%" + pEmpleado.Apellido + "%");
                }

                if (pEmpleado.CorreoElectronico != null && pEmpleado.CorreoElectronico.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " e.CorreoElectronico LIKE @CorreoElectronico ";
                    comando.Parameters.AddWithValue("@CorreoElectronico", "%" + pEmpleado.CorreoElectronico + "%");
                }

                if (pEmpleado.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " e.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pEmpleado.Estado);

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
                    Empleado obj = new Empleado();
                    obj.Id = reader.GetByte(0);
                    obj.IdGenero = reader.GetByte(1);
                    obj.IdSucursal = reader.GetByte(2);
                    obj.IdCargo = reader.GetByte(3);
                    obj.Nombre = reader.GetString(4);
                    obj.Apellido = reader.GetString(5);
                    obj.CorreoElectronico = reader.GetString(6);
                    obj.Clave = reader.GetString(7);
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
