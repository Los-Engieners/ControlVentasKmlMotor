using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.DAL
{
    public class CargoDAL
    {
        #region Metodos GUARDAR, MODIFICAR Y ELIMINAR
        public static int Guardar(Cargo pCargo )
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "INSERT INTO Cargos(Nombre, Estado) VALUES (@Nombre, 1)";
            comando.Parameters.AddWithValue("@Nombre", pCargo.Nombre);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Cargo pCargo ) 
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Cargos SET Nombre=@Nombre WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Nombre", pCargo.Nombre);
            comando.Parameters.AddWithValue("@Id", pCargo.Id);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Cargo pCargo)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Cargos SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pCargo.Id);
            return ComunDB.EjecutarComando(comando);
        }

        #endregion

        #region METODOS DE BUSQUEDA
        public static Cargo ObtenerPorId(byte pId)
        {
            Cargo obj = new Cargo();

            string consulta = "SELECT c.Id, c.Nombre, c.Estado FROM Cargos c WHERE c.Id = @Id";
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
        public static List<Cargo> Buscar(Cargo pCargo)
        {
            List<Cargo> lista = new List<Cargo>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = "SELECT TOP 100 c.Id, c.Nombre, c.Estado FROM Cargos c ";

                //Validar filtros
                if (pCargo.Nombre != null && pCargo.Nombre.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " c.Nombre LIKE @Nombre ";
                    comando.Parameters.AddWithValue("@Nombre", "%" + pCargo.Nombre + "%");
                }
                if (pCargo.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " c.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pCargo.Estado);
                }
                if (whereSQL.Trim().Length > 0)
                {
                    whereSQL = " WHERE " + whereSQL;
                }
                comando.CommandText = consulta + whereSQL;

                SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
                while (reader.Read())
                {
                    Cargo obj = new Cargo();
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
