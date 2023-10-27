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
    public partial class Form2 : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=lavadero; Uid=root; Pwd='';");

        public Form2()
        {
            InitializeComponent();
            tp_servicio();
            tp_pago();
            lavador();

            txtbuscar.TextChanged += txtbuscar_TextChanged;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void tp_servicio()
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT  idservicio, tp_servicio FROM servicio", conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["tp_servicio"] = "Seleccione un Servicio";
            dt.Rows.InsertAt(fila, 0);

            cboservicio.ValueMember = "idservicio";
            cboservicio.DisplayMember = "tp_servicio";
            cboservicio.DataSource = dt;
        }
        private void cboservicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboservicio.SelectedValue.ToString() != null)
            {
                string idservicio = cboservicio.SelectedValue.ToString();
                precio(idservicio);
            }
        }

        public void precio(string idservicio)
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT idprecio, precio FROM precio WHERE servicio_idservicio = @idservicio", conexion);
            cmd.Parameters.AddWithValue("idservicio", idservicio);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["precio"] = "Seleccione un Precio";
            dt.Rows.InsertAt(fila, 0);

            cboprecio.ValueMember = "idprecio";
            cboprecio.DisplayMember = "precio";
            cboprecio.DataSource = dt;
        }


        private void tp_pago()
        {
            cbopago.DataSource = null;
            cbopago.Items.Clear();
            cbopago.DropDownStyle = ComboBoxStyle.DropDownList;
            conexion.Open();
            string consulta = "SELECT idpago, tp_pago FROM pago";

            try
            {
                MySqlCommand com = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cbopago.ValueMember = "idpago";
                cbopago.DisplayMember = "tp_pago";
                cbopago.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar Datos");
            }
            conexion.Close();
        }

        private void lavador()
        {
            cbolava.DataSource = null;
            cbolava.Items.Clear();
            cbolava.DropDownStyle = ComboBoxStyle.DropDownList;
            conexion.Open();
            string consulta = "SELECT usuario.idusuario, usuario.nombre, usuario.apellido " +
                "FROM usuario INNER JOIN usuario_rol ON usuario.idusuario = usuario_rol.usuario_idusuario " +
                "INNER JOIN rol ON rol.idrol = usuario_rol.rol_idrol WHERE rol_idrol = 5";

            try
            {
                MySqlCommand com = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cbolava.ValueMember = "idusuario";
                cbolava.DisplayMember = "nombre";
                cbolava.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar Datos");
            }
            conexion.Close();
        }

        private string eleccion;
        //guardar la seleccion del lavador
        private void cbolava_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbolava.SelectedIndex >= 0)
            {
                // Obten el ID seleccionado de la tabla 2
                int idusuario = Convert.ToInt32(cbolava.SelectedValue);

                // Realiza una consulta para encontrar el ID de la tabla 3 correspondiente
                string con_usuario_rol = "SELECT idplaca FROM placa WHERE idusuario = @idusuario";

                using (MySqlCommand cmd = new MySqlCommand(con_usuario_rol, conexion))
                {
                    cmd.Parameters.AddWithValue("@idusuario ", idusuario);
                    conexion.Close();
                    conexion.Open();

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        eleccion = resultado.ToString();
                    }
                    else
                    {
                        eleccion = null;
                    }
                    conexion.Close();
                }
            }
            else
            {
                eleccion = null;
            }

        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            //using (MySqlConnection conexion = new MySqlConnection(consulta))

            try
            {
                conexion.Open();
                MessageBox.Show(eleccion);
                string consulta = "INSERT INTO placa (fecha,usuario_rol_idusuario_rol) VALUES (@fecha, @eleccion)";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);

                    if (!string.IsNullOrEmpty(eleccion))
                    {
                        int elecc = int.Parse(eleccion);
                        cmd.Parameters.AddWithValue("@eleccion", elecc);
                    }
                    else
                    {
                        // Si eleccion es nulo o vacío, establece el valor del parámetro como DBNull
                        cmd.Parameters.AddWithValue("@eleccion", DBNull.Value);
                    }

                    //cmd.Parameters.AddWithValue("@eleccion", Convert.ToInt32(elecc));
                    //cmd.ExecuteNonQuery();

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    Console.WriteLine("Filas afectadas: " + filasAfectadas);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar la fecha: " + ex.Message);
            }
            conexion.Close();

            string placa = txtbuscar.Text;

            //try
            //{
            //    if (string.IsNullOrEmpty(txtbuscar.Text))
            //    {
            //        MessageBox.Show("No deben haber campos vacios");
            //        //return;
            //    }

            //conexion.Open();
            //string cdaselect = "SELECT placa FROM vehiculo WHERE placa =  @placa2";
            //MySqlCommand comselect = new MySqlCommand(cdaselect, conexion);
            //comselect.Parameters.AddWithValue("@placa2", placa2);
            //MySqlDataReader select = comselect.ExecuteReader();

            //if (select.Read())
            //{
            //    MessageBox.Show("La placa ya existe");
            //    conexion.Close();
            //    //return;
            //}
            //conexion.Close();
            //conexion.Open();

            // consulta

            //string sql = "INSERT INTO factura (vehiculo_idvehiculo) VALUES (@placa)";
            ////INSERT INTO placa(usuario_rol_idusuario_rol) SELECT usuario_rol_id FROM usuario_rol WHERE usuario_id = (SELECT usuario_id FROM usuario WHERE nombre = 'NombreUsuarioDeseado');

            //using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
            //{

            //    // Agrega un parámetro para la elección del ComboBox

            //    cmd.Parameters.AddWithValue("@placa", placa);


            //    // Ejecuta la consulta
            //    cmd.ExecuteNonQuery();
            //}
            //}

            //catch (Exception ex)
            //{
            //    // Maneja las excepciones, por ejemplo, muestra un mensaje de error
            //    Console.WriteLine("Error al insertar en la base de datos: " + ex.Message);
            //}
            //conexion.Close();

            //return placa;
        }

        //private void cbover_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbover.SelectedIndex > 0)
        //    {
        //        // Obtén la selección como un KeyValuePair
        //        KeyValuePair<int, string> seleccion = (KeyValuePair<int, string>)cbover.SelectedItem;
        //        eleccion1 = seleccion.Key.ToString(); // Obtén el ID del tipo de vehiculo
        //    }
        //    else
        //    {
        //        eleccion1 = null;
        //    }
        //}
        //private void btnselec_Click(object sender, EventArgs e)
        //{
        //    string a = GuardarEleccion();
        //    MessageBox.Show("Se ingresaron los datos correctamente");

        //}


        //string placa = txtp.Text;
        //string placa1 = txtp1.Text;


        //if (placa == "" || placa1 == "" )
        //{
        //    MessageBox.Show("No deben haber campos vacios");
        //    return;
        //}
        //conexion.Open();
        //string cdaselect = "SELECT placa FROM vehiculo WHERE placa =  @placa";
        //MySqlCommand comselect = new MySqlCommand(cdaselect, conexion);
        //comselect.Parameters.AddWithValue("@placa", placa1);
        //MySqlDataReader select = comselect.ExecuteReader();

        //if (select.Read())
        //{
        //    MessageBox.Show("La placa ya existe");
        //    conexion.Close();
        //    return;
        //}
        //conexion.Close();
        //conexion.Open();

        //string cdainsert = "INSERT INTO vehiculo(placa) values ('" + placa + "','" + placa1 + "')";
        //MySqlCommand cominsert = new MySqlCommand(cdainsert, conexion);
        //cominsert.ExecuteNonQuery();

        //MessageBox.Show("Los datos se guardaron correctamente");

        //txtp.Text = "";
        //txtp1.Text = "";

        //conexion.Close();


        //barra de busqueda
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            // Filtra las filas del DataGridView en función del texto de búsqueda
            string searchTerm = txtbuscar.Text.ToLower();
            (tbplaca.DataSource as DataTable).DefaultView.RowFilter = string.Format("PLACA LIKE '%{0}%'", searchTerm);
        }

        //inserta la placa en el texbox
        private void tbplaca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbuscar.Text = tbplaca.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error al Insertar");
            }
        }

        //configuracion del datagridview
        private void ConfigurarDataGridView()
        {
            // Configura AutoSizeMode y FillWeight para cada columna
            tbplaca.Columns["placa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tbplaca.Columns["placa"].FillWeight = 20;

            // Asegúrate de que la propiedad AutoSizeColumnsMode esté configurada
            tbplaca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //public void placa()
        //{
        //    conexion.Open();

        //    string consul = "SELECT * FROM vehiculo WHERE ";
        //    MySqlCommand com = new MySqlCommand(consul, conexion);
        //    MySqlDataReader registro = com.ExecuteReader();

        //    cbotpveh.Items.Insert(0, "Seleccione un tipo de vehiculo");

        //    // Seleccionar la palabra agregada por defecto
        //    cbotpveh.SelectedIndex = 0;

        //    while (registro.Read())
        //    {
        //        int id = registro.GetInt32(0);
        //        string nombre = registro.GetString(1);
        //        cbotpveh.Items.Add(new KeyValuePair<int, string>(id, nombre));
        //    }
        //    conexion.Close();
        //}

        //mostrar datos en el datagridview
        private void btnactua_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT placa AS PLACA FROM vehiculo";
            MySqlDataAdapter comconsul = new MySqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            comconsul.Fill(dt);
            tbplaca.DataSource = dt;

            ConfigurarDataGridView();
        }

    }
}




