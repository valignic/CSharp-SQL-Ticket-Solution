using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocio
{
    public class Conciliador
    {
        Datos.DBConexion con = new Datos.DBConexion();
        public DatosUsuario user = new DatosUsuario();
        public string LlamarConexion()
        {
            return con.pruebaConexion();
        }
        public bool VerificarUsuario(string usuario)
        {
            return con.existeUsuario(usuario);
        }
        public bool LoginUsuario(string usuario, string clave)
        {
            return con.loginUsuario(usuario, clave);
        }
        public void IdentificarUsuario(string usuario)
        {
            DataTable dt = new DataTable();
            dt = con.datosUsuario(usuario);
            user.Usuario = usuario;
            user.Id = Convert.ToInt32(dt.Rows[0][0]);
            user.Nombre = Convert.ToString(dt.Rows[0][1]);
            user.Apellido = Convert.ToString(dt.Rows[0][2]);
            user.Area = Convert.ToString(dt.Rows[0][3]);
            user.Acceso = Convert.ToString(dt.Rows[0][4]);
            dt.Clear();
        }
        public List<string> ListaTipoRequerimiento()
        {
            List<string> lista = con.TipoRequerimiento();
            lista.Insert(0, "Todos");
            return lista;
        }
        public List<string> ListaPrioridadRequerimiento()
        {
            List<string> lista = con.PrioridadRequerimiento();
            lista.Insert(0, "Todos");
            return lista;
        }
        public DataTable ListaEncargados()
        {
            DataTable tabla = con.ListaEncargados();
            DataRow fila = tabla.NewRow();
            fila["id"] = 0;
            fila["nombre"] = "Seleccionar";
            tabla.Rows.InsertAt(fila, 0);
            return tabla;
        }
        public string GuardarRequerimiento(int encargado, string tipo, string prioridad, string descripcion)
        {
            return con.IngresarRequerimiento(user.Id, encargado, tipo, prioridad, descripcion);
        }
        public DataTable ListarRequerimientos(string tipo, string prioridad, string estado)
        {
            if (tipo == "Todos")
            {
                tipo = "%";
            }
            if (prioridad == "Todos")
            {
                prioridad = "%";
            }
            return con.ListarRequerimientos(user.Id, tipo, prioridad, estado);
        }
        public string RequerimientoResuelto(int id)
        {
            return con.RequerimientoResuelto(id);
        }
        public string BorrarRequerimiento(int id)
        {
            return con.BorrarRequerimiento(id);
        }
    }
}
