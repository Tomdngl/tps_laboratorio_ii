using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BaseDeDatos
    {
        private static string cadena_conexion;
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static BaseDeDatos()
        {
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            cadena_conexion = @"Data Source=PC-ASROCK;Database=Competencia;Trusted_Connection=True;";
            conexion = new SqlConnection(BaseDeDatos.cadena_conexion);
            comando.Connection = conexion;
        }

        public static List<Juego> ObtenerTodos()
        {
            List<Juego> lista = new List<Juego>();

            try
            {
                conexion.Open();

                comando.CommandText = "SELECT * FROM juegos";
                SqlDataReader sqlDataReader = comando.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    lista.Add(new Juego(int.Parse(sqlDataReader["codigo"].ToString()),
                        (Equipo)Enum.Parse(typeof(Equipo), sqlDataReader["ganador"].ToString()),
                        int.Parse(sqlDataReader["rojos"].ToString()),
                        int.Parse(sqlDataReader["verdes"].ToString()),
                        int.Parse(sqlDataReader["puntos"].ToString()),
                        double.Parse(sqlDataReader["tiempo"].ToString())));
                }

                sqlDataReader.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                    conexion.Close();
            }
            return lista;
        }

        public static List<Ajedrez> ObtenerAjedrez()
        {
            List<Ajedrez> lista = new List<Ajedrez>();

            try
            {
                comando.Parameters.Clear();

                conexion.Open();

                comando.CommandText = $"SELECT * FROM juegos WHERE juego = @juego";
                comando.Parameters.AddWithValue("@juego", "Ajedrez");
                SqlDataReader sqlDataReader = comando.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    lista.Add(new Ajedrez(int.Parse(sqlDataReader["codigo"].ToString()),
                        (Equipo)Enum.Parse(typeof(Equipo), sqlDataReader["ganador"].ToString()),
                        int.Parse(sqlDataReader["rojos"].ToString()),
                        int.Parse(sqlDataReader["verdes"].ToString()),
                        int.Parse(sqlDataReader["puntos"].ToString()),
                        double.Parse(sqlDataReader["tiempo"].ToString())));
                }

                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }

        public static List<Quemados> ObtenerQuemados()
        {
            List<Quemados> lista = new List<Quemados>();

            try
            {
                comando.Parameters.Clear();

                conexion.Open();

                comando.CommandText = $"SELECT * FROM juegos WHERE juego = @juego";
                comando.Parameters.AddWithValue("@juego", "Quemados");
                SqlDataReader sqlDataReader = comando.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    lista.Add(new Quemados(int.Parse(sqlDataReader["codigo"].ToString()),
                        (Equipo)Enum.Parse(typeof(Equipo), sqlDataReader["ganador"].ToString()),
                        int.Parse(sqlDataReader["rojos"].ToString()),
                        int.Parse(sqlDataReader["verdes"].ToString()),
                        int.Parse(sqlDataReader["puntos"].ToString()),
                        double.Parse(sqlDataReader["tiempo"].ToString())));
                }

                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }

        public static List<Carrera> ObtenerCarrera()
        {
            List<Carrera> lista = new List<Carrera>();

            try
            {
                comando.Parameters.Clear();

                conexion.Open();

                comando.CommandText = $"SELECT * FROM juegos WHERE juego = @juego";
                comando.Parameters.AddWithValue("@juego", "Carrera");
                SqlDataReader sqlDataReader = comando.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    lista.Add(new Carrera(int.Parse(sqlDataReader["codigo"].ToString()),
                        (Equipo)Enum.Parse(typeof(Equipo), sqlDataReader["ganador"].ToString()),
                        int.Parse(sqlDataReader["rojos"].ToString()),
                        int.Parse(sqlDataReader["verdes"].ToString()),
                        int.Parse(sqlDataReader["puntos"].ToString()),
                        double.Parse(sqlDataReader["tiempo"].ToString())));
                }

                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }

        public static bool Agregar(Juego juego, string tipo)
        {
            bool isOk = true;
            try
            {
                comando.Parameters.Clear();

                string sql = "INSERT INTO juegos (juego, rojos, verdes, puntos, tiempo, ganador) VALUES(@juego, @rojos, @verdes, @puntos, @tiempo, @ganador)";
                comando.Parameters.AddWithValue("@codigo", juego.Codigo);
                comando.Parameters.AddWithValue("@tiempo", juego.Minutos);
                comando.Parameters.AddWithValue("@juego", tipo);
                comando.Parameters.AddWithValue("@rojos", juego.ParticipantesRojos);
                comando.Parameters.AddWithValue("@verdes", juego.ParticipantesVerdes);
                comando.Parameters.AddWithValue("@puntos", juego.Puntos);
                comando.Parameters.AddWithValue("@ganador", juego.Ganador.ToString());

                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    isOk = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return isOk;
        }

        public static bool Modificar(Juego juego, int codigo)
        {
            bool isOk = false;
            try
            {
                comando.Parameters.Clear();

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.CommandText = $"UPDATE juegos SET rojos = @rojos , verdes = @verdes , puntos = @puntos , ganador = @ganador , tiempo = @tiempo WHERE codigo = @codigo";
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@tiempo", juego.Minutos);
                comando.Parameters.AddWithValue("@rojos", juego.ParticipantesRojos);
                comando.Parameters.AddWithValue("@verdes", juego.ParticipantesVerdes);
                comando.Parameters.AddWithValue("@puntos", juego.Puntos);
                comando.Parameters.AddWithValue("@ganador", juego.Ganador.ToString());

                comando.ExecuteNonQuery();
                isOk = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                    conexion.Close();
            }
            return isOk;
        }

        public static bool Eliminar(Juego juego)
        {
            bool isOk = false;
            try
            {
                comando.Parameters.Clear();

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.CommandText = $"DELETE FROM juegos WHERE codigo = @codigo";
                comando.Parameters.AddWithValue("@codigo", juego.Codigo);

                comando.ExecuteNonQuery();
                isOk = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return isOk;
        }
    }
}
