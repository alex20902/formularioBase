namespace formularioBase
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
            this.labelSaludo = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelMaterno = new System.Windows.Forms.Label();
            this.labelPaterno = new System.Windows.Forms.Label();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSaludo
            // 
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.Location = new System.Drawing.Point(80, 90);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(38, 13);
            this.labelSaludo.TabIndex = 0;
            this.labelSaludo.Text = "saludo";
            this.labelSaludo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Location = new System.Drawing.Point(233, 90);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(34, 13);
            this.labelCargo.TabIndex = 1;
            this.labelCargo.Text = "cargo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(370, 90);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(42, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "nombre";
            // 
            // labelMaterno
            // 
            this.labelMaterno.AutoSize = true;
            this.labelMaterno.Location = new System.Drawing.Point(669, 90);
            this.labelMaterno.Name = "labelMaterno";
            this.labelMaterno.Size = new System.Drawing.Size(45, 13);
            this.labelMaterno.TabIndex = 3;
            this.labelMaterno.Text = "materno";
            this.labelMaterno.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelPaterno
            // 
            this.labelPaterno.AutoSize = true;
            this.labelPaterno.Location = new System.Drawing.Point(507, 90);
            this.labelPaterno.Name = "labelPaterno";
            this.labelPaterno.Size = new System.Drawing.Size(43, 13);
            this.labelPaterno.TabIndex = 4;
            this.labelPaterno.Text = "paterno";
            this.labelPaterno.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(68, 242);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(87, 56);
            this.btnSaludar.TabIndex = 5;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "saludar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "Saludar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(499, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 53);
            this.button3.TabIndex = 8;
            this.button3.Text = "Saludar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(654, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 52);
            this.button4.TabIndex = 9;
            this.button4.Text = "Saludar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.labelPaterno);
            this.Controls.Add(this.labelMaterno);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelSaludo);
            this.Name = "Form1";
            this.Text = "Base";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelMaterno;
        private System.Windows.Forms.Label labelPaterno;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

