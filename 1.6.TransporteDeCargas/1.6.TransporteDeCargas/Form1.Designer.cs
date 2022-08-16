namespace _1._6.TransporteDeCargas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCamiones = new System.Windows.Forms.ListBox();
            this.cboTipoCarga = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sa = new System.Windows.Forms.Label();
            this.rbtDisponible = new System.Windows.Forms.RadioButton();
            this.rbtOcupado = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesoMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesoCarga = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCamiones
            // 
            this.lstCamiones.FormattingEnabled = true;
            this.lstCamiones.Location = new System.Drawing.Point(312, 44);
            this.lstCamiones.Name = "lstCamiones";
            this.lstCamiones.Size = new System.Drawing.Size(318, 277);
            this.lstCamiones.TabIndex = 0;
            // 
            // cboTipoCarga
            // 
            this.cboTipoCarga.FormattingEnabled = true;
            this.cboTipoCarga.Location = new System.Drawing.Point(113, 185);
            this.cboTipoCarga.Name = "cboTipoCarga";
            this.cboTipoCarga.Size = new System.Drawing.Size(121, 21);
            this.cboTipoCarga.TabIndex = 1;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(113, 44);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "patente";
            // 
            // sa
            // 
            this.sa.AutoSize = true;
            this.sa.Location = new System.Drawing.Point(48, 96);
            this.sa.Name = "sa";
            this.sa.Size = new System.Drawing.Size(39, 13);
            this.sa.TabIndex = 4;
            this.sa.Text = "estado";
            // 
            // rbtDisponible
            // 
            this.rbtDisponible.AutoSize = true;
            this.rbtDisponible.Location = new System.Drawing.Point(113, 92);
            this.rbtDisponible.Name = "rbtDisponible";
            this.rbtDisponible.Size = new System.Drawing.Size(72, 17);
            this.rbtDisponible.TabIndex = 5;
            this.rbtDisponible.TabStop = true;
            this.rbtDisponible.Text = "disponible";
            this.rbtDisponible.UseVisualStyleBackColor = true;
            // 
            // rbtOcupado
            // 
            this.rbtOcupado.AutoSize = true;
            this.rbtOcupado.Location = new System.Drawing.Point(210, 92);
            this.rbtOcupado.Name = "rbtOcupado";
            this.rbtOcupado.Size = new System.Drawing.Size(67, 17);
            this.rbtOcupado.TabIndex = 6;
            this.rbtOcupado.TabStop = true;
            this.rbtOcupado.Text = "ocupado";
            this.rbtOcupado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "peso maximo";
            // 
            // txtPesoMax
            // 
            this.txtPesoMax.Location = new System.Drawing.Point(113, 136);
            this.txtPesoMax.Name = "txtPesoMax";
            this.txtPesoMax.Size = new System.Drawing.Size(100, 20);
            this.txtPesoMax.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = " tipo de carga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "peso de la carga";
            // 
            // txtPesoCarga
            // 
            this.txtPesoCarga.Location = new System.Drawing.Point(115, 235);
            this.txtPesoCarga.Name = "txtPesoCarga";
            this.txtPesoCarga.Size = new System.Drawing.Size(100, 20);
            this.txtPesoCarga.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(51, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 17;
            this.button5.Text = "nuevo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(555, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 21;
            this.button4.Text = "salir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesoCarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPesoMax);
            this.Controls.Add(this.rbtOcupado);
            this.Controls.Add(this.rbtDisponible);
            this.Controls.Add(this.sa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.cboTipoCarga);
            this.Controls.Add(this.lstCamiones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCamiones;
        private System.Windows.Forms.ComboBox cboTipoCarga;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sa;
        private System.Windows.Forms.RadioButton rbtDisponible;
        private System.Windows.Forms.RadioButton rbtOcupado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesoMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesoCarga;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}

