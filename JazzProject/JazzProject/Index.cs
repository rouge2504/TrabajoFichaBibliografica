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
        string clave;
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

            labelIntroduceDatos.Visible = true;
            labelAutor.Visible = true;
            labelTitulo.Visible = true;
            labelTema.Visible = true;
            

            checkBox1.Visible = true;

            textBoxAutor.Visible = true;
            textBoxTitulo.Visible = true;
            textBoxTema.Visible = true;
            buttonBuscarLibro.Visible = true;

            this.Text = "Busqueda";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                labelPalabraClave.Visible = true;
                textBoxPalabraClave.Visible = true;
            }
            else
            {
                labelPalabraClave.Visible = false;
                textBoxPalabraClave.Visible = false;
            }
        }

        private void buttonBuscarLibro_Click(object sender, EventArgs e)
        {
            
            nombre = textBoxAutor.Text;
            titulo = textBoxTitulo.Text;
            tema = textBoxTema.Text;
            clave = textBoxPalabraClave.Text;
            
            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(titulo) && string.IsNullOrEmpty(tema) && string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor llena los campos");
                
            }
            else if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(titulo) && string.IsNullOrEmpty(tema) && string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Es necesario tener por lo menos el autor o el titulo");
            }
            else if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(titulo) && !string.IsNullOrEmpty(tema) && !string.IsNullOrEmpty(clave))
            {
                label1.Visible = true;
                ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
                resultado.listaResultados(nombre, titulo, tema, clave);
                resultado.Show();
            }
            else if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(titulo) && !string.IsNullOrEmpty(tema) && string.IsNullOrEmpty(clave))
            {
                label1.Visible = true;
                ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
                resultado.listaResultados(nombre, titulo, tema);
                resultado.Show();
            }
            else if (!string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(titulo) && string.IsNullOrEmpty(tema) && string.IsNullOrEmpty(clave))
            {
                label1.Visible = true;
                ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
                resultado.listaResultadosAutor(nombre);
                resultado.Show();
            }
            else if (string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(titulo) && string.IsNullOrEmpty(tema) && string.IsNullOrEmpty(clave))
            {
                label1.Visible = true;
                ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
                resultado.listaResultadosTitulo(titulo);
                resultado.Show();
            }
            else if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(titulo) && !string.IsNullOrEmpty(tema) && string.IsNullOrEmpty(clave))
            {
                label1.Visible = true;
                ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
                resultado.listaResultadosTitulo(tema);
                resultado.Show();
            }
            else if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(titulo) && string.IsNullOrEmpty(tema) && !string.IsNullOrEmpty(clave))
            {
                label1.Visible = true;
                ResultadoDeBusqueda resultado = new ResultadoDeBusqueda();
                resultado.listaResultadosClave(clave);
                resultado.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
