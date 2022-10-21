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
    public partial class frmBienvenida : Form
    {
        //declaramos dos variables globales para almacenar el nombre
        // y el epais de procedencia del usuario.
        //acceso: publicas, tipo: string, nombre.
        public string UserName;
        public string Country;

        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            if (txtMonto.Text!="")
            {
                gbMonedas.Enabled = true;
            }
            else
            {
                gbMonedas.Enabled = false;
                btnCambio.Enabled = false;
            }
        }

        private void rbDolar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDolar.Checked==true)
            {
                lblTcambio.Text = "La Tasa de Cambio del Dólar es: $ 35.95";
                btnCambio.Enabled = true;
            }
        }

        private void rbEuro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEuro.Checked == true)
            {
                lblTcambio.Text = "La Tasa de Cambio del Euro es: € 36.12";
                btnCambio.Enabled = true;
            }
        }

        private void rbColon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbColon.Checked == true)
            {
                lblTcambio.Text = "La Tasa de Cambio del Colón es: ₡ 0.055";
                btnCambio.Enabled = true;
            }
        }

        private void rbYen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYen.Checked == true)
            {
                lblTcambio.Text = "La Tasa de Cambio del Yen es: ¥ 0.26";
                btnCambio.Enabled = true;
            }
        }

        private void rbLibra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLibra.Checked == true)
            {
                lblTcambio.Text = "La Tasa de Cambio del Libra es: £ 42.52";
                btnCambio.Enabled = true;
            }
        }

        private void rbSol_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSol.Checked == true)
            {
                lblTcambio.Text = "La Tasa de Cambio del Sol es: S/ 9.359";
                btnCambio.Enabled = true;
            }
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            float resultado;
            float monto;
            if (txtMonto.Text!="")
            {
                if (rbDolar.Checked == true)
                {
                    float dolar = 35.95F;
                    monto = Convert.ToSingle(txtMonto.Text);
                    resultado = (monto * dolar);
                    txtResultado.Text = "C$: " + resultado;
                }
                else if (rbEuro.Checked == true)
                {
                    float euro = 36.12F;
                    monto = Convert.ToSingle(txtMonto.Text);
                    resultado = (monto * euro);
                    txtResultado.Text = "C$: " + resultado;
                }
                else if (rbColon.Checked == true)
                {
                    float colon = 0.025F;
                    monto = Convert.ToSingle(txtMonto.Text);
                    resultado = (monto * colon);
                    txtResultado.Text = "C$: " + resultado;
                }
                else if (rbYen.Checked == true)
                {
                    float yen = 0.26F;
                    monto = Convert.ToSingle(txtMonto.Text);
                    resultado = (monto * yen);
                    txtResultado.Text = "C$: " + resultado;

                }
                else if (rbLibra.Checked == true)
                {
                    float Libra = 42.52F;
                    monto = Convert.ToSingle(txtMonto.Text);
                    resultado = (monto * Libra);
                    txtResultado.Text = "C$: " + resultado;
                }
                else if (rbSol.Checked == true)
                {
                    float sol = 9.359F;
                    monto = Convert.ToSingle(txtMonto.Text);
                    resultado = (monto * sol);
                    txtResultado.Text = "C$: " + resultado;
                }
                else
                {
                    txtResultado.Text = "C$ 0.00";
                }
            }
            btnLimpiar.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }

        public void LimpiarPantalla()
        {
            txtMonto.Text = "";
            rbDolar.Checked = false;
            rbEuro.Checked = false;
            rbColon.Checked = false;
            rbYen.Checked = false;
            rbLibra.Checked = false;
            rbSol.Checked = false;
            lblTcambio.Text = "La Tasa de Cambio del ___ es: ";
            gbMonedas.Enabled = false;
            btnCambio.Enabled = false;
            txtResultado.Text = "C$ 0.00";
            txtMonto.Focus();
            btnLimpiar.Visible = false;
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            lblnombre.Text = "Nombre: " + UserName.ToUpper();
            lblpais.Text = "País: " + Country;
        }
    }
}
