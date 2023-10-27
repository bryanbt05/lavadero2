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

namespace lavadero2
{
    public partial class principal : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=lavadero; Uid=root; Pwd='';");
        
        private Form newpag;

        public principal()
        {
            InitializeComponent();
        }
        private void principal_Load(object sender, EventArgs e)
        {
            logo_Click(null, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            submenu.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            newpagina1(new tabla());
            submenu.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            submenu.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            submenu.Visible = false;
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {
            submenu.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            registro inicio = new registro();
            inicio.Show();
            this.Close();
        }

        private void newpagina1(Form pag)
        {
            if (newpag != null)
            {
                newpag.Hide();
            }
            newpag = pag;
            pag.TopLevel = false;
            pag.FormBorderStyle = FormBorderStyle.None;
            pag.Dock = DockStyle.Fill;
            this.container.Controls.Add(pag);
            this.container.Tag = pag;
            pag.BringToFront();
            pag.Show();          

        }

        private void vehiculo_Click(object sender, EventArgs e)
        {
            newpagina1(new Form1 ());
        }

        private void servicios_Click(object sender, EventArgs e)
        {
            newpagina1(new Form2());
        }

        private void logo_Click(object sender, EventArgs e)
        {
            if (newpag != null)
            {
                newpag.Hide();
            }
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
           lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
           lblfecha.Text = DateTime.Now.ToString("dd/MMM/yyy");
        }
    }
}
