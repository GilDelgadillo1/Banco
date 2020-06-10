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
    public partial class Form10 : Form
    {
        Conexion conexion = new Conexion();
        public Form10()
        {
            InitializeComponent();
        }

        private void textCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int id = Convert.ToInt32(textCuenta.Text);
                cargar(id);
            }
        }

        public void cargar(int id)

        {
            dataGridView1.DataSource = conexion.cargarDatos("select cliente.nombre, movimiento.idmovimiento, movimiento.deposito, movimiento.retiro from cliente inner join cuenta on cuenta.idcuenta="+id+" inner join movimiento on cuenta.idCuenta=movimiento.idCuenta where cliente.idcliente=cuenta.idCliente;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
