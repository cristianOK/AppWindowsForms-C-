namespace AppInterfaz
{
    partial class FormPrestamos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrestamos));
            this.saludo = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnconfirmarsolicitud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMONTO = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboRAZA = new System.Windows.Forms.ComboBox();
            this.comboORIGEN = new System.Windows.Forms.ComboBox();
            this.comboCUOTAS = new System.Windows.Forms.ComboBox();
            this.monto = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelDatos.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.saludo.Location = new System.Drawing.Point(71, 63);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(131, 29);
            this.saludo.TabIndex = 0;
            this.saludo.Text = "Bienvenido ,";
            this.saludo.Click += new System.EventHandler(this.saludo_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.Color.Black;
            this.btnvolver.Location = new System.Drawing.Point(626, 384);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(119, 40);
            this.btnvolver.TabIndex = 1;
            this.btnvolver.Text = "Atras";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnconfirmarsolicitud
            // 
            this.btnconfirmarsolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnconfirmarsolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmarsolicitud.Location = new System.Drawing.Point(313, 349);
            this.btnconfirmarsolicitud.Name = "btnconfirmarsolicitud";
            this.btnconfirmarsolicitud.Size = new System.Drawing.Size(160, 57);
            this.btnconfirmarsolicitud.TabIndex = 2;
            this.btnconfirmarsolicitud.Text = "Confirmar Prestamo";
            this.btnconfirmarsolicitud.UseVisualStyleBackColor = false;
            this.btnconfirmarsolicitud.Click += new System.EventHandler(this.btnconfirmarsolicitud_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(113, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos Personales :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(488, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalles del Prestamo:";
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDatos.Controls.Add(this.comboORIGEN);
            this.panelDatos.Controls.Add(this.comboRAZA);
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.label3);
            this.panelDatos.Location = new System.Drawing.Point(67, 191);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(327, 138);
            this.panelDatos.TabIndex = 5;
            // 
            // panelDetalles
            // 
            this.panelDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDetalles.Controls.Add(this.monto);
            this.panelDetalles.Controls.Add(this.comboCUOTAS);
            this.panelDetalles.Controls.Add(this.label6);
            this.panelDetalles.Controls.Add(this.lblMONTO);
            this.panelDetalles.Location = new System.Drawing.Point(418, 191);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(347, 138);
            this.panelDetalles.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Provincia a Invertir: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ciudad a Invertir: ";
            // 
            // lblMONTO
            // 
            this.lblMONTO.AutoSize = true;
            this.lblMONTO.BackColor = System.Drawing.Color.Maroon;
            this.lblMONTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMONTO.Location = new System.Drawing.Point(3, 24);
            this.lblMONTO.Name = "lblMONTO";
            this.lblMONTO.Size = new System.Drawing.Size(146, 16);
            this.lblMONTO.TabIndex = 0;
            this.lblMONTO.Text = "Monto del Prestamo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cuotas";
            // 
            // comboRAZA
            // 
            this.comboRAZA.BackColor = System.Drawing.Color.White;
            this.comboRAZA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRAZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboRAZA.FormattingEnabled = true;
            this.comboRAZA.Location = new System.Drawing.Point(156, 33);
            this.comboRAZA.Name = "comboRAZA";
            this.comboRAZA.Size = new System.Drawing.Size(156, 21);
            this.comboRAZA.TabIndex = 2;
            // 
            // comboORIGEN
            // 
            this.comboORIGEN.BackColor = System.Drawing.Color.White;
            this.comboORIGEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboORIGEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboORIGEN.FormattingEnabled = true;
            this.comboORIGEN.Location = new System.Drawing.Point(156, 87);
            this.comboORIGEN.Name = "comboORIGEN";
            this.comboORIGEN.Size = new System.Drawing.Size(156, 21);
            this.comboORIGEN.TabIndex = 3;
            // 
            // comboCUOTAS
            // 
            this.comboCUOTAS.BackColor = System.Drawing.Color.White;
            this.comboCUOTAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCUOTAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCUOTAS.FormattingEnabled = true;
            this.comboCUOTAS.Location = new System.Drawing.Point(171, 85);
            this.comboCUOTAS.Name = "comboCUOTAS";
            this.comboCUOTAS.Size = new System.Drawing.Size(156, 21);
            this.comboCUOTAS.TabIndex = 3;
            // 
            // monto
            // 
            this.monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monto.Location = new System.Drawing.Point(171, 21);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(156, 22);
            this.monto.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.panelDetalles);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconfirmarsolicitud);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.FormPrestamos_Load);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnconfirmarsolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.ComboBox comboORIGEN;
        private System.Windows.Forms.ComboBox comboRAZA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.ComboBox comboCUOTAS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMONTO;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}