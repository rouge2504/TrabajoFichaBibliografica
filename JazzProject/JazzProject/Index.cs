using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JazzProject
{
    public partial class Index : Form
    {
        string nombre;
        string titulo;
        string tema;
        string tipo;
        public Index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // new Importar().importarExcel(dataGridView1);
            //BusquedaDeLibro nuevaBusqueda = new BusquedaDeLibro();
            //nuevaBusqueda.Show();
            //this.FindForm();
            labelBienvenida.Visible = false;
            BuscarInicio.Visible = false;
            BuscarInicio.Enabled = false;
            buttonPrestados.Enabled = false;
            buttonPrestados.Visible = false;
            labelIntroduceDatos.Visible = true;
            labelAutor.Visible = true;
            labelTitulo.Visible = true;
            labelTema.Visible = true;
            labelTipo.Visible = true;

          

            textBoxAutor.Visible = true;
            textBoxTitulo.Visible = true;
            textBoxTema.Visible = true;
            buttonBuscarLibro.Visible = true;
            textBoxTipo.Visible = true;

            this.Text = "Busqueda";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void buttonBuscarLibro_Click(object sender, EventArgs e)
        {
            
            nombre = textBoxAutor.Text;
            titulo = textBoxTitulo.Text;
            tema = textBoxTema.Text;
            tipo = textBoxTipo.Text;

           if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(titulo) && string.IsNullOrEmpty(tema) && string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Es necesario tener por lo menos el autor o el titulo o el tema");
            }
           else if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(titulo) && !string.IsNullOrEmpty(tema) && !string.IsNullOrEmpty(tipo))
           {
               label1.Visible = true;
               ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
               resultado.listaResultados(nombre, titulo, tema, tipo);
               resultado.Show();
           }

           else if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(titulo) && !string.IsNullOrEmpty(tema) && string.IsNullOrEmpty(tipo))
            {
                label1.Visible = true;
                ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
                resultado.listaResultados(nombre, titulo, tema);
                resultado.Show();
            }
           else if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(tipo) && string.IsNullOrEmpty(titulo) && string.IsNullOrEmpty(tema))
           {
               label1.Visible = true;
               ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
               resultado.listaResultadosAutorTipo(nombre, tipo);
               resultado.Show();
           }
           else if (!string.IsNullOrEmpty(titulo) && !string.IsNullOrEmpty(tipo) && string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(tema))
           {
               label1.Visible = true;
               ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
               resultado.listaResultados(titulo, tipo);
               resultado.Show();
           }
           else if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(titulo) && string.IsNullOrEmpty(tema) && string.IsNullOrEmpty(tipo))
            {
                label1.Visible = true;
                ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
                resultado.listaResultados(nombre, titulo);
                resultado.Show();
            }
           else if (!string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(titulo) && string.IsNullOrEmpty(tema) && string.IsNullOrEmpty(tipo))
            {
                label1.Visible = true;
                ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
                resultado.listaResultadosAutor(nombre);
                resultado.Show();
            }
           else if (string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(titulo) && string.IsNullOrEmpty(tema) && string.IsNullOrEmpty(tipo))
            {
                label1.Visible = true;
                ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
                resultado.listaResultadosTitulo(titulo);
                resultado.Show();
            }
            else if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(titulo) && !string.IsNullOrEmpty(tema))
            {
                label1.Visible = true;
                ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
                resultado.listaResultadosTitulo(tema);
                resultado.Show();
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            labelBienvenida.Visible = false;
            BuscarInicio.Visible = false;
            BuscarInicio.Enabled = false;
            buttonPrestados.Enabled = false;
            buttonPrestados.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.Enabled = true;
            ExcelManager resultado = new ExcelManager(); // tener mucho cuidado aqui
            List<string> prestados = new List<string>();
            prestados = resultado.busquedaPrestados();
            for (int i = 0; i < prestados.Count; i++)
            {
                int it_palabra = 0;
                string libroprestado = "";
                string fecha = "";
                string nombre = "";
                string devolucion = "";
                string espacio = " ";
                for (int j = 0; j < prestados[i].Length; j++)
                {
                    if (prestados[i][j] == espacio[0])
                    {
                        it_palabra++;
                    }
                    switch (it_palabra)
                    {
                        case 0:
                            libroprestado += prestados[i][j];
                            break;
                        case 1:
                            fecha += prestados[i][j];
                            break;
                        case 2:
                            nombre += prestados[i][j];
                            break;
                        case 3:
                            devolucion += prestados[i][j];
                            break;
                    }
                    if (it_palabra > 3)
                    {
                        break;

                    }
                }
                    dataGridView1.Rows.Add(libroprestado, nombre, fecha, devolucion);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["Prestado"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Prestado"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Prestado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["title"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["title"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["name"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["date"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["date"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
