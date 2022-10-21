
namespace Ejemplo
{
    partial class frmAcceso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceso));
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblpaisprocedencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombreuser = new System.Windows.Forms.TextBox();
            this.cbPaises = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnaccesar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogin
            // 
            this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
            this.picLogin.Location = new System.Drawing.Point(97, 12);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(128, 110);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 0;
            this.picLogin.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "___________________________________________________";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuario.Location = new System.Drawing.Point(19, 148);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(78, 18);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Nombre:";
            // 
            // lblpaisprocedencia
            // 
            this.lblpaisprocedencia.AutoSize = true;
            this.lblpaisprocedencia.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblpaisprocedencia.Location = new System.Drawing.Point(38, 180);
            this.lblpaisprocedencia.Name = "lblpaisprocedencia";
            this.lblpaisprocedencia.Size = new System.Drawing.Size(58, 18);
            this.lblpaisprocedencia.TabIndex = 2;
            this.lblpaisprocedencia.Text = "País:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "___________________________________________________";
            // 
            // txtnombreuser
            // 
            this.txtnombreuser.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnombreuser.Location = new System.Drawing.Point(97, 145);
            this.txtnombreuser.Name = "txtnombreuser";
            this.txtnombreuser.Size = new System.Drawing.Size(175, 22);
            this.txtnombreuser.TabIndex = 1;
            this.txtnombreuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbPaises
            // 
            this.cbPaises.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPaises.FormattingEnabled = true;
            this.cbPaises.Location = new System.Drawing.Point(97, 175);
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Size = new System.Drawing.Size(175, 24);
            this.cbPaises.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(72, 215);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 29);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnaccesar
            // 
            this.btnaccesar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnaccesar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnaccesar.ForeColor = System.Drawing.Color.White;
            this.btnaccesar.Location = new System.Drawing.Point(162, 215);
            this.btnaccesar.Name = "btnaccesar";
            this.btnaccesar.Size = new System.Drawing.Size(84, 29);
            this.btnaccesar.TabIndex = 4;
            this.btnaccesar.Text = "Ingresar";
            this.btnaccesar.UseVisualStyleBackColor = false;
            this.btnaccesar.Click += new System.EventHandler(this.btnaccesar_Click);
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(297, 250);
            this.Controls.Add(this.btnaccesar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbPaises);
            this.Controls.Add(this.txtnombreuser);
            this.Controls.Add(this.lblpaisprocedencia);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al Sistema";
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblpaisprocedencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombreuser;
        private System.Windows.Forms.ComboBox cbPaises;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnaccesar;
    }
}