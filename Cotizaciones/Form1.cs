using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotizaciones
{
    public partial class Form1 : Form
    {
        bool estado;
        string Rol;
        string NombreU;
        int Id;
        int Num;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        string cifrar(string original)
        {
            MD5 cifrador = MD5.Create();
            byte[] entrada = Encoding.UTF8.GetBytes(original);
            byte[] salida = cifrador.ComputeHash(entrada);
            string resultado = BitConverter.ToString(salida).Replace("-", "");
            return resultado;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyecto3DataSet.tblUsuario' Puede moverla o quitarla según sea necesario.
            this.tblUsuarioTableAdapter.Fill(this.proyecto3DataSet.tblUsuario);
            // TODO: esta línea de código carga datos en la tabla 'proyecto3DataSet.tblProductos' Puede moverla o quitarla según sea necesario.
            this.tblProductosTableAdapter.Fill(this.proyecto3DataSet.tblProductos);
            // TODO: esta línea de código carga datos en la tabla 'proyecto3DataSet.tblCotizacion' Puede moverla o quitarla según sea necesario.
            this.tblCotizacionTableAdapter.Fill(this.proyecto3DataSet.tblCotizacion);
            // TODO: esta línea de código carga datos en la tabla 'proyecto3DataSet.ConsultaCotizacionesGeneral' Puede moverla o quitarla según sea necesario.
            this.consultaCotizacionesGeneralTableAdapter.Fill(this.proyecto3DataSet.ConsultaCotizacionesGeneral);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = textBox1.Text;
            string Password = cifrar(textBox2.Text);


            if ((int)tblUsuarioTableAdapter.ObtenerUsuario(Usuario, Password) > 0)
            {
                Id = Convert.ToInt32(tblUsuarioTableAdapter.ObtenerId(Usuario, Password));
                Rol = tblUsuarioTableAdapter.ObtenerRol(Id).ToString();
                estado = (bool)tblUsuarioTableAdapter.ObtenerEstado(Id);
                NombreU = tblUsuarioTableAdapter.ObtenerNombre(Id).ToString();
                Num = Convert.ToInt32(tblUsuarioTableAdapter.ObtenerNumero(Id));
                Usuario_Activo.UsuarioActivo = new Persona(Usuario, NombreU, Rol, estado, Id, Num);
                this.Name = "login";
                switch (estado)
                {
                    case true:
                        if (Rol == "Administrativo")
                        {

                            Principal nuevo = new Principal();
                            nuevo.Show();
                            this.Hide();
                        }
                        else
                        {

                            Principal1 nuevo = new Principal1();
                            nuevo.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        MessageBox.Show("Su usuario está deshabilitado");
                        break;
                }
                textBox1.Text = "";
                textBox2.Text = "";

            }
            else
            {
                MessageBox.Show("!ERROR¡ \r\n Credenciales incorrectas, vuealva a intentarlo");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
