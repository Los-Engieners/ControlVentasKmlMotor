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
    public class ModeloDAL
    {

        #region METODOS GUARDAR, MODIFICAR Y ELIMINAR
        public static int Guardar(Modelo pModelo)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "INSERT INTO Modelos(IdMarca, IdTipoAuto, Nombre, Estado) VALUES (@IdMarca, @IdTipoAuto, @Nombre, 1)";
            comando.Parameters.AddWithValue("@IdMarca", pModelo.IdMarca);
            comando.Parameters.AddWithValue("@IdTipoAuto", pModelo.IdTipoAuto);
            comando.Parameters.AddWithValue("@Nombre", pModelo.Nombre);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(Modelo pModelo)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Modelos SET IdMarca=@IdMarca, IdTipoAuto=@IdTipoAuto,  Nombre=@Nombre WHERE Id=@Id";
            comando.Parameters.AddWithValue("@IdMarca", pModelo.IdMarca);
            comando.Parameters.AddWithValue("@IdTipoAuto", pModelo.IdTipoAuto);
            comando.Parameters.AddWithValue("@Nombre", pModelo.Nombre);
            comando.Parameters.AddWithValue("@Id", pModelo.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(Modelo pModelo)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Modelos SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pModelo.Id);
            return ComunDB.EjecutarComando(comando);
        }
        #endregion

        public static Modelo ObtenerPorId(byte pId)
        {
            Modelo obj = new Modelo();

            string consulta = "SELECT m.Id, m.IdMarca, m.IdTipoAuto, m.Nombre, m.Estado FROM Modelos m WHERE m.Id = @Id ";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);

            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                obj.Id = reader.GetByte(0);
                obj.IdMarca = reader.GetByte(1);
                obj.IdTipoAuto = reader.GetByte(2);
                obj.Nombre = reader.GetString(3);
                obj.Estado = reader.GetByte(4);
            }
            return obj;
        }

        public static List<Modelo> Buscar(Modelo pModelo)
        {
            List<Modelo> lista = new List<Modelo>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = @"SELECT TOP 100 m.Id, m.IdMarca, m.IdTipoAuto, m.Nombre, m.Estado FROM Modelos m ";

                // Filtros
                if (pModelo.IdMarca> 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " m.IdMarca = @IdMarca ";
                    comando.Parameters.AddWithValue("@IdMarca", pModelo.IdMarca);

                }
                if (pModelo.IdTipoAuto > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " m.IdTipoAuto = @IdTipoAuto ";
                    comando.Parameters.AddWithValue("@IdTipoAuto", pModelo.IdTipoAuto);

                }
                if (pModelo.Nombre != null && pModelo.Nombre.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " m.Nombre LIKE @Nombre";
                    comando.Parameters.AddWithValue("@Nombre", "%" + pModelo.Nombre + "%");

                }
                if (pModelo.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " m.Estado = @Estado";
                    comando.Parameters.AddWithValue("@Estado", pModelo.Estado);

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
                    Modelo obj = new Modelo();
                    obj.Id = reader.GetByte(0);
                    obj.IdMarca = reader.GetByte(1);
                    obj.IdTipoAuto = reader.GetByte(2);
                    obj.Nombre = reader.GetString(3);
                    obj.Estado = reader.GetByte(4);
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
