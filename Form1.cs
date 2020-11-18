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

        public Form1()
        {
            InitializeComponent();

            refreshLibros();
            refreshAutores();
            refreshCliente();
            refreshPrestamo();

            //autores en libros
            autoresEnLibros.DataSource = autorController.FillAll(true);
            autoresEnLibros.DisplayMember = "nombre";
            autoresEnLibros.ValueMember = "id";

            //Rellenar combo de clientes
            rellenarComboClientes();

            //Rellenar combo de libros
            rellenarComboLibros();

            resetPrestamo();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void rellenarComboLibros()
        {
            cmbLibro.DataSource = libroController.FillAllBooks(true);
            cmbLibro.DisplayMember = "titulo";
            cmbLibro.ValueMember = "id";
        }

        public void rellenarComboClientes()
        {
            cmbCliente.DataSource = clienteController.FillAll(true);
            cmbCliente.DisplayMember = "nombre";
            cmbCliente.ValueMember = "id";
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                        deleteLibro(e.RowIndex);
                        refreshLibros();
                        break;
                }
            }
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
                        break;
                }
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

        public void setDataToEditAutor(int index)
        {
            DataGridViewRow row = autoresDataGrid.Rows[index];
            autor0.Text = row.Cells[0].Value.ToString();
            autor1.Text = row.Cells[1].Value.ToString();
            autor2.Text = row.Cells[2].Value.ToString();
        }

        public void setDataToEditPrestamo(int index)
        {
            cmbDevuelto.Enabled = true;

            DataGridViewRow row = prestamosDataGrid.Rows[index];
            txtIdPrestamo.Text = row.Cells[0].Value.ToString();
            cmbCliente.SelectedValue = row.Cells[1].Value.ToString();
            cmbLibro.SelectedValue = row.Cells[2].Value.ToString();
            dtpFPrestamo.Text = row.Cells[5].Value.ToString();
            dtpFDevolucion.Text = row.Cells[6].Value.ToString();
            cmbDevuelto.SelectedItem = row.Cells[7].Value.ToString();
            //cmbAdministrador.SelectedValue = row.Cells[8].Value.ToString();
        }

        public void deleteLibro(int index)
        {
            DataGridViewRow row = librosDataGrid.Rows[index];
            libroController.deleteBook(Int32.Parse(row.Cells[0].Value.ToString()));
        }

        public void deleteCliente(int index)
        {
            DataGridViewRow row = clientesDataGrid.Rows[index];
            clienteController.deleteCliente(Int32.Parse(row.Cells[0].Value.ToString()));
        }

        public void deleteAutor(int index)
        {
            DataGridViewRow row = autoresDataGrid.Rows[index];
            autorController.deleteAutor(Int32.Parse(row.Cells[0].Value.ToString()));
        }

        public void deletePrestamo(int index)
        {
            if (MessageBox.Show("Está por eliminar el préstamo seleccionado. ¿Desea continuar?", "Eliminar préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow row = prestamosDataGrid.Rows[index];
                prestamoController.deleteLoan(Int32.Parse(row.Cells[0].Value.ToString()));
            }
        }

        public void refreshLibros()
        {
            //tabla de libros
            librosDataGrid.AutoGenerateColumns = false;
            librosDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            librosDataGrid.DataSource = libroController.FillAllBooks(false);
        }

        public void refreshAutores()
        {
            //tabla de libros
            autoresDataGrid.AutoGenerateColumns = false;
            autoresDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            autoresDataGrid.DataSource = autorController.FillAll(false);
        }

        public void refreshCliente()
        {
            //tabla de libros
            clientesDataGrid.AutoGenerateColumns = false;
            clientesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientesDataGrid.DataSource = clienteController.FillAll(false);
        }

        public void refreshPrestamo()
        {
            prestamosDataGrid.AutoGenerateColumns = false;
            prestamosDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            prestamosDataGrid.DataSource = prestamoController.FillAllLoans();
        }

        public void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void label8_Click(object sender, EventArgs e)
        {

        }

        public void buscarLibros_Click(object sender, EventArgs e)
        {
            librosDataGrid.AutoGenerateColumns = false;
            librosDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            librosDataGrid.DataSource = libroController.FillAllBooksByText(buscadorLibros.Text);
        }

        public void label10_Click(object sender, EventArgs e)
        {

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

        public void resetPrestamo()
        {
            txtIdPrestamo.Text = string.Empty;
            cmbCliente.SelectedIndex = -1;
            cmbLibro.SelectedIndex = -1;
            cmbDevuelto.SelectedIndex = 0;
            cmbDevuelto.Enabled = false;
            dtpFPrestamo.Value = DateTime.Now;
            dtpFDevolucion.Value = DateTime.Now;
        }

        private void prestamosDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 9:
                        setDataToEditPrestamo(e.RowIndex);
                        break;
                    case 10:
                        deletePrestamo(e.RowIndex);
                        refreshPrestamo();
                        break;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex != -1 && cmbLibro.SelectedIndex != -1)
            {
                Cliente cliente = new Cliente();
                cliente.id = Convert.ToInt32(cmbCliente.SelectedValue);

                Libro libro = new Libro(null);
                libro.id = Convert.ToInt32(cmbLibro.SelectedValue);

                Prestamo prestamo = new Prestamo(cliente, libro);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetPrestamo();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está por salir del sistema. ¿Desea continuar?", "Cerando el sistema...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Close();
        }

        private void prestamosDataGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (DataGridViewRow row in prestamosDataGrid.Rows)
            {
                if (row.Cells[7].Value.ToString() == "No" && Convert.ToDateTime(row.Cells[6].Value) >= DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (row.Cells[7].Value.ToString() == "No" && Convert.ToDateTime(row.Cells[6].Value) < DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
