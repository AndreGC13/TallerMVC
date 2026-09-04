using CapaControlador_MVC1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_MVC1
{
    public partial class frmPrincipal : Form
    {
        string nombreTabla = "empleado";
        Controlador controlador = new Controlador();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void actualizarDataGridView()
        {
            DataTable dtVista = controlador.llenarDgv(nombreTabla);
            dgvConsultaTabla.DataSource = dtVista;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            actualizarDataGridView();
        }

    }
}
