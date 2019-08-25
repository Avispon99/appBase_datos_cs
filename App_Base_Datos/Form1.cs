using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace App_Base_Datos
{
    public partial class Form1 : Form
    {
        Conexion con = new Conexion(); // instanciando la calse conexion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Conexion con = new Conexion();
            con.CargarBase(dataGrid); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {   
            MessageBox.Show(con.insertar(documento.Text, nombres.Text, telefono.Text, carg.Text, correo.Text, perf.Text, usu.Text, clav.Text, est.Text));
            con.CargarBase(dataGrid);

        }
    }
    
}
