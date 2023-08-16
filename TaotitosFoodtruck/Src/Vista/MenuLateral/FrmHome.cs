using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaotitosFoodtruck.Src.Vista
{
    public partial class FrmHome : Form
    {
        private static FrmHome instance;
        public static FrmHome GetInstancia()
        {
            if (instance == null)
            {
                instance = new FrmHome();
            }
            return instance;
        }
        private FrmHome()
        {
            InitializeComponent();
        }
    }
}
