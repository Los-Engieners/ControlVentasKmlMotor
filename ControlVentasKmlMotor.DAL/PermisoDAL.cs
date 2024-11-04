using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.DAL
{
    public class PermisoDAL
    {


        #region METODOS GUARDAR, MODIFICAR Y ELIMINAR
        public static int Guardar(Permiso pPermiso)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "INSERT INTO Permisos(IdCargo, IdModulo, Estado) VALUES (@IdCargo, @IdModulo, 1)";
            comando.Parameters.AddWithValue("@IdCargo", pPermiso.IdCargo);
            comando.Parameters.AddWithValue("@IdModulo", pPermiso.IdModulo);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(Permiso pPermiso)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Permisos SET IdCargo=@IdCargo, IdModulo=@IdModulo WHERE Id=@Id";
            comando.Parameters.AddWithValue("@IdCargo", pPermiso.IdCargo);
            comando.Parameters.AddWithValue("@IdModulo", pPermiso.IdModulo);
            comando.Parameters.AddWithValue("@Id", pPermiso.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(Permiso pPermiso)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Permisos SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pPermiso.Id);
            return ComunDB.EjecutarComando(comando);
        }
        #endregion
        public static Permiso ObtenerPorId(byte pId)
        {
            Permiso obj = new Permiso();

            string consulta = "SELECT p.Id, p.IdCargo, p.IdModulo, p.Estado FROM Permisos p WHERE p.Id = @Id ";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);

            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                obj.Id = reader.GetInt32(0);
                obj.IdCargo = reader.GetByte(1);
                obj.IdModulo = reader.GetByte(2);
                obj.Estado = reader.GetByte(3);
            }
            return obj;
        }

        public static List<Permiso> Buscar(Permiso pPermiso)
        {
            List<Permiso> lista = new List<Permiso>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = @"SELECT TOP 100 p.Id, p.IdCargo, p.IdModulo, p.Estado FROM Permisos p ";

                // Filtros
                if (pPermiso.IdCargo > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " p.IdCargo = @IdCargo ";
                    comando.Parameters.AddWithValue("@IdCargo", pPermiso.IdCargo);

                }
                if (pPermiso.IdModulo > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " p.IdModulo = @IdModulo ";
                    comando.Parameters.AddWithValue("@IdModulo", pPermiso.IdModulo);

                }
                if (pPermiso.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " p.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pPermiso.Estado);

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
                    Permiso obj = new Permiso();
                    obj.Id = reader.GetInt32(0);
                    obj.IdCargo = reader.GetByte(1);
                    obj.IdModulo = reader.GetByte(2);;
                    obj.Estado = reader.GetByte(3);
                    //Agregar a la lista
                    lista.Add(obj);
                }
                comando.Connection.Dispose();

            }
            #endregion
            return lista;
        }


        public List<Permiso> Lista(byte idEmpleado)
        {
            List<Permiso> lista = new List<Permiso>();
            using (SqlConnection oconexion = new SqlConnection(ComunDB.strConexion))
            {
                try
                {
                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("SELECT P.IdCargo, p.IdModulo, m.Nombre  FROM Permisos p");
                    consulta.AppendLine("INNER JOIN Cargos c on c.Id = p.IdCargo");
                    consulta.AppendLine("INNER JOIN Empleados e on e.IdCargo = C.Id");
                    consulta.AppendLine("INNER JOIN Modulos m on m.Id = p.IdModulo");
                    consulta.AppendLine("WHERE e.Id = @idEmpleado");

                    SqlCommand comando = new SqlCommand(consulta.ToString(), oconexion);
                    comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    comando.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                IdCargo = Convert.ToByte(reader["IdCargo"]),
                                IdModulo = Convert.ToByte(reader["IdModulo"]),
                                Modulo = new Modulo { Id = reader.GetByte(1), Nombre = reader.GetString(2)}
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Permiso>();

                }
            }
            return lista;

        }

    }
}
