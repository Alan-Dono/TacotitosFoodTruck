using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaotitosFoodtruck.Src.Controladora;
using TaotitosFoodtruck.Src.Interfaces;
using TaotitosFoodtruck.Src.Modelo;

namespace TaotitosFoodtruck.Src.Vista
{
    public partial class FrmCrearIngrediente : Form
    {
        private ControladoraFrm frmController = ControladoraFrm.GetInstance();
        private ControladoraIngredientes contIngrediente = ControladoraIngredientes.GetInstancia();

        #region Instancias
        public static FrmCrearIngrediente GetInstancia(string tipoIngrediente, int id)
        {
            return new FrmCrearIngrediente(tipoIngrediente, id);
        }
        public static FrmCrearIngrediente GetInstancia(string tipoIngrediente, Ingrediente ing, IFrmEnviable formulario)
        {
            return new FrmCrearIngrediente(tipoIngrediente, ing, formulario);
        }
        #endregion

        #region Constructores
        private FrmCrearIngrediente(string tipoIngrediente, int id)
        {
            InitializeComponent();
            lblTipoIngrediente.Text = tipoIngrediente;
            lblIdTipo.Text = Convert.ToString(id);
        }
        private FrmCrearIngrediente(string tipoIngrediente, Ingrediente ingrediente, IFrmEnviable formulario)
        {
            InitializeComponent();
            lblTipoIngrediente.Text = tipoIngrediente;
            lblIdTipo.Text = Convert.ToString(ingrediente.TipoIngredienteID);
            // Cargar los datos del ingrediente en los controles del formulario
            if (ingrediente != null)
            {
                lblIdIngrediente.Text = Convert.ToString(ingrediente.ID);
                txtNombre.Text = ingrediente.Nombre;
                txtDescrpcion.Text = ingrediente.Descripcion;
                txtPrecio.Text = ingrediente.Precio.ToString();
                txtCantidad.Text = ingrediente.CantidadMaxima.ToString();
            }
        }

        #endregion

        #region MoverPantalla
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        private void IconTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esModificacion = !string.IsNullOrEmpty(lblIdIngrediente.Text);

            contIngrediente.AltaModificacionIngrediente(
                lblIdIngrediente.Text,
                txtNombre.Text,
                Convert.ToInt32(lblIdTipo.Text),
                txtDescrpcion.Text,
                Convert.ToDecimal(txtPrecio.Text),
                Convert.ToInt32(txtCantidad.Text),
                esModificacion
            );

            this.Close();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
