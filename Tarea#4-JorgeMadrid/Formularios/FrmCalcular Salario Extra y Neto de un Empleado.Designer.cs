namespace Tarea_4_Orientada_a_Objetos.Repaso.Formularios
{
    partial class FrmCalcular_Salario_Extra_y_Neto_de_un_Empleado
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
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSalarioB = new System.Windows.Forms.TextBox();
            this.TxtHoraE = new System.Windows.Forms.TextBox();
            this.TxtValorH = new System.Windows.Forms.TextBox();
            this.TxtSalarioN = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(121, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular el Salario Extra y Neto del Empleado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar el Salario Base:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar las Horas Extras:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresar el Valor de la Hora:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.Silver;
            this.BtnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCalcular.Location = new System.Drawing.Point(153, 215);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(130, 48);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "Calcular Salario";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "El Salario Neto del Empleado es de:";
            // 
            // TxtSalarioB
            // 
            this.TxtSalarioB.Location = new System.Drawing.Point(296, 88);
            this.TxtSalarioB.Name = "TxtSalarioB";
            this.TxtSalarioB.Size = new System.Drawing.Size(127, 27);
            this.TxtSalarioB.TabIndex = 8;
            // 
            // TxtHoraE
            // 
            this.TxtHoraE.Location = new System.Drawing.Point(296, 130);
            this.TxtHoraE.Name = "TxtHoraE";
            this.TxtHoraE.Size = new System.Drawing.Size(127, 27);
            this.TxtHoraE.TabIndex = 9;
            // 
            // TxtValorH
            // 
            this.TxtValorH.Location = new System.Drawing.Point(296, 175);
            this.TxtValorH.Name = "TxtValorH";
            this.TxtValorH.Size = new System.Drawing.Size(127, 27);
            this.TxtValorH.TabIndex = 10;
            // 
            // TxtSalarioN
            // 
            this.TxtSalarioN.BackColor = System.Drawing.Color.White;
            this.TxtSalarioN.Location = new System.Drawing.Point(347, 282);
            this.TxtSalarioN.Name = "TxtSalarioN";
            this.TxtSalarioN.ReadOnly = true;
            this.TxtSalarioN.Size = new System.Drawing.Size(127, 27);
            this.TxtSalarioN.TabIndex = 13;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLimpiar.Location = new System.Drawing.Point(397, 339);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(110, 42);
            this.BtnLimpiar.TabIndex = 14;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmCalcular_Salario_Extra_y_Neto_de_un_Empleado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(519, 393);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtSalarioN);
            this.Controls.Add(this.TxtValorH);
            this.Controls.Add(this.TxtHoraE);
            this.Controls.Add(this.TxtSalarioB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_Salario_Extra_y_Neto_de_un_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salario Extra y Neto de un Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSalarioB;
        private System.Windows.Forms.TextBox TxtHoraE;
        private System.Windows.Forms.TextBox TxtValorH;
        private System.Windows.Forms.TextBox TxtSalarioN;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}