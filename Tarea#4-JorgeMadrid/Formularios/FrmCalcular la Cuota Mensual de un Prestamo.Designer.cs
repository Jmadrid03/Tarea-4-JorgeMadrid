namespace Tarea_4_Orientada_a_Objetos.Repaso.Formularios
{
    partial class FrmCalcular_la_Cuota_Mensual_de_un_Prestamo
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
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtPrestamo = new System.Windows.Forms.TextBox();
            this.TxtPlazo = new System.Windows.Forms.TextBox();
            this.TxtTasaA = new System.Windows.Forms.TextBox();
            this.TxtCuota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(155, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular la Cuota Mensual de un Prestamo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar la Cantidad del Prestamo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar el Plazo del Prestamo en años:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresar la Tasa de Interes Anual:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.Silver;
            this.BtnCalcular.Location = new System.Drawing.Point(153, 260);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(111, 40);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtPrestamo
            // 
            this.TxtPrestamo.Location = new System.Drawing.Point(393, 137);
            this.TxtPrestamo.Name = "TxtPrestamo";
            this.TxtPrestamo.Size = new System.Drawing.Size(119, 27);
            this.TxtPrestamo.TabIndex = 5;
            // 
            // TxtPlazo
            // 
            this.TxtPlazo.Location = new System.Drawing.Point(393, 178);
            this.TxtPlazo.Name = "TxtPlazo";
            this.TxtPlazo.Size = new System.Drawing.Size(119, 27);
            this.TxtPlazo.TabIndex = 6;
            // 
            // TxtTasaA
            // 
            this.TxtTasaA.Location = new System.Drawing.Point(393, 217);
            this.TxtTasaA.Name = "TxtTasaA";
            this.TxtTasaA.Size = new System.Drawing.Size(119, 27);
            this.TxtTasaA.TabIndex = 7;
            // 
            // TxtCuota
            // 
            this.TxtCuota.Location = new System.Drawing.Point(393, 316);
            this.TxtCuota.Name = "TxtCuota";
            this.TxtCuota.Size = new System.Drawing.Size(119, 27);
            this.TxtCuota.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Las Cuotas a Pagar del Prestamo es:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.BtnLimpiar.Location = new System.Drawing.Point(434, 384);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(111, 30);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmCalcular_la_Cuota_Mensual_de_un_Prestamo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(557, 426);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtCuota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTasaA);
            this.Controls.Add(this.TxtPlazo);
            this.Controls.Add(this.TxtPrestamo);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_la_Cuota_Mensual_de_un_Prestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuota Mensual de un Prestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtPrestamo;
        private System.Windows.Forms.TextBox TxtPlazo;
        private System.Windows.Forms.TextBox TxtTasaA;
        private System.Windows.Forms.TextBox TxtCuota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}