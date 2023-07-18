using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuariolog; 
        public Inicio(Usuario objusuario)
        {
            usuariolog = objusuario;
            InitializeComponent();
            string primerNombre = objusuario.Nombre.Split(' ')[0];
            lblName.Text = "Hola " + primerNombre + "!";
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
