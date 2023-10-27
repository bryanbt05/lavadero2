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
    public partial class registro : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=lavadero; Uid=root; Pwd='';");

        public registro()
        {
            InitializeComponent();
        }
        

        public void acceder (string correo, string contrasena)
        {
            conexion.Open();

            MySqlCommand comando = new MySqlCommand("SELECT correo, contrasena FROM usuario WHERE correo=@correo AND contrasena=@contrasena", conexion);
            comando.Parameters.AddWithValue("@correo", txtcorri.Text);
            comando.Parameters.AddWithValue("@contrasena", txtcontrai.Text);

            using (MySqlDataReader Lector = comando.ExecuteReader()) 

            if (Lector.Read())
            {
                //conexion.Close();
                this.Hide();
                txtcorri.Text = "";
                txtcontrai.Text = "";
                principal pantalla = new principal();
                pantalla.Show();

            }
          
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecta");
            }
            conexion.Close();
        }



        private void btniniciar_Click(object sender, EventArgs e)
        {
            acceder(txtcorri.Text, txtcontrai.Text);
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in panel.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.Black;
                }
            }

        }
        private void btnMouseLeave(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in panel.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.White;
                }
            }

        }
        private void txtEnter(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in Preg.Controls)
            {
                if (ctr is Panel && ctr.Name == "P" + tx.Tag.ToString()) 
                {
                    ctr.BackColor = Color.Black;
                }
            }
        }
        private void txtLeave(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in Preg.Controls)
            {
                if (ctr is Panel && ctr.Name == "P" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Silver;
                }
            }
        }
        private void txt1Enter(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in Pini.Controls)
            {
                if (ctr is Panel && ctr.Name == "P" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Black;
                }
            }
        }
        private void txt1Leave(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in Pini.Controls)
            {
                if (ctr is Panel && ctr.Name == "P" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Silver;
                }
            }
        }

        private bool ControlTimer = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (container1.Left < 420 && !ControlTimer)
            {
                container1.Left += 10;
                Preg.BringToFront();
                if (container1.Left == 420)
                {
                    timer1.Stop();
                    ControlTimer = true;
                }
            }
            else if (container1.Left > 0 && ControlTimer)
            {
                container1.Left -= 10;
                Pini.BringToFront();
                if (container1.Left == 0)
                {
                    timer1.Stop();
                    ControlTimer = false;
                }
            }
        }
     
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            string nombre = txtnom.Text;
            string apellido = txtapell.Text;
            string documento = txtdni.Text;
            string correo = txtcorr.Text;
            string contrasena = txtcontra.Text;
            string telefono = txtell.Text;
            string direccion = txtdirec.Text;
            if (nombre == "" || apellido == "" || documento == "" || correo == "" || contrasena == "")
            {
                MessageBox.Show("No deben haber campos vacios");
                return;
            }
            conexion.Open();
            string cdaselect = "SELECT documento, correo, contrasena FROM usuario WHERE documento =  @documento OR correo = @correo OR contrasena = @contrasena";                                         
            MySqlCommand comselect = new MySqlCommand(cdaselect, conexion);
            comselect.Parameters.AddWithValue("@documento", documento);
            comselect.Parameters.AddWithValue("@correo", correo);
            comselect.Parameters.AddWithValue("@contrasena", contrasena);
            MySqlDataReader select = comselect.ExecuteReader();

            if (select.Read())
            {
                MessageBox.Show("El usuario ya existe");
                conexion.Close();
                return;
            }
            conexion.Close();
            conexion.Open();

            string cdainsert = "INSERT INTO usuario(nombre, apellido, documento, correo, contrasena, telefono, direccion) values ('" + nombre + "','" + apellido + "','" + documento + "','" + correo + "','" + contrasena + "','" + telefono + "','" + direccion + "')";
            MySqlCommand cominsert = new MySqlCommand(cdainsert, conexion);
            cominsert.ExecuteNonQuery();

            MessageBox.Show("Los datos se guardaron correctamente");

            txtnom.Text = "";
            txtapell.Text = "";
            txtdni.Text = "";
            txtcorr.Text = "";
            txtcontra.Text = "";
            txtell.Text = "";
            txtdirec.Text = "";

            conexion.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

