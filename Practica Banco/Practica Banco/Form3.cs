using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Banco
{
    public partial class Form3 : Form
    {
        Conexion conexion = new Conexion();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string consulta = "insert into cliente(nombre,tel,direccion) values('" +
                textNombre.Text + "'," + textTelefono.Text +",'"+ textDireccion.Text + "')";

            if (conexion.ejecutarQuery(consulta))

            {

                MessageBox.Show("Cliente registrado correctamente");
            }

            Form2 fem = new Form2();
            fem.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
