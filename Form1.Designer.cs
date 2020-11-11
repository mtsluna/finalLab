namespace final
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.prestamos = new System.Windows.Forms.TabPage();
            this.clientes = new System.Windows.Forms.TabPage();
            this.libros = new System.Windows.Forms.TabPage();
            this.administradores = new System.Windows.Forms.TabPage();
            this.autores = new System.Windows.Forms.TabPage();
            this.logout = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.prestamos);
            this.tabControl.Controls.Add(this.libros);
            this.tabControl.Controls.Add(this.clientes);
            this.tabControl.Controls.Add(this.administradores);
            this.tabControl.Controls.Add(this.autores);
            this.tabControl.Location = new System.Drawing.Point(12, 26);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 412);
            this.tabControl.TabIndex = 0;
            // 
            // prestamos
            // 
            this.prestamos.Location = new System.Drawing.Point(4, 25);
            this.prestamos.Name = "prestamos";
            this.prestamos.Padding = new System.Windows.Forms.Padding(3);
            this.prestamos.Size = new System.Drawing.Size(768, 383);
            this.prestamos.TabIndex = 0;
            this.prestamos.Text = "Prestamos";
            this.prestamos.UseVisualStyleBackColor = true;
            // 
            // clientes
            // 
            this.clientes.Location = new System.Drawing.Point(4, 25);
            this.clientes.Name = "clientes";
            this.clientes.Padding = new System.Windows.Forms.Padding(3);
            this.clientes.Size = new System.Drawing.Size(768, 397);
            this.clientes.TabIndex = 1;
            this.clientes.Text = "Clientes";
            this.clientes.UseVisualStyleBackColor = true;
            // 
            // libros
            // 
            this.libros.Location = new System.Drawing.Point(4, 25);
            this.libros.Name = "libros";
            this.libros.Size = new System.Drawing.Size(768, 397);
            this.libros.TabIndex = 2;
            this.libros.Text = "Libros";
            this.libros.UseVisualStyleBackColor = true;
            // 
            // administradores
            // 
            this.administradores.Location = new System.Drawing.Point(4, 25);
            this.administradores.Name = "administradores";
            this.administradores.Size = new System.Drawing.Size(768, 397);
            this.administradores.TabIndex = 3;
            this.administradores.Text = "Administradores";
            this.administradores.UseVisualStyleBackColor = true;
            // 
            // autores
            // 
            this.autores.Location = new System.Drawing.Point(4, 25);
            this.autores.Name = "autores";
            this.autores.Size = new System.Drawing.Size(768, 397);
            this.autores.TabIndex = 4;
            this.autores.Text = "Autores";
            this.autores.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(682, 14);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(101, 27);
            this.logout.TabIndex = 1;
            this.logout.Text = "SALIR";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "BiblioTEC - NOMBRE USUARIO";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage prestamos;
        private System.Windows.Forms.TabPage clientes;
        private System.Windows.Forms.TabPage libros;
        private System.Windows.Forms.TabPage administradores;
        private System.Windows.Forms.TabPage autores;
        private System.Windows.Forms.Button logout;
    }
}

