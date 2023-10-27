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
    public partial class tabla : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=lavadero; Uid=root; Pwd='';");

        public tabla()
        {
            InitializeComponent();
        }
        public void llenar_tabla()
        {
            string consulta = "SELECT factura.fecha, modelo.modelo, version.version, vehiculo.placa, servicio.tp_servicio as servicio, " +
                "usuario.nombre AS lavador FROM modelo INNER JOIN version ON modelo.idmodelo = version.modelo_idmodelo " +
                "INNER JOIN vehiculo ON version.idversion = vehiculo.version_idversion " +
                "INNER JOIN factura ON vehiculo.idvehiculo = factura.vehiculo_idvehiculo " +
                "INNER JOIN servicio_factura ON factura.idfactura = servicio_factura.factura_idfactura " +
                "INNER JOIN precio ON precio.idprecio = servicio_factura.precio_idprecio " +
                "INNER JOIN servicio ON servicio.idservicio = precio.servicio_idservicio " +
                "INNER JOIN usuario_rol ON usuario_rol.idusuario_rol = factura.usuario_rol_idusuario_rol " +
                "INNER JOIN usuario ON usuario.idusuario = usuario_rol.usuario_idusuario " +
                "INNER JOIN rol ON rol.idrol = usuario_rol.rol_idrol;";
            MySqlDataAdapter comconsul = new MySqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            comconsul.Fill(dt);
            tbregistro.DataSource = dt;

        } 

        private void tbregistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmod.Text = tbregistro.CurrentRow.Cells[1].Value.ToString();
                txtvers.Text = tbregistro.CurrentRow.Cells[2].Value.ToString();
                txtplaca.Text = tbregistro.CurrentRow.Cells[3].Value.ToString();
                txtserv.Text = tbregistro.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            llenar_tabla();
        }
    }
}
