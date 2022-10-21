
namespace Ejemplo
{
    partial class frmBienvenida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblpais = new System.Windows.Forms.Label();
            this.lbldiv = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMonedas = new System.Windows.Forms.GroupBox();
            this.rbSol = new System.Windows.Forms.RadioButton();
            this.rbColon = new System.Windows.Forms.RadioButton();
            this.lblTcambio = new System.Windows.Forms.Label();
            this.rbLibra = new System.Windows.Forms.RadioButton();
            this.rbYen = new System.Windows.Forms.RadioButton();
            this.rbEuro = new System.Windows.Forms.RadioButton();
            this.rbDolar = new System.Windows.Forms.RadioButton();
            this.btnCambio = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblcreditos = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbMonedas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.Location = new System.Drawing.Point(104, 3);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(404, 27);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Bienvenido a Nuestro Sistema";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnombre.Location = new System.Drawing.Point(104, 29);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(110, 27);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblpais.Location = new System.Drawing.Point(131, 53);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(82, 27);
            this.lblpais.TabIndex = 2;
            this.lblpais.Text = "País:";
            // 
            // lbldiv
            // 
            this.lbldiv.AutoSize = true;
            this.lbldiv.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldiv.Location = new System.Drawing.Point(38, 56);
            this.lbldiv.Name = "lbldiv";
            this.lbldiv.Size = new System.Drawing.Size(586, 27);
            this.lbldiv.TabIndex = 0;
            this.lbldiv.Text = "_________________________________________";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCambio.Location = new System.Drawing.Point(78, 97);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(318, 22);
            this.lblCambio.TabIndex = 2;
            this.lblCambio.Text = "Ingrese el Monto a Cambiar: ";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMonto.Location = new System.Drawing.Point(398, 96);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(194, 22);
            this.txtMonto.TabIndex = 3;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "_________________________________________";
            // 
            // gbMonedas
            // 
            this.gbMonedas.Controls.Add(this.rbSol);
            this.gbMonedas.Controls.Add(this.rbColon);
            this.gbMonedas.Controls.Add(this.lblTcambio);
            this.gbMonedas.Controls.Add(this.rbLibra);
            this.gbMonedas.Controls.Add(this.rbYen);
            this.gbMonedas.Controls.Add(this.rbEuro);
            this.gbMonedas.Controls.Add(this.rbDolar);
            this.gbMonedas.Enabled = false;
            this.gbMonedas.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbMonedas.Location = new System.Drawing.Point(43, 135);
            this.gbMonedas.Name = "gbMonedas";
            this.gbMonedas.Size = new System.Drawing.Size(578, 129);
            this.gbMonedas.TabIndex = 4;
            this.gbMonedas.TabStop = false;
            this.gbMonedas.Text = "Monedas Internacionales";
            // 
            // rbSol
            // 
            this.rbSol.AutoSize = true;
            this.rbSol.Location = new System.Drawing.Point(446, 61);
            this.rbSol.Name = "rbSol";
            this.rbSol.Size = new System.Drawing.Size(56, 22);
            this.rbSol.TabIndex = 0;
            this.rbSol.TabStop = true;
            this.rbSol.Text = "Sol";
            this.rbSol.UseVisualStyleBackColor = true;
            this.rbSol.CheckedChanged += new System.EventHandler(this.rbSol_CheckedChanged);
            // 
            // rbColon
            // 
            this.rbColon.AutoSize = true;
            this.rbColon.Location = new System.Drawing.Point(446, 24);
            this.rbColon.Name = "rbColon";
            this.rbColon.Size = new System.Drawing.Size(76, 22);
            this.rbColon.TabIndex = 0;
            this.rbColon.TabStop = true;
            this.rbColon.Text = "Colón";
            this.rbColon.UseVisualStyleBackColor = true;
            this.rbColon.CheckedChanged += new System.EventHandler(this.rbColon_CheckedChanged);
            // 
            // lblTcambio
            // 
            this.lblTcambio.AutoSize = true;
            this.lblTcambio.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTcambio.Location = new System.Drawing.Point(74, 96);
            this.lblTcambio.Name = "lblTcambio";
            this.lblTcambio.Size = new System.Drawing.Size(340, 22);
            this.lblTcambio.TabIndex = 2;
            this.lblTcambio.Text = "La Tasa de Cambio del ___ es: ";
            // 
            // rbLibra
            // 
            this.rbLibra.AutoSize = true;
            this.rbLibra.Location = new System.Drawing.Point(239, 61);
            this.rbLibra.Name = "rbLibra";
            this.rbLibra.Size = new System.Drawing.Size(76, 22);
            this.rbLibra.TabIndex = 0;
            this.rbLibra.TabStop = true;
            this.rbLibra.Text = "Libra";
            this.rbLibra.UseVisualStyleBackColor = true;
            this.rbLibra.CheckedChanged += new System.EventHandler(this.rbLibra_CheckedChanged);
            // 
            // rbYen
            // 
            this.rbYen.AutoSize = true;
            this.rbYen.Location = new System.Drawing.Point(35, 61);
            this.rbYen.Name = "rbYen";
            this.rbYen.Size = new System.Drawing.Size(56, 22);
            this.rbYen.TabIndex = 0;
            this.rbYen.TabStop = true;
            this.rbYen.Text = "Yen";
            this.rbYen.UseVisualStyleBackColor = true;
            this.rbYen.CheckedChanged += new System.EventHandler(this.rbYen_CheckedChanged);
            // 
            // rbEuro
            // 
            this.rbEuro.AutoSize = true;
            this.rbEuro.Location = new System.Drawing.Point(239, 24);
            this.rbEuro.Name = "rbEuro";
            this.rbEuro.Size = new System.Drawing.Size(66, 22);
            this.rbEuro.TabIndex = 0;
            this.rbEuro.TabStop = true;
            this.rbEuro.Text = "Euro";
            this.rbEuro.UseVisualStyleBackColor = true;
            this.rbEuro.CheckedChanged += new System.EventHandler(this.rbEuro_CheckedChanged);
            // 
            // rbDolar
            // 
            this.rbDolar.AutoSize = true;
            this.rbDolar.Location = new System.Drawing.Point(35, 24);
            this.rbDolar.Name = "rbDolar";
            this.rbDolar.Size = new System.Drawing.Size(76, 22);
            this.rbDolar.TabIndex = 0;
            this.rbDolar.TabStop = true;
            this.rbDolar.Text = "Dólar";
            this.rbDolar.UseVisualStyleBackColor = true;
            this.rbDolar.CheckedChanged += new System.EventHandler(this.rbDolar_CheckedChanged);
            // 
            // btnCambio
            // 
            this.btnCambio.Enabled = false;
            this.btnCambio.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCambio.Location = new System.Drawing.Point(254, 270);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(157, 35);
            this.btnCambio.TabIndex = 5;
            this.btnCambio.Text = "Cambiar";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(104, 311);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(274, 22);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Recibirá la Cantidad de:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(398, 311);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(194, 22);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcreditos
            // 
            this.lblcreditos.AutoSize = true;
            this.lblcreditos.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblcreditos.Location = new System.Drawing.Point(33, 361);
            this.lblcreditos.Name = "lblcreditos";
            this.lblcreditos.Size = new System.Drawing.Size(591, 16);
            this.lblcreditos.TabIndex = 6;
            this.lblcreditos.Text = "Programador: ELiecer Amador, Carrera: T.E.Programación, Fecha: 18/08/2022";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(597, 308);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(25, 28);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "C";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(673, 379);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblcreditos);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.gbMonedas);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblpais);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldiv);
            this.Controls.Add(this.lblMensaje);
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro del Sistema";
            this.Load += new System.EventHandler(this.frmBienvenida_Load);
            this.gbMonedas.ResumeLayout(false);
            this.gbMonedas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblpais;
        private System.Windows.Forms.Label lbldiv;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMonedas;
        private System.Windows.Forms.RadioButton rbSol;
        private System.Windows.Forms.RadioButton rbColon;
        private System.Windows.Forms.Label lblTcambio;
        private System.Windows.Forms.RadioButton rbLibra;
        private System.Windows.Forms.RadioButton rbYen;
        private System.Windows.Forms.RadioButton rbEuro;
        private System.Windows.Forms.RadioButton rbDolar;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblcreditos;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

