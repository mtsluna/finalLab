﻿namespace final
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.prestamos = new System.Windows.Forms.TabPage();
            this.libros = new System.Windows.Forms.TabPage();
            this.resetLibro = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.libro0 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.libro8 = new System.Windows.Forms.TextBox();
            this.buscarLibros = new System.Windows.Forms.Button();
            this.buscadorLibros = new System.Windows.Forms.TextBox();
            this.autoresEnLibros = new System.Windows.Forms.ComboBox();
            this.saveLibro = new System.Windows.Forms.Button();
            this.libro7 = new System.Windows.Forms.TextBox();
            this.libro2 = new System.Windows.Forms.TextBox();
            this.libro4 = new System.Windows.Forms.TextBox();
            this.libro3 = new System.Windows.Forms.DateTimePicker();
            this.libro6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.libro1 = new System.Windows.Forms.TextBox();
            this.librosDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clientes = new System.Windows.Forms.TabPage();
            this.administradores = new System.Windows.Forms.TabPage();
            this.autores = new System.Windows.Forms.TabPage();
            this.resetAutor = new System.Windows.Forms.Button();
            this.guardarAutor = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buscarAutor = new System.Windows.Forms.Button();
            this.autor0 = new System.Windows.Forms.TextBox();
            this.buscadorAutor = new System.Windows.Forms.TextBox();
            this.autor2 = new System.Windows.Forms.TextBox();
            this.autoresDataGrid = new System.Windows.Forms.DataGridView();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.autor1 = new System.Windows.Forms.TextBox();
            this.logout = new System.Windows.Forms.Button();
            this.clientesDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buscadorCliente = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.cliente0 = new System.Windows.Forms.TextBox();
            this.cliente6 = new System.Windows.Forms.TextBox();
            this.cliente3 = new System.Windows.Forms.TextBox();
            this.cliente5 = new System.Windows.Forms.DateTimePicker();
            this.cliente2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cliente1 = new System.Windows.Forms.TextBox();
            this.clienteReset = new System.Windows.Forms.Button();
            this.clienteGuardar = new System.Windows.Forms.Button();
            this.cliente4 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.libros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGrid)).BeginInit();
            this.clientes.SuspendLayout();
            this.autores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGrid)).BeginInit();
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
            this.tabControl.Size = new System.Drawing.Size(1430, 412);
            this.tabControl.TabIndex = 0;
            // 
            // prestamos
            // 
            this.prestamos.Location = new System.Drawing.Point(4, 25);
            this.prestamos.Name = "prestamos";
            this.prestamos.Padding = new System.Windows.Forms.Padding(3);
            this.prestamos.Size = new System.Drawing.Size(1422, 383);
            this.prestamos.TabIndex = 0;
            this.prestamos.Text = "Prestamos";
            this.prestamos.UseVisualStyleBackColor = true;
            // 
            // libros
            // 
            this.libros.Controls.Add(this.resetLibro);
            this.libros.Controls.Add(this.label10);
            this.libros.Controls.Add(this.libro0);
            this.libros.Controls.Add(this.label9);
            this.libros.Controls.Add(this.libro8);
            this.libros.Controls.Add(this.buscarLibros);
            this.libros.Controls.Add(this.buscadorLibros);
            this.libros.Controls.Add(this.autoresEnLibros);
            this.libros.Controls.Add(this.saveLibro);
            this.libros.Controls.Add(this.libro7);
            this.libros.Controls.Add(this.libro2);
            this.libros.Controls.Add(this.libro4);
            this.libros.Controls.Add(this.libro3);
            this.libros.Controls.Add(this.libro6);
            this.libros.Controls.Add(this.label8);
            this.libros.Controls.Add(this.label7);
            this.libros.Controls.Add(this.label6);
            this.libros.Controls.Add(this.label5);
            this.libros.Controls.Add(this.label4);
            this.libros.Controls.Add(this.label3);
            this.libros.Controls.Add(this.label2);
            this.libros.Controls.Add(this.label1);
            this.libros.Controls.Add(this.libro1);
            this.libros.Controls.Add(this.librosDataGrid);
            this.libros.Location = new System.Drawing.Point(4, 25);
            this.libros.Name = "libros";
            this.libros.Size = new System.Drawing.Size(1422, 383);
            this.libros.TabIndex = 2;
            this.libros.Text = "Libros";
            this.libros.UseVisualStyleBackColor = true;
            // 
            // resetLibro
            // 
            this.resetLibro.Location = new System.Drawing.Point(1228, 346);
            this.resetLibro.Name = "resetLibro";
            this.resetLibro.Size = new System.Drawing.Size(181, 23);
            this.resetLibro.TabIndex = 25;
            this.resetLibro.Text = "Reset";
            this.resetLibro.UseVisualStyleBackColor = true;
            this.resetLibro.Click += new System.EventHandler(this.resetLibro_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1296, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "ID:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // libro0
            // 
            this.libro0.Enabled = false;
            this.libro0.Location = new System.Drawing.Point(1327, 12);
            this.libro0.Name = "libro0";
            this.libro0.Size = new System.Drawing.Size(82, 22);
            this.libro0.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1036, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "ISBN:";
            // 
            // libro8
            // 
            this.libro8.Location = new System.Drawing.Point(1128, 296);
            this.libro8.Name = "libro8";
            this.libro8.Size = new System.Drawing.Size(281, 22);
            this.libro8.TabIndex = 21;
            // 
            // buscarLibros
            // 
            this.buscarLibros.Location = new System.Drawing.Point(3, 346);
            this.buscarLibros.Name = "buscarLibros";
            this.buscarLibros.Size = new System.Drawing.Size(238, 23);
            this.buscarLibros.TabIndex = 20;
            this.buscarLibros.Text = "Buscar por Titulo";
            this.buscarLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buscarLibros.UseVisualStyleBackColor = true;
            this.buscarLibros.Click += new System.EventHandler(this.buscarLibros_Click);
            // 
            // buscadorLibros
            // 
            this.buscadorLibros.Location = new System.Drawing.Point(247, 346);
            this.buscadorLibros.Name = "buscadorLibros";
            this.buscadorLibros.Size = new System.Drawing.Size(781, 22);
            this.buscadorLibros.TabIndex = 19;
            // 
            // autoresEnLibros
            // 
            this.autoresEnLibros.FormattingEnabled = true;
            this.autoresEnLibros.Location = new System.Drawing.Point(1128, 178);
            this.autoresEnLibros.Name = "autoresEnLibros";
            this.autoresEnLibros.Size = new System.Drawing.Size(281, 24);
            this.autoresEnLibros.TabIndex = 18;
            // 
            // saveLibro
            // 
            this.saveLibro.Location = new System.Drawing.Point(1039, 346);
            this.saveLibro.Name = "saveLibro";
            this.saveLibro.Size = new System.Drawing.Size(181, 23);
            this.saveLibro.TabIndex = 17;
            this.saveLibro.Text = "Guardar";
            this.saveLibro.UseVisualStyleBackColor = true;
            this.saveLibro.Click += new System.EventHandler(this.saveLibro_Click);
            // 
            // libro7
            // 
            this.libro7.Location = new System.Drawing.Point(1301, 219);
            this.libro7.Name = "libro7";
            this.libro7.Size = new System.Drawing.Size(108, 22);
            this.libro7.TabIndex = 16;
            // 
            // libro2
            // 
            this.libro2.Location = new System.Drawing.Point(1184, 258);
            this.libro2.Name = "libro2";
            this.libro2.Size = new System.Drawing.Size(225, 22);
            this.libro2.TabIndex = 15;
            // 
            // libro4
            // 
            this.libro4.Location = new System.Drawing.Point(1128, 219);
            this.libro4.Name = "libro4";
            this.libro4.Size = new System.Drawing.Size(103, 22);
            this.libro4.TabIndex = 14;
            this.libro4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressIsNumber);
            // 
            // libro3
            // 
            this.libro3.Location = new System.Drawing.Point(1128, 137);
            this.libro3.Name = "libro3";
            this.libro3.Size = new System.Drawing.Size(281, 22);
            this.libro3.TabIndex = 13;
            // 
            // libro6
            // 
            this.libro6.Location = new System.Drawing.Point(1128, 95);
            this.libro6.Name = "libro6";
            this.libro6.Size = new System.Drawing.Size(281, 22);
            this.libro6.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1036, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Paginas:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1036, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lugar de Publicacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1036, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1237, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Edicion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1036, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1036, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1036, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1034, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carga de libros";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // libro1
            // 
            this.libro1.Location = new System.Drawing.Point(1128, 54);
            this.libro1.Name = "libro1";
            this.libro1.Size = new System.Drawing.Size(281, 22);
            this.libro1.TabIndex = 1;
            // 
            // librosDataGrid
            // 
            this.librosDataGrid.AllowUserToAddRows = false;
            this.librosDataGrid.AllowUserToDeleteRows = false;
            this.librosDataGrid.AllowUserToOrderColumns = true;
            this.librosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titulo,
            this.lugarPublicacion,
            this.año,
            this.paginas,
            this.autor,
            this.descripcion,
            this.edicion,
            this.isbn,
            this.Editar,
            this.Eliminar});
            this.librosDataGrid.Location = new System.Drawing.Point(3, 3);
            this.librosDataGrid.Name = "librosDataGrid";
            this.librosDataGrid.RowHeadersWidth = 51;
            this.librosDataGrid.RowTemplate.Height = 24;
            this.librosDataGrid.Size = new System.Drawing.Size(1025, 334);
            this.librosDataGrid.TabIndex = 0;
            this.librosDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // titulo
            // 
            this.titulo.DataPropertyName = "titulo";
            this.titulo.HeaderText = "Titulo";
            this.titulo.MinimumWidth = 6;
            this.titulo.Name = "titulo";
            this.titulo.Width = 125;
            // 
            // lugarPublicacion
            // 
            this.lugarPublicacion.DataPropertyName = "lugarPublicacion";
            this.lugarPublicacion.HeaderText = "Lugar Publicacion";
            this.lugarPublicacion.MinimumWidth = 6;
            this.lugarPublicacion.Name = "lugarPublicacion";
            this.lugarPublicacion.Width = 125;
            // 
            // año
            // 
            this.año.DataPropertyName = "año";
            this.año.HeaderText = "Año";
            this.año.MinimumWidth = 6;
            this.año.Name = "año";
            this.año.Width = 125;
            // 
            // paginas
            // 
            this.paginas.DataPropertyName = "paginas";
            this.paginas.HeaderText = "Paginas";
            this.paginas.MinimumWidth = 6;
            this.paginas.Name = "paginas";
            this.paginas.Width = 125;
            // 
            // autor
            // 
            this.autor.DataPropertyName = "fk_autor";
            this.autor.HeaderText = "ID Autor";
            this.autor.MinimumWidth = 6;
            this.autor.Name = "autor";
            this.autor.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 125;
            // 
            // edicion
            // 
            this.edicion.DataPropertyName = "edicion";
            this.edicion.HeaderText = "Edicion";
            this.edicion.MinimumWidth = 6;
            this.edicion.Name = "edicion";
            this.edicion.Width = 125;
            // 
            // isbn
            // 
            this.isbn.DataPropertyName = "isbn";
            this.isbn.HeaderText = "ISBN";
            this.isbn.MinimumWidth = 6;
            this.isbn.Name = "isbn";
            this.isbn.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 125;
            // 
            // clientes
            // 
            this.clientes.Controls.Add(this.cliente4);
            this.clientes.Controls.Add(this.clienteReset);
            this.clientes.Controls.Add(this.clienteGuardar);
            this.clientes.Controls.Add(this.label13);
            this.clientes.Controls.Add(this.cliente0);
            this.clientes.Controls.Add(this.cliente6);
            this.clientes.Controls.Add(this.cliente3);
            this.clientes.Controls.Add(this.cliente5);
            this.clientes.Controls.Add(this.cliente2);
            this.clientes.Controls.Add(this.label16);
            this.clientes.Controls.Add(this.label17);
            this.clientes.Controls.Add(this.label18);
            this.clientes.Controls.Add(this.label20);
            this.clientes.Controls.Add(this.label21);
            this.clientes.Controls.Add(this.label22);
            this.clientes.Controls.Add(this.label23);
            this.clientes.Controls.Add(this.cliente1);
            this.clientes.Controls.Add(this.button1);
            this.clientes.Controls.Add(this.buscadorCliente);
            this.clientes.Controls.Add(this.clientesDataGrid);
            this.clientes.Location = new System.Drawing.Point(4, 25);
            this.clientes.Name = "clientes";
            this.clientes.Padding = new System.Windows.Forms.Padding(3);
            this.clientes.Size = new System.Drawing.Size(1422, 383);
            this.clientes.TabIndex = 1;
            this.clientes.Text = "Clientes";
            this.clientes.UseVisualStyleBackColor = true;
            // 
            // administradores
            // 
            this.administradores.Location = new System.Drawing.Point(4, 25);
            this.administradores.Name = "administradores";
            this.administradores.Size = new System.Drawing.Size(1422, 383);
            this.administradores.TabIndex = 3;
            this.administradores.Text = "Administradores";
            this.administradores.UseVisualStyleBackColor = true;
            // 
            // autores
            // 
            this.autores.Controls.Add(this.resetAutor);
            this.autores.Controls.Add(this.guardarAutor);
            this.autores.Controls.Add(this.label11);
            this.autores.Controls.Add(this.buscarAutor);
            this.autores.Controls.Add(this.autor0);
            this.autores.Controls.Add(this.buscadorAutor);
            this.autores.Controls.Add(this.autor2);
            this.autores.Controls.Add(this.autoresDataGrid);
            this.autores.Controls.Add(this.label12);
            this.autores.Controls.Add(this.label14);
            this.autores.Controls.Add(this.Nombre);
            this.autores.Controls.Add(this.autor1);
            this.autores.Location = new System.Drawing.Point(4, 25);
            this.autores.Name = "autores";
            this.autores.Size = new System.Drawing.Size(1422, 383);
            this.autores.TabIndex = 4;
            this.autores.Text = "Autores";
            this.autores.UseVisualStyleBackColor = true;
            // 
            // resetAutor
            // 
            this.resetAutor.Location = new System.Drawing.Point(1228, 346);
            this.resetAutor.Name = "resetAutor";
            this.resetAutor.Size = new System.Drawing.Size(181, 23);
            this.resetAutor.TabIndex = 33;
            this.resetAutor.Text = "Reset";
            this.resetAutor.UseVisualStyleBackColor = true;
            this.resetAutor.Click += new System.EventHandler(this.resetAutor_Click);
            // 
            // guardarAutor
            // 
            this.guardarAutor.Location = new System.Drawing.Point(1039, 346);
            this.guardarAutor.Name = "guardarAutor";
            this.guardarAutor.Size = new System.Drawing.Size(181, 23);
            this.guardarAutor.TabIndex = 32;
            this.guardarAutor.Text = "Guardar";
            this.guardarAutor.UseVisualStyleBackColor = true;
            this.guardarAutor.Click += new System.EventHandler(this.guardarAutor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1296, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "ID:";
            // 
            // buscarAutor
            // 
            this.buscarAutor.Location = new System.Drawing.Point(3, 346);
            this.buscarAutor.Name = "buscarAutor";
            this.buscarAutor.Size = new System.Drawing.Size(238, 23);
            this.buscarAutor.TabIndex = 22;
            this.buscarAutor.Text = "Buscar por Nombre y Apellido";
            this.buscarAutor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buscarAutor.UseVisualStyleBackColor = true;
            this.buscarAutor.Click += new System.EventHandler(this.buscarAutor_Click);
            // 
            // autor0
            // 
            this.autor0.Enabled = false;
            this.autor0.Location = new System.Drawing.Point(1327, 12);
            this.autor0.Name = "autor0";
            this.autor0.Size = new System.Drawing.Size(82, 22);
            this.autor0.TabIndex = 30;
            // 
            // buscadorAutor
            // 
            this.buscadorAutor.Location = new System.Drawing.Point(247, 346);
            this.buscadorAutor.Name = "buscadorAutor";
            this.buscadorAutor.Size = new System.Drawing.Size(781, 22);
            this.buscadorAutor.TabIndex = 21;
            // 
            // autor2
            // 
            this.autor2.Location = new System.Drawing.Point(1128, 95);
            this.autor2.Name = "autor2";
            this.autor2.Size = new System.Drawing.Size(281, 22);
            this.autor2.TabIndex = 29;
            // 
            // autoresDataGrid
            // 
            this.autoresDataGrid.AllowUserToAddRows = false;
            this.autoresDataGrid.AllowUserToDeleteRows = false;
            this.autoresDataGrid.AllowUserToOrderColumns = true;
            this.autoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoresDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.Nombre2,
            this.Apellido,
            this.Editar2,
            this.Eliminar2});
            this.autoresDataGrid.Location = new System.Drawing.Point(3, 3);
            this.autoresDataGrid.Name = "autoresDataGrid";
            this.autoresDataGrid.RowHeadersWidth = 51;
            this.autoresDataGrid.RowTemplate.Height = 24;
            this.autoresDataGrid.Size = new System.Drawing.Size(1025, 334);
            this.autoresDataGrid.TabIndex = 1;
            this.autoresDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.autoresDataGrid_CellContentClick);
            // 
            // ID2
            // 
            this.ID2.DataPropertyName = "id";
            this.ID2.HeaderText = "ID";
            this.ID2.MinimumWidth = 6;
            this.ID2.Name = "ID2";
            this.ID2.ReadOnly = true;
            this.ID2.Width = 125;
            // 
            // Nombre2
            // 
            this.Nombre2.DataPropertyName = "nombre";
            this.Nombre2.HeaderText = "Nombre";
            this.Nombre2.MinimumWidth = 6;
            this.Nombre2.Name = "Nombre2";
            this.Nombre2.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // Editar2
            // 
            this.Editar2.HeaderText = "Editar";
            this.Editar2.MinimumWidth = 6;
            this.Editar2.Name = "Editar2";
            this.Editar2.Text = "Editar";
            this.Editar2.UseColumnTextForButtonValue = true;
            this.Editar2.Width = 125;
            // 
            // Eliminar2
            // 
            this.Eliminar2.HeaderText = "Eliminar";
            this.Eliminar2.MinimumWidth = 6;
            this.Eliminar2.Name = "Eliminar2";
            this.Eliminar2.Text = "Eliminar";
            this.Eliminar2.UseColumnTextForButtonValue = true;
            this.Eliminar2.Width = 125;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1036, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Apellido:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1034, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Carga de autores";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(1036, 54);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(62, 17);
            this.Nombre.TabIndex = 27;
            this.Nombre.Text = "Nombre:";
            // 
            // autor1
            // 
            this.autor1.Location = new System.Drawing.Point(1128, 54);
            this.autor1.Name = "autor1";
            this.autor1.Size = new System.Drawing.Size(281, 22);
            this.autor1.TabIndex = 25;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(943, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(101, 27);
            this.logout.TabIndex = 1;
            this.logout.Text = "SALIR";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // clientesDataGrid
            // 
            this.clientesDataGrid.AllowUserToAddRows = false;
            this.clientesDataGrid.AllowUserToDeleteRows = false;
            this.clientesDataGrid.AllowUserToOrderColumns = true;
            this.clientesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.domicilio,
            this.Telefono,
            this.FechadeNacimiento,
            this.dni,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.clientesDataGrid.Location = new System.Drawing.Point(3, 3);
            this.clientesDataGrid.Name = "clientesDataGrid";
            this.clientesDataGrid.RowHeadersWidth = 51;
            this.clientesDataGrid.RowTemplate.Height = 24;
            this.clientesDataGrid.Size = new System.Drawing.Size(1025, 334);
            this.clientesDataGrid.TabIndex = 3;
            this.clientesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesDataGrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Buscar por DNI";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buscadorCliente
            // 
            this.buscadorCliente.Location = new System.Drawing.Point(247, 346);
            this.buscadorCliente.Name = "buscadorCliente";
            this.buscadorCliente.Size = new System.Drawing.Size(781, 22);
            this.buscadorCliente.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // domicilio
            // 
            this.domicilio.DataPropertyName = "domicilio";
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.MinimumWidth = 6;
            this.domicilio.Name = "domicilio";
            this.domicilio.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 125;
            // 
            // FechadeNacimiento
            // 
            this.FechadeNacimiento.DataPropertyName = "fechaNacimiento";
            this.FechadeNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechadeNacimiento.MinimumWidth = 6;
            this.FechadeNacimiento.Name = "FechadeNacimiento";
            this.FechadeNacimiento.Width = 125;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.MinimumWidth = 6;
            this.dni.Name = "dni";
            this.dni.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Editar";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Editar";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 125;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Eliminar";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Eliminar";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 125;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1296, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "ID:";
            // 
            // cliente0
            // 
            this.cliente0.Enabled = false;
            this.cliente0.Location = new System.Drawing.Point(1327, 12);
            this.cliente0.Name = "cliente0";
            this.cliente0.Size = new System.Drawing.Size(82, 22);
            this.cliente0.TabIndex = 42;
            // 
            // cliente6
            // 
            this.cliente6.Location = new System.Drawing.Point(1128, 258);
            this.cliente6.Name = "cliente6";
            this.cliente6.Size = new System.Drawing.Size(281, 22);
            this.cliente6.TabIndex = 37;
            // 
            // cliente3
            // 
            this.cliente3.Location = new System.Drawing.Point(1128, 136);
            this.cliente3.Name = "cliente3";
            this.cliente3.Size = new System.Drawing.Size(281, 22);
            this.cliente3.TabIndex = 36;
            // 
            // cliente5
            // 
            this.cliente5.Location = new System.Drawing.Point(1146, 217);
            this.cliente5.Name = "cliente5";
            this.cliente5.Size = new System.Drawing.Size(263, 22);
            this.cliente5.TabIndex = 35;
            // 
            // cliente2
            // 
            this.cliente2.Location = new System.Drawing.Point(1128, 95);
            this.cliente2.Name = "cliente2";
            this.cliente2.Size = new System.Drawing.Size(281, 22);
            this.cliente2.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1036, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 21);
            this.label16.TabIndex = 33;
            this.label16.Text = "F. Nacimiento:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1036, 258);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 21);
            this.label17.TabIndex = 32;
            this.label17.Text = "DNI:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1036, 137);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 21);
            this.label18.TabIndex = 31;
            this.label18.Text = "Domicilio:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1036, 178);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 21);
            this.label20.TabIndex = 29;
            this.label20.Text = "Telefono:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1036, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 21);
            this.label21.TabIndex = 28;
            this.label21.Text = "Apellido:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1036, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 21);
            this.label22.TabIndex = 27;
            this.label22.Text = "Nombre:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1034, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(226, 31);
            this.label23.TabIndex = 26;
            this.label23.Text = "Carga de clientes";
            // 
            // cliente1
            // 
            this.cliente1.Location = new System.Drawing.Point(1128, 54);
            this.cliente1.Name = "cliente1";
            this.cliente1.Size = new System.Drawing.Size(281, 22);
            this.cliente1.TabIndex = 25;
            // 
            // clienteReset
            // 
            this.clienteReset.Location = new System.Drawing.Point(1228, 346);
            this.clienteReset.Name = "clienteReset";
            this.clienteReset.Size = new System.Drawing.Size(181, 23);
            this.clienteReset.TabIndex = 45;
            this.clienteReset.Text = "Reset";
            this.clienteReset.UseVisualStyleBackColor = true;
            // 
            // clienteGuardar
            // 
            this.clienteGuardar.Location = new System.Drawing.Point(1039, 346);
            this.clienteGuardar.Name = "clienteGuardar";
            this.clienteGuardar.Size = new System.Drawing.Size(181, 23);
            this.clienteGuardar.TabIndex = 44;
            this.clienteGuardar.Text = "Guardar";
            this.clienteGuardar.UseVisualStyleBackColor = true;
            this.clienteGuardar.Click += new System.EventHandler(this.clienteGuardar_Click);
            // 
            // cliente4
            // 
            this.cliente4.Location = new System.Drawing.Point(1128, 180);
            this.cliente4.Name = "cliente4";
            this.cliente4.Size = new System.Drawing.Size(281, 22);
            this.cliente4.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "BiblioTEC - NOMBRE USUARIO";
            this.tabControl.ResumeLayout(false);
            this.libros.ResumeLayout(false);
            this.libros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGrid)).EndInit();
            this.clientes.ResumeLayout(false);
            this.clientes.PerformLayout();
            this.autores.ResumeLayout(false);
            this.autores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TabPage prestamos;
        public System.Windows.Forms.TabPage clientes;
        public System.Windows.Forms.TabPage libros;
        public System.Windows.Forms.TabPage administradores;
        public System.Windows.Forms.TabPage autores;
        public System.Windows.Forms.Button logout;
        public System.Windows.Forms.DataGridView librosDataGrid;
        public System.Windows.Forms.TextBox libro1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox libro4;
        public System.Windows.Forms.DateTimePicker libro3;
        public System.Windows.Forms.TextBox libro6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox libro7;
        public System.Windows.Forms.TextBox libro2;
        public System.Windows.Forms.Button saveLibro;
        public System.Windows.Forms.ComboBox autoresEnLibros;
        public System.Windows.Forms.Button buscarLibros;
        public System.Windows.Forms.TextBox buscadorLibros;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox libro8;
        public System.Windows.Forms.DataGridViewTextBoxColumn id;
        public System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        public System.Windows.Forms.DataGridViewTextBoxColumn lugarPublicacion;
        public System.Windows.Forms.DataGridViewTextBoxColumn año;
        public System.Windows.Forms.DataGridViewTextBoxColumn paginas;
        public System.Windows.Forms.DataGridViewTextBoxColumn autor;
        public System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        public System.Windows.Forms.DataGridViewTextBoxColumn edicion;
        public System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        public System.Windows.Forms.DataGridViewButtonColumn Editar;
        public System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox libro0;
        public System.Windows.Forms.Button resetLibro;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button buscarAutor;
        public System.Windows.Forms.TextBox autor0;
        public System.Windows.Forms.TextBox buscadorAutor;
        public System.Windows.Forms.TextBox autor2;
        public System.Windows.Forms.DataGridView autoresDataGrid;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label Nombre;
        public System.Windows.Forms.TextBox autor1;
        public System.Windows.Forms.Button resetAutor;
        public System.Windows.Forms.Button guardarAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewButtonColumn Editar2;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox buscadorCliente;
        public System.Windows.Forms.DataGridView clientesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        public System.Windows.Forms.Button clienteReset;
        public System.Windows.Forms.Button clienteGuardar;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox cliente0;
        public System.Windows.Forms.TextBox cliente6;
        public System.Windows.Forms.TextBox cliente3;
        public System.Windows.Forms.DateTimePicker cliente5;
        public System.Windows.Forms.TextBox cliente2;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.TextBox cliente1;
        private System.Windows.Forms.TextBox cliente4;
    }
}

