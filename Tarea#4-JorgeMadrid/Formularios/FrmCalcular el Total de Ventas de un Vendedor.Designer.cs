namespace Tarea_4_Orientada_a_Objetos.Repaso.Formularios
{
    partial class FrmCalcular_el_Total_de_Ventas_de_un_Vendedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtRuta = new System.Windows.Forms.TextBox();
            this.TxtVenta = new System.Windows.Forms.TextBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvDatosVenta = new System.Windows.Forms.DataGridView();
            this.DgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtTotalVta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(146, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular Las Ventas de un Vendedor:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la Persona:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ruta de Trabajo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingresar La Venta: ";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(224, 103);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(265, 27);
            this.TxtNombre.TabIndex = 5;
            // 
            // TxtRuta
            // 
            this.TxtRuta.Location = new System.Drawing.Point(224, 148);
            this.TxtRuta.Name = "TxtRuta";
            this.TxtRuta.Size = new System.Drawing.Size(196, 27);
            this.TxtRuta.TabIndex = 6;
            // 
            // TxtVenta
            // 
            this.TxtVenta.Location = new System.Drawing.Point(224, 237);
            this.TxtVenta.Name = "TxtVenta";
            this.TxtVenta.Size = new System.Drawing.Size(128, 27);
            this.TxtVenta.TabIndex = 7;
            this.TxtVenta.TextChanged += new System.EventHandler(this.TxtVenta_TextChanged);
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFecha.Location = new System.Drawing.Point(224, 198);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(128, 27);
            this.DtpFecha.TabIndex = 8;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Silver;
            this.BtnAgregar.Location = new System.Drawing.Point(388, 190);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(123, 35);
            this.BtnAgregar.TabIndex = 9;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Aqua;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(110, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "DATOS REGISTRADOS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvDatosVenta
            // 
            this.DgvDatosVenta.AllowUserToAddRows = false;
            this.DgvDatosVenta.AllowUserToDeleteRows = false;
            this.DgvDatosVenta.AllowUserToResizeColumns = false;
            this.DgvDatosVenta.AllowUserToResizeRows = false;
            this.DgvDatosVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDatosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvDatosVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DgvDatosVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvDatosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvNombre,
            this.DgvRuta,
            this.DgvFecha,
            this.DgvVentas});
            this.DgvDatosVenta.Location = new System.Drawing.Point(12, 334);
            this.DgvDatosVenta.Name = "DgvDatosVenta";
            this.DgvDatosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatosVenta.Size = new System.Drawing.Size(512, 284);
            this.DgvDatosVenta.TabIndex = 12;
            // 
            // DgvNombre
            // 
            this.DgvNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DgvNombre.FillWeight = 80F;
            this.DgvNombre.Frozen = true;
            this.DgvNombre.HeaderText = " Vendedor";
            this.DgvNombre.MinimumWidth = 10;
            this.DgvNombre.Name = "DgvNombre";
            this.DgvNombre.Width = 120;
            // 
            // DgvRuta
            // 
            this.DgvRuta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DgvRuta.FillWeight = 80F;
            this.DgvRuta.Frozen = true;
            this.DgvRuta.HeaderText = "Ruta ";
            this.DgvRuta.MinimumWidth = 10;
            this.DgvRuta.Name = "DgvRuta";
            this.DgvRuta.ReadOnly = true;
            this.DgvRuta.Width = 80;
            // 
            // DgvFecha
            // 
            this.DgvFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DgvFecha.FillWeight = 80F;
            this.DgvFecha.Frozen = true;
            this.DgvFecha.HeaderText = "Fecha";
            this.DgvFecha.MinimumWidth = 10;
            this.DgvFecha.Name = "DgvFecha";
            this.DgvFecha.ReadOnly = true;
            this.DgvFecha.Width = 85;
            // 
            // DgvVentas
            // 
            this.DgvVentas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DgvVentas.FillWeight = 80F;
            this.DgvVentas.Frozen = true;
            this.DgvVentas.HeaderText = "Venta";
            this.DgvVentas.MinimumWidth = 10;
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.ReadOnly = true;
            this.DgvVentas.Width = 83;
            // 
            // TxtTotalVta
            // 
            this.TxtTotalVta.Location = new System.Drawing.Point(395, 650);
            this.TxtTotalVta.Name = "TxtTotalVta";
            this.TxtTotalVta.Size = new System.Drawing.Size(128, 27);
            this.TxtTotalVta.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 653);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "El Total de las Ventas es:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.BtnLimpiar.Location = new System.Drawing.Point(388, 233);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(123, 33);
            this.BtnLimpiar.TabIndex = 15;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmCalcular_el_Total_de_Ventas_de_un_Vendedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(538, 694);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtTotalVta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DgvDatosVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.TxtVenta);
            this.Controls.Add(this.TxtRuta);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_el_Total_de_Ventas_de_un_Vendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total de Ventas de un Vendedor";
            this.Load += new System.EventHandler(this.FrmCalcular_el_Total_de_Ventas_de_un_Vendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtRuta;
        private System.Windows.Forms.TextBox TxtVenta;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvDatosVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvVentas;
        private System.Windows.Forms.TextBox TxtTotalVta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}