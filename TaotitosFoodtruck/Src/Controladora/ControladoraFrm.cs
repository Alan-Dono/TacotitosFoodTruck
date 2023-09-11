using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using TaotitosFoodtruck.Src.Interfaces;
using TaotitosFoodtruck.Src.Modelo;
using TaotitosFoodtruck.Src.Vista;
using TaotitosFoodtruck.Src.Vista.TomarPedido;


namespace TaotitosFoodtruck.Src.Controladora
{
    public class ControladoraFrm
    {
        #region AtributosFormularios
        private Panel panel1;
        #endregion
        private static ControladoraFrm Instance;
        private ControladoraFrm(){}
        public static ControladoraFrm GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ControladoraFrm();
            }
            return Instance;
        }
        public void AbrirFormHijo(Form frmHijo, Panel panelPrincipal)
        {
            panel1 = panelPrincipal;
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            frmHijo.TopLevel = false;
            frmHijo.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frmHijo);
            panelPrincipal.Tag = frmHijo;
            frmHijo.BringToFront();
            frmHijo.Show();
        }
        public void AbriFormHijo(Form FrmHijo)
        {
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            FrmHijo.TopLevel = false;
            FrmHijo.Dock = DockStyle.Fill;
            panel1.Controls.Add(FrmHijo);
            panel1.Tag = FrmHijo;
            FrmHijo.Show();
        }

        public void AbrirIngredienteCrud(string tipoIngrediente, int id, IFrmEnviable formulario)
        {
            using (FrmCrearIngrediente form = FrmCrearIngrediente.GetInstancia(tipoIngrediente, id))
            {
                //FrmCrearIngrediente form = FrmCrearIngrediente.GetInstancia(tipoIngrediente, id);
                form.FormClosed += (sender, e) =>
                {
                    formulario.FrmClosed(); // Llama al método FormCerrado cuando se cierre el formulario
                };
                form.BringToFront();
                form.ShowDialog();
            }
        }
        public void AbrirIngredienteCrud(string tipoIngrediente, Ingrediente ing, IFrmEnviable formulario)
        {
            using (FrmCrearIngrediente form = FrmCrearIngrediente.GetInstancia(tipoIngrediente, ing, formulario))
            {
                form.FormClosed += (sender, e) =>
                {
                    formulario.FrmClosed(); // Llama al método FormCerrado cuando se cierre el formulario
                };
                form.BringToFront();
                form.ShowDialog();
            }
        }



    }

}

