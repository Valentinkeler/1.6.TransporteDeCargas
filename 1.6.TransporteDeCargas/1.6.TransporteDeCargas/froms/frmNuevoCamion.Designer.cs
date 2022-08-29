namespace _1._6.TransporteDeCargas
{
    partial class frmNuevoCamion
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
            this.cboTipoCarga = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesoMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesoCarga = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvCargas = new System.Windows.Forms.DataGridView();
            this.tx = new System.Windows.Forms.Button();
            this.pesot = new System.Windows.Forms.Label();
            this.txtPesoTotal = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipoCarga
            // 
            this.cboTipoCarga.FormattingEnabled = true;
            this.cboTipoCarga.Location = new System.Drawing.Point(113, 109);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "peso maximo";
            // 
            // txtPesoMax
            // 
            this.txtPesoMax.Location = new System.Drawing.Point(336, 41);
            this.txtPesoMax.Name = "txtPesoMax";
            this.txtPesoMax.Size = new System.Drawing.Size(100, 20);
            this.txtPesoMax.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = " tipo de carga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "peso de la carga";
            // 
            // txtPesoCarga
            // 
            this.txtPesoCarga.Location = new System.Drawing.Point(113, 164);
            this.txtPesoCarga.Name = "txtPesoCarga";
            this.txtPesoCarga.Size = new System.Drawing.Size(100, 20);
            this.txtPesoCarga.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(99, 481);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 17;
            this.button5.Text = "nuevo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(465, 472);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 21;
            this.button4.Text = "salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvCargas
            // 
            this.dgvCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colTipoCarga,
            this.ColPeso,
            this.quitar});
            this.dgvCargas.Location = new System.Drawing.Point(99, 235);
            this.dgvCargas.Name = "dgvCargas";
            this.dgvCargas.Size = new System.Drawing.Size(441, 150);
            this.dgvCargas.TabIndex = 22;
            this.dgvCargas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargas_CellContentClick);
            // 
            // tx
            // 
            this.tx.Location = new System.Drawing.Point(272, 133);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(75, 23);
            this.tx.TabIndex = 23;
            this.tx.Text = "agregar";
            this.tx.UseVisualStyleBackColor = true;
            this.tx.Click += new System.EventHandler(this.tx_Click);
            // 
            // pesot
            // 
            this.pesot.AutoSize = true;
            this.pesot.Location = new System.Drawing.Point(380, 419);
            this.pesot.Name = "pesot";
            this.pesot.Size = new System.Drawing.Size(56, 13);
            this.pesot.TabIndex = 24;
            this.pesot.Text = "peso total:";
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Enabled = false;
            this.txtPesoTotal.Location = new System.Drawing.Point(442, 416);
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.Size = new System.Drawing.Size(98, 20);
            this.txtPesoTotal.TabIndex = 25;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // colTipoCarga
            // 
            this.colTipoCarga.HeaderText = "TipoCarga";
            this.colTipoCarga.Name = "colTipoCarga";
            this.colTipoCarga.Width = 150;
            // 
            // ColPeso
            // 
            this.ColPeso.HeaderText = "Peso de la carga";
            this.ColPeso.Name = "ColPeso";
            this.ColPeso.Width = 150;
            // 
            // quitar
            // 
            this.quitar.HeaderText = "quitar";
            this.quitar.Name = "quitar";
            this.quitar.Text = "quitar";
            // 
            // frmNuevoCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 540);
            this.Controls.Add(this.txtPesoTotal);
            this.Controls.Add(this.pesot);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.dgvCargas);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesoCarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPesoMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.cboTipoCarga);
            this.Name = "frmNuevoCamion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboTipoCarga;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesoMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesoCarga;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvCargas;
        private System.Windows.Forms.Button tx;
        private System.Windows.Forms.Label pesot;
        private System.Windows.Forms.TextBox txtPesoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPeso;
        private System.Windows.Forms.DataGridViewButtonColumn quitar;
    }
}

