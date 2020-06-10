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
    public partial class Form5 : Form
    {
        Conexion conexion = new Conexion();
        public Form5()
        {
            InitializeComponent();
            textNombre.Enabled = false;
            textTelefono.Enabled = false;
            textDomicilio.Enabled = false;
        }

        private void textId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int id = Convert.ToInt32(textId.Text);
                textNombre.Enabled = true;
                textTelefono.Enabled = true;
                textDomicilio.Enabled = true;
                cargar(id);
            }
        }

        public void cargar(int id)

        {
            DataTable gil=conexion.cargarDatos("select * from cliente where idCliente=" + id);
            textNombre.Text = gil.Rows[0]["Nombre"].ToString();
            textTelefono.Text= gil.Rows[0]["tel"].ToString();
            textDomicilio.Text= gil.Rows[0]["direccion"].ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string consulta = "update cliente set nombre='"+textNombre.Text +"',tel=" + textTelefono.Text +",direccion='"+textDomicilio.Text+"' where idcliente =" + textId.Text;

            
            if (conexion.ejecutarQuery(consulta))

            {
                MessageBox.Show("Cliente Modificado");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
