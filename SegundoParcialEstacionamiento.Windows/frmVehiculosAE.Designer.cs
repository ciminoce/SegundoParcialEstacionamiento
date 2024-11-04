namespace SegundoParcialEstacionamiento.Windows
{
    partial class frmVehiculosAE
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
            label1 = new Label();
            txtPatente = new TextBox();
            label2 = new Label();
            cboTipoVehiculo = new ComboBox();
            label3 = new Label();
            txtMarca = new TextBox();
            label4 = new Label();
            txtModelo = new TextBox();
            label5 = new Label();
            nudCilindrada = new NumericUpDown();
            label6 = new Label();
            nudCarga = new NumericUpDown();
            label7 = new Label();
            cboColores = new ComboBox();
            btnOK = new Button();
            btnCancelar = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCilindrada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCarga).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 37);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Patente:";
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(148, 34);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 74);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 0;
            label2.Text = "Tipo Vehículo:";
            // 
            // cboTipoVehiculo
            // 
            cboTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoVehiculo.FormattingEnabled = true;
            cboTipoVehiculo.Location = new Point(148, 71);
            cboTipoVehiculo.Name = "cboTipoVehiculo";
            cboTipoVehiculo.Size = new Size(121, 23);
            cboTipoVehiculo.TabIndex = 2;
            cboTipoVehiculo.SelectedIndexChanged += cboTipoVehiculo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 113);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 0;
            label3.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(148, 110);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(192, 23);
            txtMarca.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 151);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 0;
            label4.Text = "Modelo:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(148, 148);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(192, 23);
            txtModelo.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 198);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 0;
            label5.Text = "Cilindrada:";
            
            // 
            // nudCilindrada
            // 
            nudCilindrada.Location = new Point(149, 196);
            nudCilindrada.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudCilindrada.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            nudCilindrada.Name = "nudCilindrada";
            nudCilindrada.Size = new Size(120, 23);
            nudCilindrada.TabIndex = 3;
            nudCilindrada.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 241);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 0;
            label6.Text = "Carga:";
            
            // 
            // nudCarga
            // 
            nudCarga.Location = new Point(149, 239);
            nudCarga.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCarga.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            nudCarga.Name = "nudCarga";
            nudCarga.Size = new Size(120, 23);
            nudCarga.TabIndex = 3;
            nudCarga.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 281);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 0;
            label7.Text = "Color:";
            
            // 
            // cboColores
            // 
            cboColores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColores.FormattingEnabled = true;
            cboColores.Location = new Point(149, 278);
            cboColores.Name = "cboColores";
            cboColores.Size = new Size(121, 23);
            cboColores.TabIndex = 2;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(62, 330);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 57);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(275, 330);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 57);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(275, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 31);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmVehiculosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 409);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(nudCarga);
            Controls.Add(nudCilindrada);
            Controls.Add(cboColores);
            Controls.Add(cboTipoVehiculo);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPatente);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(423, 448);
            MinimumSize = new Size(423, 448);
            Name = "frmVehiculosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVehiculosAE";
            Load += frmVehiculosAE_Load;
            ((System.ComponentModel.ISupportInitialize)nudCilindrada).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPatente;
        private Label label2;
        private ComboBox cboTipoVehiculo;
        private Label label3;
        private TextBox txtMarca;
        private Label label4;
        private TextBox txtModelo;
        private Label label5;
        private NumericUpDown nudCilindrada;
        private Label label6;
        private NumericUpDown nudCarga;
        private Label label7;
        private ComboBox cboColores;
        private Button btnOK;
        private Button btnCancelar;
        private Button btnBuscar;
    }
}