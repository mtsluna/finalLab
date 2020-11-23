using final.controllers;
using final.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace final
{
    public partial class Form1 : Form
    {

        LibroController libroController = new LibroController();
        AutorController autorController = new AutorController();
        ClienteController clienteController = new ClienteController();
        PrestamoController prestamoController = new PrestamoController();
        AdministradorController adminController = new AdministradorController();
        bool fullAdmin;
        bool fullLibro;
        bool fullCliente;
        bool fullAutor;
        bool fullPrestamo;

        public Form1()
        {
            InitializeComponent();

            refreshLibros();
            refreshAutores();
            refreshCliente();
            refreshPrestamo();
            refreshAdmins();

            rellenarComboAutor();

            //Rellenar combo de clientes
            rellenarComboClientes();

            //Rellenar combo de libros
            rellenarComboLibros();

            //Rellenar combo de administradores
            rellenarComboAdmin();

            resetPrestamo();

            checkAutor();
            checkAdmin();
            checkCliente();
            checkLibro();
        }

        //LIBROS
        public void rellenarComboLibros()
        {
            cmbLibro.DataSource = libroController.FillAllBooks(true);
            cmbLibro.DisplayMember = "titulo";
            cmbLibro.ValueMember = "id";
        }

        public void refreshLibros()
        {
            //tabla de libros
            librosDataGrid.AutoGenerateColumns = false;
            librosDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            librosDataGrid.DataSource = libroController.FillAllBooks(false);
        }

        public void buscarLibros_Click(object sender, EventArgs e)
        {
            librosDataGrid.AutoGenerateColumns = false;
            librosDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            librosDataGrid.DataSource = libroController.FillAllBooksByText(buscadorLibros.Text);
        }

        public void saveLibro_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            autor.id = Int16.Parse(autoresEnLibros.SelectedValue.ToString());
            Libro libro = new Libro(autor);
            if (!libro0.Text.Equals(""))
                libro.id = Int16.Parse(libro0.Text);
            libro.titulo = libro1.Text;
            libro.lugarPublicacion = libro2.Text;
            libro.año = libro3.Value.ToString("yyyy-MM-dd");
            libro.paginas = Int16.Parse(libro4.Text);
            libro.descripcion = libro6.Text;
            libro.edicion = libro7.Text;
            libro.isbn = libro8.Text;
            if (libro0.Text.Equals(""))
            {
                libroController.instertBook(libro);
            }
            else
            {
                libro.id = Int16.Parse(libro0.Text);
                libroController.updateBook(libro);
            }
            refreshLibros();
            rellenarComboLibros();
        }

        private void resetLibro_Click(object sender, EventArgs e)
        {
            libro0.Text = "";
            libro1.Text = "";
            libro2.Text = "";
            libro3.Text = "";
            libro4.Text = "";
            autoresEnLibros.SelectedIndex = 0;
            libro6.Text = "";
            libro7.Text = "";
            libro8.Text = "";
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Console.WriteLine(e.ColumnIndex);
                Console.WriteLine(e.RowIndex);
                switch (e.ColumnIndex)
                {
                    case 9:
                        setDataToEditLibro(e.RowIndex);
                        break;
                    case 10:
                        deleteLibro(e.RowIndex);
                        refreshLibros();
                        break;
                }
            }
        }

        public void deleteLibro(int index)
        {
            if (MessageBox.Show("Está por eliminar el libro seleccionado. ¿Desea continuar?", "Eliminar libro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow row = librosDataGrid.Rows[index];
                libroController.deleteBook(Int32.Parse(row.Cells[0].Value.ToString()));
            }
        }

        public void setDataToEditLibro(int index)
        {
            DataGridViewRow row = librosDataGrid.Rows[index];
            libro0.Text = row.Cells[0].Value.ToString();
            libro1.Text = row.Cells[1].Value.ToString();
            libro2.Text = row.Cells[2].Value.ToString();
            libro3.Text = row.Cells[3].Value.ToString();
            libro4.Text = row.Cells[4].Value.ToString();
            //libro5.Text = row.Cells[0].Value.ToString();
            libro6.Text = row.Cells[6].Value.ToString();
            libro7.Text = row.Cells[7].Value.ToString();
            libro8.Text = row.Cells[8].Value.ToString();
        }


        //AUTORES
        public void rellenarComboAutor()
        {
            autoresEnLibros.DataSource = autorController.FillAll(true);
            autoresEnLibros.DisplayMember = "nombre";
            autoresEnLibros.ValueMember = "id";
        }

        private void autoresDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Console.WriteLine(e.ColumnIndex);
                Console.WriteLine(e.RowIndex);
                switch (e.ColumnIndex)
                {
                    case 3:
                        setDataToEditAutor(e.RowIndex);
                        break;
                    case 4:
                        deleteAutor(e.RowIndex);
                        refreshAutores();
                        rellenarComboAutor();
                        break;
                }
            }
        }

        public void setDataToEditAutor(int index)
        {
            DataGridViewRow row = autoresDataGrid.Rows[index];
            autor0.Text = row.Cells[0].Value.ToString();
            autor1.Text = row.Cells[1].Value.ToString();
            autor2.Text = row.Cells[2].Value.ToString();
        }

        public void deleteAutor(int index)
        {
            if (MessageBox.Show("Está por eliminar el autor seleccionado. ¿Desea continuar?", "Eliminar autor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow row = autoresDataGrid.Rows[index];
                autorController.deleteAutor(Int32.Parse(row.Cells[0].Value.ToString()));
            }
        }

        public void refreshAutores()
        {
            //tabla de libros
            autoresDataGrid.AutoGenerateColumns = false;
            autoresDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            autoresDataGrid.DataSource = autorController.FillAll(false);
        }

        private void buscarAutor_Click(object sender, EventArgs e)
        {
            autoresDataGrid.AutoGenerateColumns = false;
            autoresDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            autoresDataGrid.DataSource = autorController.FillAllAutorByText(buscadorAutor.Text);
        }

        private void resetAutor_Click(object sender, EventArgs e)
        {
            autor0.Text = "";
            autor1.Text = "";
            autor2.Text = "";
        }

        private void guardarAutor_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            autor.nombre = autor1.Text;
            autor.apellido = autor2.Text;
            if (autor0.Text.Equals(""))
            {
                autorController.instertAutor(autor);
            }
            else
            {
                autor.id = Int16.Parse(autor0.Text);
                autorController.updateAutor(autor);
            }
            refreshAutores();
            rellenarComboAutor();
        }

        //ADMINISTRADORES
        public void rellenarComboAdmin()
        {
            cmbAdministrador.DataSource = adminController.FillAll(true);
            cmbAdministrador.DisplayMember = "admin";
            cmbAdministrador.ValueMember = "id";
        }

        public void refreshAdmins()
        {
            //Tabla de administradores
            adminsDataGrid.AutoGenerateColumns = false;
            adminsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adminsDataGrid.DataSource = adminController.FillAll(false);

        }

        private void adminsDataGrid_PassFormat(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void adminsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Console.WriteLine(e.ColumnIndex);
                Console.WriteLine(e.RowIndex);
                switch (e.ColumnIndex)
                {
                    case 7:
                        setDataToEditAdmin(e.RowIndex);
                        break;
                    case 8:
                        deleteAdmin(e.RowIndex);
                        refreshAdmins();
                        break;
                }
            }
        }

        public void setDataToEditAdmin(int index)
        {
            DataGridViewRow row = adminsDataGrid.Rows[index];
            inputIDAdmin.Text = row.Cells[0].Value.ToString();
            inputNombreAdmin.Text = row.Cells[1].Value.ToString();
            inputApellidoAdmin.Text = row.Cells[2].Value.ToString();
            inputDniAdmin.Text = row.Cells[3].Value.ToString();
            inputTelefonoAdmin.Text = row.Cells[4].Value.ToString();
            inputUserAdmin.Text = row.Cells[5].Value.ToString();
            inputContraAdmin.Text = row.Cells[6].Value.ToString();
        }

        public void deleteAdmin(int index)
        {
            if (MessageBox.Show("Está por eliminar el administrador seleccionado. ¿Desea continuar?", "Eliminar administrador", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow row = adminsDataGrid.Rows[index];
                adminController.deleteAdmin(Int32.Parse(row.Cells[0].Value.ToString()));
            }
        }

        private void limpiarAdmin_Click(object sender, EventArgs e)
        {
            inputIDAdmin.Text = "";
            inputNombreAdmin.Text = "";
            inputApellidoAdmin.Text = "";
            inputTelefonoAdmin.Text = "";
            inputDniAdmin.Text = "";
            inputUserAdmin.Text = "";
            inputContraAdmin.Text = "";
        }

        private void guardarAdmin_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            admin.nombre = inputNombreAdmin.Text;
            admin.apellido = inputApellidoAdmin.Text;
            admin.telefono = inputTelefonoAdmin.Text;
            admin.dni = inputDniAdmin.Text;
            admin.usuario = inputUserAdmin.Text;
            admin.clave = inputContraAdmin.Text;
            if (inputIDAdmin.Text.Equals(""))
            {
                adminController.insertAdmin(admin);
            }
            else
            {
                admin.id = Int16.Parse(inputIDAdmin.Text);
                adminController.updateAdmin(admin);
            }
            refreshAdmins();
            inputIDAdmin.Text = "";
            inputNombreAdmin.Text = "";
            inputApellidoAdmin.Text = "";
            inputTelefonoAdmin.Text = "";
            inputDniAdmin.Text = "";
            inputUserAdmin.Text = "";
            inputContraAdmin.Text = "";

            rellenarComboAdmin();
        }

        private void limpiarAdmin_Click_1(object sender, EventArgs e)
        {
            inputIDAdmin.Text = "";
            inputNombreAdmin.Text = "";
            inputApellidoAdmin.Text = "";
            inputTelefonoAdmin.Text = "";
            inputDniAdmin.Text = "";
            inputUserAdmin.Text = "";
            inputContraAdmin.Text = "";
        }

        //PRESTAMOS
        public void setDataToEditPrestamo(int index)
        {
            cmbDevuelto.Enabled = true;

            DataGridViewRow row = prestamosDataGrid.Rows[index];
            txtIdPrestamo.Text = row.Cells[0].Value.ToString();
            cmbCliente.SelectedValue = row.Cells[1].Value.ToString();
            cmbLibro.SelectedValue = row.Cells[2].Value.ToString();
            dtpFPrestamo.Text = row.Cells[6].Value.ToString();
            dtpFDevolucion.Text = row.Cells[7].Value.ToString();
            cmbDevuelto.SelectedItem = row.Cells[8].Value.ToString();
            cmbAdministrador.SelectedValue = row.Cells[3].Value.ToString();
        }

        public void resetPrestamo()
        {
            txtIdPrestamo.Text = string.Empty;
            cmbCliente.SelectedIndex = -1;
            cmbLibro.SelectedIndex = -1;
            cmbDevuelto.SelectedIndex = 0;
            cmbDevuelto.Enabled = false;
            dtpFPrestamo.Value = DateTime.Now;
            dtpFDevolucion.Value = DateTime.Now;
            cmbAdministrador.SelectedIndex = -1;
        }

        private void prestamosDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 10:
                        setDataToEditPrestamo(e.RowIndex);
                        break;
                    case 11:
                        deletePrestamo(e.RowIndex);
                        refreshPrestamo();
                        break;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex != -1 && cmbLibro.SelectedIndex != -1 && cmbAdministrador.SelectedIndex != -1)
            {
                Cliente cliente = new Cliente();
                cliente.id = Convert.ToInt32(cmbCliente.SelectedValue);

                Libro libro = new Libro(null);
                libro.id = Convert.ToInt32(cmbLibro.SelectedValue);

                Administrador administrador = new Administrador();
                administrador.id = Convert.ToInt32(cmbAdministrador.SelectedValue);

                Prestamo prestamo = new Prestamo(cliente, libro, administrador);
                prestamo.fechaPrestamo = dtpFPrestamo.Value.ToString("yyyy-MM-dd");
                prestamo.fechaDevolucion = dtpFDevolucion.Value.ToString("yyyy-MM-dd");
                prestamo.devuelto = ((cmbDevuelto.SelectedItem.ToString()) == "No") ? 'N' : 'S';

                if (txtIdPrestamo.Text.Equals(""))
                {
                    prestamoController.instertLoan(prestamo);
                }
                else
                {
                    prestamo.id = Convert.ToInt32(txtIdPrestamo.Text);
                    prestamoController.updateLoan(prestamo);
                }

                resetPrestamo();
                refreshPrestamo();
            }
        }

        private void prestamosDataGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (DataGridViewRow row in prestamosDataGrid.Rows)
            {
                if (row.Cells[8].Value.ToString() == "No" && Convert.ToDateTime(row.Cells[7].Value) >= DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (row.Cells[8].Value.ToString() == "No" && Convert.ToDateTime(row.Cells[7].Value) < DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetPrestamo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            prestamosDataGrid.AutoGenerateColumns = false;
            prestamosDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            prestamosDataGrid.DataSource = prestamoController.FillAllLoansByText(txtDatosPrestamo.Text);
        }

        public void deletePrestamo(int index)
        {
            if (MessageBox.Show("Está por eliminar el préstamo seleccionado. ¿Desea continuar?", "Eliminar préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow row = prestamosDataGrid.Rows[index];
                prestamoController.deleteLoan(Int32.Parse(row.Cells[0].Value.ToString()));
            }
        }

        public void refreshPrestamo()
        {
            prestamosDataGrid.AutoGenerateColumns = false;
            prestamosDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            prestamosDataGrid.DataSource = prestamoController.FillAllLoans();
        }

        //CLIENTES
        public void rellenarComboClientes()
        {
            cmbCliente.DataSource = clienteController.FillAll(true);
            cmbCliente.DisplayMember = "nombre";
            cmbCliente.ValueMember = "id";
        }

        public void setDataToEditClient(int index)
        {
            DataGridViewRow row = clientesDataGrid.Rows[index];
            cliente0.Text = row.Cells[0].Value.ToString();
            cliente1.Text = row.Cells[1].Value.ToString();
            cliente2.Text = row.Cells[2].Value.ToString();
            cliente3.Text = row.Cells[3].Value.ToString();
            cliente4.Text = row.Cells[4].Value.ToString();
            cliente5.Text = row.Cells[5].Value.ToString();
            cliente6.Text = row.Cells[6].Value.ToString();
        }

        private void clientesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Console.WriteLine(e.ColumnIndex);
                Console.WriteLine(e.RowIndex);
                switch (e.ColumnIndex)
                {
                    case 7:
                        setDataToEditClient(e.RowIndex);
                        break;
                    case 8:
                        deleteCliente(e.RowIndex);
                        refreshCliente();
                        rellenarComboClientes();
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientesDataGrid.AutoGenerateColumns = false;
            clientesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientesDataGrid.DataSource = clienteController.FillAllClienteByText(buscadorCliente.Text);
        }

        private void clienteGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.nombre = cliente1.Text;
            cliente.apellido = cliente2.Text;
            cliente.domicilio = cliente3.Text;
            cliente.telefono = cliente4.Text;
            cliente.fechaNacimiento = cliente5.Value.ToString("yyyy-MM-dd");
            cliente.dni = cliente6.Text;
            if (cliente0.Text.Equals(""))
            {
                clienteController.insert(cliente);
            }
            else
            {
                cliente.id = Int16.Parse(cliente0.Text);
                clienteController.update(cliente);
            }
            refreshCliente();
            rellenarComboClientes();
        }

        public void deleteCliente(int index)
        {
            if (MessageBox.Show("Está por eliminar el cliente seleccionado. ¿Desea continuar?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow row = clientesDataGrid.Rows[index];
                clienteController.deleteCliente(Int32.Parse(row.Cells[0].Value.ToString()));
            }
        }

        public void refreshCliente()
        {
            //tabla de libros
            clientesDataGrid.AutoGenerateColumns = false;
            clientesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientesDataGrid.DataSource = clienteController.FillAll(false);
        }

        private void keyPressIsNumber(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void buscarAdmin_Click(object sender, EventArgs e)
        {
            adminsDataGrid.AutoGenerateColumns = false;
            adminsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adminsDataGrid.DataSource = adminController.FillAllAdminByText(buscadorAdmin.Text);
        }

        //Validations
        public void checkAutor()
        {
            if (!autor1.Text.Equals("") && !autor2.Text.Equals(""))
            {
                guardarAutor.Enabled = true;
            }
            else
            {
                guardarAutor.Enabled = false;
            }
        }

        public void checkAdmin()
        {
            if (!inputApellidoAdmin.Text.Equals("") && !inputContraAdmin.Text.Equals("") && !inputDniAdmin.Text.Equals("") && !inputNombreAdmin.Text.Equals("") && !inputTelefonoAdmin.Text.Equals("") && !inputUserAdmin.Text.Equals(""))
            {
                guardarAdmin.Enabled = true;
            }
            else
            {
                guardarAdmin.Enabled = false;
            }
        }

        public void checkCliente()
        {
            if (!cliente1.Text.Equals("") && !cliente2.Text.Equals("") && !cliente3.Text.Equals("") && !cliente4.Text.Equals("") && !cliente5.Text.Equals("") && !cliente6.Text.Equals(""))
            {
                clienteGuardar.Enabled = true;
            }
            else
            {
                clienteGuardar.Enabled = false;
            }
        }

        public void checkLibro()
        {
            if (!libro1.Text.Equals("") && !libro2.Text.Equals("") && !libro3.Text.Equals("") && !libro4.Text.Equals("") && !autoresEnLibros.SelectedItem.Equals("") && !libro6.Text.Equals("") && !libro7.Text.Equals("") && !libro8.Text.Equals(""))
            {
                saveLibro.Enabled = true;
            }
            else
            {
                saveLibro.Enabled = false;
            }
        }

        private void autor1_TextChanged(object sender, EventArgs e)
        {
            checkAutor();
        }

        private void autor2_TextChanged(object sender, EventArgs e)
        {
            checkAutor();
        }

        private void inputNombreAdmin_TextChanged(object sender, EventArgs e)
        {
            checkAdmin();
        }

        private void inputApellidoAdmin_TextChanged(object sender, EventArgs e)
        {
            checkAdmin();
        }

        private void inputDniAdmin_TextChanged(object sender, EventArgs e)
        {
            checkAdmin();
        }

        private void inputTelefonoAdmin_TextChanged(object sender, EventArgs e)
        {
            checkAdmin();
        }

        private void inputUserAdmin_TextChanged(object sender, EventArgs e)
        {
            checkAdmin();
        }

        private void inputContraAdmin_TextChanged(object sender, EventArgs e)
        {
            checkAdmin();
        }

        private void cliente1_TextChanged(object sender, EventArgs e)
        {
            checkCliente();
        }

        private void cliente2_TextChanged(object sender, EventArgs e)
        {
            checkCliente();
        }

        private void cliente3_TextChanged(object sender, EventArgs e)
        {
            checkCliente();
        }

        private void cliente4_TextChanged(object sender, EventArgs e)
        {
            checkCliente();
        }

        private void cliente5_ValueChanged(object sender, EventArgs e)
        {
            checkCliente();
        }

        private void cliente6_TextChanged(object sender, EventArgs e)
        {
            checkCliente();
        }

        private void libro1_TextChanged(object sender, EventArgs e)
        {
            checkLibro();
        }

        private void libro6_TextChanged(object sender, EventArgs e)
        {
            checkLibro();
        }

        private void libro3_ValueChanged(object sender, EventArgs e)
        {
            checkLibro();
        }

        private void autoresEnLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkLibro();
        }

        private void libro4_TextChanged(object sender, EventArgs e)
        {
            checkLibro();
        }

        private void libro7_TextChanged(object sender, EventArgs e)
        {
            checkLibro();
        }

        private void libro2_TextChanged(object sender, EventArgs e)
        {
            checkLibro();
        }

        private void libro8_TextChanged(object sender, EventArgs e)
        {
            checkLibro();
        }

        private void clienteReset_Click(object sender, EventArgs e)
        {
            cliente0.Text = "";
            cliente1.Text = "";
            cliente2.Text = "";
            cliente3.Text = "";
            cliente4.Text = "";
            cliente5.Text = "";
            cliente6.Text = "";
        }
    }
}
