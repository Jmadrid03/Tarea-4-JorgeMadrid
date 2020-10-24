namespace Tarea_4_Orientada_a_Objetos.Repaso.Formularios
{
    partial class FrmCalcular_Cuota_Mensual_de_la_Venta_de_Computadora
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
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.RbtContado = new System.Windows.Forms.RadioButton();
            this.RbtCredito = new System.Windows.Forms.RadioButton();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(128, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular La Venta de una Computadora:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decripción de la Computadora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "La Venta Es El :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresar el Precio:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(303, 107);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(143, 27);
            this.TxtDescripcion.TabIndex = 4;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(303, 199);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(143, 27);
            this.TxtPrecio.TabIndex = 5;
            // 
            // RbtContado
            // 
            this.RbtContado.AutoSize = true;
            this.RbtContado.Checked = true;
            this.RbtContado.Location = new System.Drawing.Point(196, 150);
            this.RbtContado.Name = "RbtContado";
            this.RbtContado.Size = new System.Drawing.Size(98, 23);
            this.RbtContado.TabIndex = 6;
            this.RbtContado.TabStop = true;
            this.RbtContado.Text = "Contado";
            this.RbtContado.UseVisualStyleBackColor = true;
            // 
            // RbtCredito
            // 
            this.RbtCredito.AutoSize = true;
            this.RbtCredito.Location = new System.Drawing.Point(318, 150);
            this.RbtCredito.Name = "RbtCredito";
            this.RbtCredito.Size = new System.Drawing.Size(90, 23);
            this.RbtCredito.TabIndex = 7;
            this.RbtCredito.TabStop = true;
            this.RbtCredito.Text = "Crédito";
            this.RbtCredito.UseVisualStyleBackColor = true;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.Silver;
            this.BtnCalcular.Location = new System.Drawing.Point(147, 245);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(108, 36);
            this.BtnCalcular.TabIndex = 8;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.BackColor = System.Drawing.Color.White;
            this.TxtResultado.Location = new System.Drawing.Point(303, 303);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtResultado.Size = new System.Drawing.Size(143, 27);
            this.TxtResultado.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "El Precio Total de la Venta es:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.BtnLimpiar.Location = new System.Drawing.Point(365, 344);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(108, 36);
            this.BtnLimpiar.TabIndex = 11;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // FrmCalcular_Cuota_Mensual_de_la_Venta_de_Computadora
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(485, 392);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.RbtCredito);
            this.Controls.Add(this.RbtContado);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_Cuota_Mensual_de_la_Venta_de_Computadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuota Mensual de la Venta de Computadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.RadioButton RbtContado;
        private System.Windows.Forms.RadioButton RbtCredito;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}