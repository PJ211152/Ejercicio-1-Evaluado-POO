namespace Ejercicio_1_Evaluado_POO
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
            this.btn_Generar = new System.Windows.Forms.Button();
            this.txb_longitud = new System.Windows.Forms.TextBox();
            this.Nueva = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_Longitud = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Comprobacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Longitud = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Fuerte1 = new System.Windows.Forms.Label();
            this.lbl_Generar = new System.Windows.Forms.Label();
            this.txb_GenContraseña = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Fuerte2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txb_NewContraseña = new System.Windows.Forms.TextBox();
            this.Nueva.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Generar
            // 
            this.btn_Generar.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Generar.FlatAppearance.BorderSize = 0;
            this.btn_Generar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Generar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Generar.ForeColor = System.Drawing.Color.White;
            this.btn_Generar.Location = new System.Drawing.Point(164, 133);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(126, 23);
            this.btn_Generar.TabIndex = 0;
            this.btn_Generar.Text = "Generar Contraseña";
            this.btn_Generar.UseVisualStyleBackColor = false;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // txb_longitud
            // 
            this.txb_longitud.Location = new System.Drawing.Point(141, 66);
            this.txb_longitud.Name = "txb_longitud";
            this.txb_longitud.Size = new System.Drawing.Size(171, 20);
            this.txb_longitud.TabIndex = 1;
            this.txb_longitud.TextChanged += new System.EventHandler(this.txb_contraseña_TextChanged);
            // 
            // Nueva
            // 
            this.Nueva.Controls.Add(this.tabPage1);
            this.Nueva.Controls.Add(this.tabPage2);
            this.Nueva.Controls.Add(this.tabPage3);
            this.Nueva.Location = new System.Drawing.Point(2, 1);
            this.Nueva.Name = "Nueva";
            this.Nueva.SelectedIndex = 0;
            this.Nueva.Size = new System.Drawing.Size(473, 295);
            this.Nueva.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_Longitud);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lbl_Comprobacion);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_Longitud);
            this.tabPage1.Controls.Add(this.txb_longitud);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(465, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cambiar longitud";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lbl_Longitud
            // 
            this.lbl_Longitud.AutoSize = true;
            this.lbl_Longitud.Location = new System.Drawing.Point(339, 253);
            this.lbl_Longitud.Name = "lbl_Longitud";
            this.lbl_Longitud.Size = new System.Drawing.Size(0, 13);
            this.lbl_Longitud.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Longitud por defecto: 8 caracteres";
            // 
            // lbl_Comprobacion
            // 
            this.lbl_Comprobacion.AutoSize = true;
            this.lbl_Comprobacion.Location = new System.Drawing.Point(165, 93);
            this.lbl_Comprobacion.Name = "lbl_Comprobacion";
            this.lbl_Comprobacion.Size = new System.Drawing.Size(0, 13);
            this.lbl_Comprobacion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese la longitud deseada (min:8  max:32)";
            // 
            // btn_Longitud
            // 
            this.btn_Longitud.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Longitud.FlatAppearance.BorderSize = 0;
            this.btn_Longitud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Longitud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Longitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Longitud.ForeColor = System.Drawing.Color.White;
            this.btn_Longitud.Location = new System.Drawing.Point(161, 119);
            this.btn_Longitud.Name = "btn_Longitud";
            this.btn_Longitud.Size = new System.Drawing.Size(126, 23);
            this.btn_Longitud.TabIndex = 3;
            this.btn_Longitud.Text = "Nueva longitud";
            this.btn_Longitud.UseVisualStyleBackColor = false;
            this.btn_Longitud.Click += new System.EventHandler(this.btn_Comprobar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.lbl_Fuerte1);
            this.tabPage2.Controls.Add(this.lbl_Generar);
            this.tabPage2.Controls.Add(this.txb_GenContraseña);
            this.tabPage2.Controls.Add(this.btn_Generar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(465, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generar contraseña";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(164, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Comprobar seguridad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Fuerte1
            // 
            this.lbl_Fuerte1.AutoSize = true;
            this.lbl_Fuerte1.Location = new System.Drawing.Point(168, 47);
            this.lbl_Fuerte1.Name = "lbl_Fuerte1";
            this.lbl_Fuerte1.Size = new System.Drawing.Size(0, 13);
            this.lbl_Fuerte1.TabIndex = 5;
            this.lbl_Fuerte1.Click += new System.EventHandler(this.lbl_Fuerte1_Click);
            // 
            // lbl_Generar
            // 
            this.lbl_Generar.AutoSize = true;
            this.lbl_Generar.Location = new System.Drawing.Point(103, 23);
            this.lbl_Generar.Name = "lbl_Generar";
            this.lbl_Generar.Size = new System.Drawing.Size(268, 13);
            this.lbl_Generar.TabIndex = 4;
            this.lbl_Generar.Text = "Presione generar para asignar una contraseña aleatoria";
            // 
            // txb_GenContraseña
            // 
            this.txb_GenContraseña.Location = new System.Drawing.Point(146, 66);
            this.txb_GenContraseña.Name = "txb_GenContraseña";
            this.txb_GenContraseña.ReadOnly = true;
            this.txb_GenContraseña.Size = new System.Drawing.Size(171, 20);
            this.txb_GenContraseña.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.lbl_Fuerte2);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.txb_NewContraseña);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(465, 269);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Verificar contraseña";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Escriba una contraseña y verifique si es segura";
            // 
            // lbl_Fuerte2
            // 
            this.lbl_Fuerte2.AutoSize = true;
            this.lbl_Fuerte2.Location = new System.Drawing.Point(170, 40);
            this.lbl_Fuerte2.Name = "lbl_Fuerte2";
            this.lbl_Fuerte2.Size = new System.Drawing.Size(0, 13);
            this.lbl_Fuerte2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(170, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Comprobar seguridad";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txb_NewContraseña
            // 
            this.txb_NewContraseña.Location = new System.Drawing.Point(144, 66);
            this.txb_NewContraseña.Name = "txb_NewContraseña";
            this.txb_NewContraseña.Size = new System.Drawing.Size(171, 20);
            this.txb_NewContraseña.TabIndex = 5;
            this.txb_NewContraseña.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(474, 295);
            this.Controls.Add(this.Nueva);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Nueva.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.TextBox txb_longitud;
        private System.Windows.Forms.TabControl Nueva;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Longitud;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txb_GenContraseña;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txb_NewContraseña;
        private System.Windows.Forms.Label lbl_Comprobacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Generar;
        private System.Windows.Forms.Label lbl_Fuerte1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_Fuerte2;
        private System.Windows.Forms.Label lbl_Longitud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

