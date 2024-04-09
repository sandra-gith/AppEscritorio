namespace AppEscritorio
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnInciar = new System.Windows.Forms.Button();
            this.ingresarDato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(164, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos a mi aplicacion de escritorio, por favor presiona el siguiente boton";
            // 
            // btnInciar
            // 
            this.btnInciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInciar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInciar.ForeColor = System.Drawing.Color.Navy;
            this.btnInciar.Location = new System.Drawing.Point(345, 219);
            this.btnInciar.Name = "btnInciar";
            this.btnInciar.Size = new System.Drawing.Size(128, 52);
            this.btnInciar.TabIndex = 1;
            this.btnInciar.Text = "Iniciar";
            this.btnInciar.UseVisualStyleBackColor = false;
            this.btnInciar.Click += new System.EventHandler(this.btnInciar_Click);
            // 
            // ingresarDato
            // 
            this.ingresarDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarDato.Location = new System.Drawing.Point(323, 181);
            this.ingresarDato.Name = "ingresarDato";
            this.ingresarDato.Size = new System.Drawing.Size(170, 22);
            this.ingresarDato.TabIndex = 2;
            this.ingresarDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ingresarDato.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese su nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingresarDato);
            this.Controls.Add(this.btnInciar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInciar;
        private System.Windows.Forms.TextBox ingresarDato;
        private System.Windows.Forms.Label label2;
    }
}

