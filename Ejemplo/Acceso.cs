using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
            txtnombreuser.Focus();
            cbPaises.Text = "---Paises---";
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            cbPaises.Items.Add("EE.UU");
            cbPaises.Items.Add("ESPAÑA");
            cbPaises.Items.Add("COSTA RICA");
            cbPaises.Items.Add("CHINA");
            cbPaises.Items.Add("INGLATERRA");
            cbPaises.Items.Add("ECUADOR");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r=  MessageBox.Show("Esta seguro que Desea Salir de la Aplicación???", "Estimado Usuario", MessageBoxButtons.YesNo);

            if (r==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtnombreuser.Focus();
            }
        }

        private void btnaccesar_Click(object sender, EventArgs e)
        {
            if (txtnombreuser.Text != string.Empty)
            {
                if (cbPaises.SelectedIndex > 0)
                {
                    //crear un objeto de la clases 'formulario de trabajo'
                    frmBienvenida obj = new frmBienvenida();
                    obj.UserName = Convert.ToString(txtnombreuser.Text);
                    obj.Country = Convert.ToString(cbPaises.Text);
                    obj.Show(); //mostramos el formulario para realizar los cálculos
                    this.Hide(); //ocultamos el formulario para acceso
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar al menos un País", "Estimado Usuario", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                MessageBox.Show("Al pareceer se ha olvidado de Ingresar su Nombre", "Estimado Usuario", MessageBoxButtons.OKCancel);
            }
        }
    }
}
