namespace Tarea_4_Orientada_a_Objetos.Repaso.Formularios
{
    partial class FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento
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
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtSalarioE = new System.Windows.Forms.TextBox();
            this.TxtAumentoS = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(129, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular el Salario Tomando en Cuenta un aumento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar el Salario del Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar el Porcentaje de Aumento:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(116, 180);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(112, 32);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtSalarioE
            // 
            this.TxtSalarioE.Location = new System.Drawing.Point(361, 102);
            this.TxtSalarioE.Name = "TxtSalarioE";
            this.TxtSalarioE.Size = new System.Drawing.Size(109, 27);
            this.TxtSalarioE.TabIndex = 4;
            this.TxtSalarioE.TextChanged += new System.EventHandler(this.TxtSalarioE_TextChanged);
            // 
            // TxtAumentoS
            // 
            this.TxtAumentoS.Location = new System.Drawing.Point(361, 138);
            this.TxtAumentoS.Name = "TxtAumentoS";
            this.TxtAumentoS.Size = new System.Drawing.Size(109, 27);
            this.TxtAumentoS.TabIndex = 5;
            this.TxtAumentoS.TextChanged += new System.EventHandler(this.TxtAumentoS_TextChanged);
            // 
            // TxtResultado
            // 
            this.TxtResultado.BackColor = System.Drawing.Color.White;
            this.TxtResultado.Location = new System.Drawing.Point(358, 230);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(109, 27);
            this.TxtResultado.TabIndex = 8;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(397, 274);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(103, 29);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "El Salario Neto del Empleado es:";
            // 
            // FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(512, 315);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAumentoS);
            this.Controls.Add(this.TxtSalarioE);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salario de un Empleado Tomando un Aumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtSalarioE;
        private System.Windows.Forms.TextBox TxtAumentoS;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label4;
    }
}