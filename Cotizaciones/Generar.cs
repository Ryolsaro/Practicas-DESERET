using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones
{
    public static class Usuario_Activo
    {
        public static Persona UsuarioActivo;
    }
    public static class Cotizacion_Cod
    {
        public static Cotizacion CodCotizacion;
    }
    public static class Cotizar_ID_Cot
    {
        public static CotizarID CotizarID;
    }
    public static class Productos_Activos
    {
        public static ProductosActivos Productos;
    }
    public class ProductosActivos
    {
        int ID;
        public ProductosActivos(int ID)
        {
            this.ID = ID;

        }
        public int devolverId()
        {
            return this.ID;
        }
    }
    public class CotizarID
    {
        int ID;
        public CotizarID(int ID)
        {
            this.ID = ID;
        }
        public int devolverID()
        {
            return this.ID;
        }
    }
    public class Cotizacion
    {
        string Codigo;
        public Cotizacion(string c)
        {
            this.Codigo = c;
        }
        public string devolverCodigo()
        {
            return this.Codigo;
        }
    }
    public class Persona
    {
        //atributos
        string Usuario;
        string NombreUsuario;
        string Rol;
        int Id;
        bool Estado;
        int Numero;

        public Persona(string u, string NU, string r, bool Es, int id, int num)
        {
            this.Usuario = u;
            this.NombreUsuario = NU;
            this.Rol = r;
            this.Estado = Es;
            Id = id;
            Numero = num;
        }
        public Persona()
        {

        }
        public string devolverUsuario()
        {
            return this.Usuario;
        }
        public string devolverRol()
        {
            return this.Rol;
        }
        public string devolverNombre()
        {
            return this.NombreUsuario;
        }
        public bool devolverEstado()
        {
            return this.Estado;
        }
        public int devolverId()
        {
            return this.Id;
        }
        public int devolverNum()
        {
            return this.Numero;
        }
    }
}
