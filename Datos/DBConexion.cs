using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class DBConexion
    {
        SqlConnection db = new SqlConnection("server=localhost; database=dbENE; integrated security=true");
        public string pruebaConexion()
        {
            try
            {
                db.Open();
                db.Close();
                return "Conectado";
            }
            catch
            {
                return "No conectado";
            }
        }
        public bool existeUsuario(string usuario)
        {
            SqlCommand cmd = new SqlCommand("ExisteUsuario", db);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Usuario", usuario));
            int n;
            db.Open();
            n = Convert.ToInt32(cmd.ExecuteScalar());
            db.Close();
            if (n == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool loginUsuario(string usuario, string clave)
        {
            SqlCommand cmd = new SqlCommand("LoginUsuario", db);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Usuario", usuario));
            cmd.Parameters.Add(new SqlParameter("@Clave", clave));
            int n;
            db.Open();
            n = Convert.ToInt32(cmd.ExecuteScalar());
            db.Close();
            if (n == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable datosUsuario(string usuario)
        {
            SqlCommand cmd = new SqlCommand("DatosUsuario", db);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Usuario", usuario));
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable tabla = new DataTable();
            db.Open();
            adaptador.SelectCommand = cmd;
            adaptador.Fill(tabla);
            db.Close();
            return tabla;
        }
        public List<string> TipoRequerimiento()
        {
            List<string> lista = new List<string>();
            SqlCommand cmd = new SqlCommand("TipoRequerimiento", db);
            cmd.CommandType = CommandType.StoredProcedure;
            db.Open();
            SqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                string s = lector.GetString(0);
                lista.Add(s);
            }
            db.Close();
            return lista;
        }
        public List<string> PrioridadRequerimiento()
        {
            List<string> lista = new List<string>();
            SqlCommand cmd = new SqlCommand("PrioridadRequerimiento", db);
            cmd.CommandType = CommandType.StoredProcedure;
            db.Open();
            SqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                string s = lector.GetString(0);
                lista.Add(s);
            }
            db.Close();
            return lista;
        }
        public DataTable ListaEncargados()
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("ListaEncargados", db);
            cmd.CommandType = CommandType.StoredProcedure;
            db.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tabla);
            db.Close();
            return tabla;            
        }
        public string IngresarRequerimiento(int solicitante, int encargado, string tipo, string prioridad, string descripcion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("IngresarRequerimiento", db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Solicitante", solicitante));
                cmd.Parameters.Add(new SqlParameter("@Encargado", encargado));
                cmd.Parameters.Add(new SqlParameter("@Tipo", tipo));
                cmd.Parameters.Add(new SqlParameter("@Prioridad", prioridad));
                cmd.Parameters.Add(new SqlParameter("@Descripcion", descripcion));
                int n;
                db.Open();
                n = Convert.ToInt32(cmd.ExecuteNonQuery());
                db.Close();
                switch (prioridad)
                {
                    case "Alta":
                        return "El requerimiento fue ingresado, el plazo para resolverlo es de 3 días";
                    case "Media":
                        return "El requerimiento fue ingresado, el plazo para resolverlo es de 4 días";
                    case "Baja":
                        return "El requerimiento fue ingresado, el plazo para resolverlo es de 5 días";
                    default:
                        return "El requerimiento fue ingresado";
                }
            }
            catch (Exception ex)
            {
                return $"Hubo un problema, cominíquese con el administrador del sistema\nError: {ex}";
            }
        }
        public DataTable ListarRequerimientos(int solicitante, string tipo, string prioridad, string estado)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("ListarRequerimientos", db);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Solicitante", solicitante));
            cmd.Parameters.Add(new SqlParameter("@Tipo", tipo));
            cmd.Parameters.Add(new SqlParameter("@Prioridad", prioridad));
            cmd.Parameters.Add(new SqlParameter("@Estado", estado));
            db.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(tabla);
            db.Close();
            return tabla;
        }
        public string RequerimientoResuelto(int id)
        {
            SqlCommand cmd = new SqlCommand("RequerimientoResuelto", db);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id", id));
            int n;
            db.Open();
            n = Convert.ToInt32(cmd.ExecuteNonQuery());
            db.Close();
            if (n == 1)
            {
                return "Registro actualizado exitósamente";
            }
            else
            {
                return "Hubo un problema con la actualización del registro";
            }
        }
        public string BorrarRequerimiento(int id)
        {
            SqlCommand cmd = new SqlCommand("BorrarRequerimiento", db);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id", id));
            int n;
            db.Open();
            n = Convert.ToInt32(cmd.ExecuteNonQuery());
            db.Close();
            if (n == 1)
            {
                return "Registro eliminado exitósamente";
            }
            else
            {
                return "Hubo un problema con el borrado del registro";
            }
        }
    }
}
