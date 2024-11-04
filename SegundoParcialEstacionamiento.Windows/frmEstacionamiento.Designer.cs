namespace SegundoParcialEstacionamiento.Windows
{
    partial class frmEstacionamiento
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
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            colPatente = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colEntrada = new DataGridViewTextBoxColumn();
            colSalida = new DataGridViewTextBoxColumn();
            colEstadia = new DataGridViewTextBoxColumn();
            colImporte = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            btnRetirar = new Button();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnSalir);
            splitContainer1.Panel2.Controls.Add(btnRetirar);
            splitContainer1.Panel2.Controls.Add(btnIngresar);
            splitContainer1.Size = new Size(855, 536);
            splitContainer1.SplitterDistance = 698;
            splitContainer1.TabIndex = 0;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colPatente, colTipo, colEntrada, colSalida, colEstadia, colImporte });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(698, 536);
            dgvDatos.TabIndex = 1;
            // 
            // colPatente
            // 
            colPatente.HeaderText = "Patente";
            colPatente.Name = "colPatente";
            colPatente.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colEntrada
            // 
            colEntrada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEntrada.HeaderText = "Entrada";
            colEntrada.Name = "colEntrada";
            colEntrada.ReadOnly = true;
            // 
            // colSalida
            // 
            colSalida.HeaderText = "Salida";
            colSalida.Name = "colSalida";
            colSalida.ReadOnly = true;
            // 
            // colEstadia
            // 
            colEstadia.HeaderText = "Estadía";
            colEstadia.Name = "colEstadia";
            colEstadia.ReadOnly = true;
            // 
            // colImporte
            // 
            colImporte.HeaderText = "Importe";
            colImporte.Name = "colImporte";
            colImporte.ReadOnly = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(42, 404);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 54);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(42, 117);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(75, 54);
            btnRetirar.TabIndex = 2;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(42, 44);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 54);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // frmEstacionamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 536);
            ControlBox = false;
            Controls.Add(splitContainer1);
            MaximumSize = new Size(871, 575);
            MinimumSize = new Size(871, 575);
            Name = "frmEstacionamiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEstacionamiento";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colPatente;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colEntrada;
        private DataGridViewTextBoxColumn colSalida;
        private DataGridViewTextBoxColumn colEstadia;
        private DataGridViewTextBoxColumn colImporte;
        private Button btnSalir;
        private Button btnRetirar;
        private Button btnIngresar;
    }
}