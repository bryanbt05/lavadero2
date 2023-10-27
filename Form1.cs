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
    public partial class Form1 : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=lavadero; Uid=root; Pwd='';");

        public Form1()
        {
            InitializeComponent();
            marca();
            tp_vehiculo();
            //modelo();
            //version();

        }

        public void marca()
        {
            conexion.Open();

            string cadena = "SELECT * FROM marca";
            MySqlCommand com = new MySqlCommand(cadena, conexion);
            MySqlDataReader registro = com.ExecuteReader();

            cbomarca.Items.Insert(0, "Seleccione una marca");

            // Seleccionar la palabra agregada por defecto
            cbomarca.SelectedIndex = 0;

            while (registro.Read())
            {
                cbomarca.Items.Add(new KeyValuePair<int, string>(registro.GetInt32(0), registro.GetString(1)));
            }
            conexion.Close();
        }


        private void cbomarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbomarca.SelectedIndex > 0)
            {
                // Obtén el valor seleccionado como KeyValuePair
                KeyValuePair<int, string> seleccion = (KeyValuePair<int, string>)cbomarca.SelectedItem;
                int idselec = seleccion.Key;

                modelo(idselec);
            }
        }

        public void modelo(int idmarca)
        {
            conexion.Open();

            string cadena = "SELECT * FROM modelo WHERE marca_idmarca = @idmarca";
            MySqlCommand com = new MySqlCommand(cadena, conexion);
            com.Parameters.AddWithValue("@idmarca", idmarca);

            MySqlDataReader registro = com.ExecuteReader();

            cbomodelo.Items.Clear();
            cbomodelo.Items.Insert(0, "Seleccione un modelo");

            // Seleccionar la palabra agregada por defecto
            cbomodelo.SelectedIndex = 0;

            while (registro.Read())
            {
                cbomodelo.Items.Add(new KeyValuePair<int, string>(registro.GetInt32(0), registro.GetString(1)));
            }
            conexion.Close();
        }
        private void cbomodelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbomodelo.SelectedIndex > 0)
            {
                // Puedes obtener el valor seleccionado de cbomodelo de manera similar si es necesario
                KeyValuePair<int, string> seleccion = (KeyValuePair<int, string>)cbomodelo.SelectedItem;
                int idselec1 = seleccion.Key;

                version(idselec1);
            }
        }

        private void version(int idmodelo)
        {
            conexion.Open();

            string cadena = "SELECT * FROM version WHERE modelo_idmodelo = @idmodelo";
            MySqlCommand com = new MySqlCommand(cadena, conexion);
            com.Parameters.AddWithValue("@idmodelo", idmodelo);

            MySqlDataReader registro = com.ExecuteReader();

            cbover.Items.Clear();
            cbover.Items.Insert(0, "Seleccione un tipo de version");

            // Seleccionar la palabra agregada por defecto
            cbover.SelectedIndex = 0;

            while (registro.Read())
            {
                int id = registro.GetInt32(0);
                string nombre = registro.GetString(1);
                cbover.Items.Add(new KeyValuePair<int, string>(id, nombre));
            }
            conexion.Close();
        }
        private void tp_vehiculo()
        {
            conexion.Open();

            string cadena = "SELECT * FROM tp_vehiculo";
            MySqlCommand com = new MySqlCommand(cadena, conexion);
            MySqlDataReader registro = com.ExecuteReader();

            while (registro.Read())
            {
                int id = registro.GetInt32(0);
                string nombre = registro.GetString(1);
                cbotpveh.Items.Add(new KeyValuePair<int, string>(id, nombre));
            }
            conexion.Close();
        }

        private string eleccion;
        private string eleccion1;
        private string GuardarEleccion()
        {
            string placa = txtp.Text;
            string placa1 = txtp1.Text;
            string placa2 = placa + "-" + placa1;

            try
            {
                if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(placa1))
                {
                    MessageBox.Show("No deben haber campos vacios");
                    //return;
                }

                conexion.Open();
                string cdaselect = "SELECT placa FROM vehiculo WHERE placa =  @placa2";
                MySqlCommand comselect = new MySqlCommand(cdaselect, conexion);
                comselect.Parameters.AddWithValue("@placa2", placa2);
                MySqlDataReader select = comselect.ExecuteReader();

                if (select.Read())
                {
                    MessageBox.Show("La placa ya existe");
                    conexion.Close();
                    //return;
                }
                conexion.Close();
                conexion.Open();

                // consulta
                string sql = "INSERT INTO vehiculo (tp_vehiculo_idtp_vehiculo, version_idversion, placa) VALUES (@eleccion, @eleccion1, @placa2)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                {
                    int elecc = int.Parse(eleccion);
                    int elecc1 = int.Parse(eleccion1);

                    // Agrega un parámetro para la elección del ComboBox
                    cmd.Parameters.AddWithValue("@eleccion", Convert.ToInt32(elecc));
                    cmd.Parameters.AddWithValue("@eleccion1", Convert.ToInt32(elecc1));
                    cmd.Parameters.AddWithValue("@placa2", placa2);


                    // Ejecuta la consulta
                    cmd.ExecuteNonQuery();
                }
            }

            catch (Exception ex)
            {
                // Maneja las excepciones, por ejemplo, muestra un mensaje de error
                Console.WriteLine("Error al insertar en la base de datos: " + ex.Message);
            }
            conexion.Close();
            return placa2;
        }

        private void cbotpveh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotpveh.SelectedIndex > 0)
            {
                // Obtén la selección como un KeyValuePair
                KeyValuePair<int, string> seleccion = (KeyValuePair<int, string>)cbotpveh.SelectedItem;
                eleccion = seleccion.Key.ToString(); // Obtén el ID del tipo de vehiculo
            }
            else
            {
                eleccion = null;
            }
        }
        private void cbover_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbover.SelectedIndex > 0)
            {
                // Obtén la selección como un KeyValuePair
                KeyValuePair<int, string> seleccion = (KeyValuePair<int, string>)cbover.SelectedItem;
                eleccion1 = seleccion.Key.ToString(); // Obtén el ID del tipo de vehiculo
            }
            else
            {
                eleccion1 = null;
            }
        }
        private void btnselec_Click(object sender, EventArgs e)
        {
            string a = GuardarEleccion();
            MessageBox.Show("Se ingresaron los datos correctamente");

        }

        //private void placa ()
        //{
        //    string placa = txtp.Text;
        //    string placa1 = txtp1.Text;  


        //    if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(placa1))
        //    {
        //        MessageBox.Show("No deben haber campos vacios");
        //        return;
        //    }

        //    conexion.Open();
        //    string cdaselect = "SELECT placa FROM vehiculo WHERE placa =  @placa";
        //    MySqlCommand comselect = new MySqlCommand(cdaselect, conexion);
        //    comselect.Parameters.AddWithValue("@placa", placa1);
        //    MySqlDataReader select = comselect.ExecuteReader();

        //    if (select.Read())
        //    {
        //        MessageBox.Show("La placa ya existe");
        //        conexion.Close();
        //        return;
        //    }
        //    conexion.Close();
        //    conexion.Open();

        //    string placa2 = placa + " - " + placa1;

        //    //string cdainsert = "INSERT INTO vehiculo (placa) values ('" + placa2 + "')";
        //    //MySqlCommand cominsert = new MySqlCommand(cdainsert, conexion);
        //    //cominsert.Parameters.AddWithValue("@placa2", placa2);
        //    //cominsert.ExecuteNonQuery();

        //     //Mostrar los datos combinados en un mensaje
        //    MessageBox.Show("Datos combinados: " + placa2);

        //    MessageBox.Show("Los datos se guardaron correctamente");

        //    txtp.Text = "";
        //    txtp1.Text = "";

        //    conexion.Close();
        //}


    }
}