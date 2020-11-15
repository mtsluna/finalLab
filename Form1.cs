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

        public Form1()
        {
            InitializeComponent();

            refreshLibros();
            refreshAutores();

            //autores en libros
            autoresEnLibros.DataSource = autorController.FillAll(true);
            autoresEnLibros.DisplayMember = "nombre";
            autoresEnLibros.ValueMember = "id";
        }

        public void label1_Click(object sender, EventArgs e)
        {

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

        public void deleteLibro(int index)
        {
            DataGridViewRow row = librosDataGrid.Rows[index];
            libroController.deleteBook(Int32.Parse(row.Cells[0].Value.ToString()));
        }

        public void deleteAutor(int index)
        {
            DataGridViewRow row = autoresDataGrid.Rows[index];
            autorController.deleteAutor(Int32.Parse(row.Cells[0].Value.ToString()));
        }

        public void refreshLibros()
        {
            //tabla de libros
            librosDataGrid.AutoGenerateColumns = false;
            librosDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            librosDataGrid.DataSource = libroController.FillAllBooks();
        }

        public void refreshAutores()
        {
            //tabla de libros
            autoresDataGrid.AutoGenerateColumns = false;
            autoresDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            autoresDataGrid.DataSource = autorController.FillAll(false);
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
    }
}
