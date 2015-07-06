using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
//using System.String;

namespace JazzProject
{
    public partial class ResultadoDeBusqueda : Form
    {
        ExcelManager manageData = new ExcelManager();
        Index pantallaInicio = new Index();
        public ResultadoDeBusqueda()
        {
            InitializeComponent();
        }
        List<int> indices = new List<int>();
        public void listaResultados(string autor, string titulo, string tema, string clave)
        {
            //enfocado sin clave
            indices = new List<int>();
            for (int i = 0; i < Autor(autor).Count; i++)
            {
                indices.Add(Autor(autor)[i]);
            }
            for (int i = 0; i < Titulo(titulo).Count; i++)
            {
                indices.Add(Titulo(titulo)[i]);
            }
            for (int i = 0; i < Tema(tema).Count; i++)
            {
                indices.Add(Tema(tema)[i]);
            }


            indices = indices.Distinct().ToList();
            pantallaInicio.label1.Visible = false;
            for (int i = 0; i < indices.Count; i++)
            {
               // AddNewLabelTodosLosCampos(indices[i], i);
                //System.Diagnostics.Debug.WriteLine(AddNewLabel(indices[i], i).Text);
                AddNewLabelTabla(indices[i]);
            }
            }

        public void listaResultados(string autor, string titulo, string tema)
        {
            //enfocado sin clave
            indices = new List<int>();
            for (int i = 0; i < Autor(autor).Count; i++)
            {
                indices.Add(Autor(autor)[i]);
            }
            for (int i = 0; i < Titulo(titulo).Count; i++)
            {
                indices.Add(Titulo(titulo)[i]);
            }
            for (int i = 0; i < Tema(tema).Count; i++)
            {
                indices.Add(Tema(tema)[i]);
            }


            indices = indices.Distinct().ToList();
            pantallaInicio.label1.Visible = false;
            for (int i = 0; i < indices.Count; i++)
            {
                // AddNewLabelTodosLosCampos(indices[i], i);
                //System.Diagnostics.Debug.WriteLine(AddNewLabel(indices[i], i).Text);
                AddNewLabelTabla(indices[i]);
            }
        }

        public void listaResultadosAutor(string autor)
        {
            //enfocado puro autor
            indices = new List<int>();
            for (int i = 0; i < Autor(autor).Count; i++)
            {
                indices.Add(Autor(autor)[i]);
            }
            indices = indices.Distinct().ToList();
            pantallaInicio.label1.Visible = false;
            for (int i = 0; i < indices.Count; i++)
            {

                AddNewLabelTabla(indices[i]);
            }
        }

        public void listaResultadosTitulo(string titulo)
        {
            //enfocado puro titulo
            indices = new List<int>();

            for (int i = 0; i < Titulo(titulo).Count; i++)
            {
                indices.Add(Titulo(titulo)[i]);
            }
          


            indices = indices.Distinct().ToList();
            pantallaInicio.label1.Visible = false;
            for (int i = 0; i < indices.Count; i++)
            {

                AddNewLabelTabla(indices[i]);
            }
        }

        public void listaResultadosTema(string tema)
        {
            //enfocado puro titulo
            indices = new List<int>();

            for (int i = 0; i < Tema(tema).Count; i++)
            {
                indices.Add(Tema(tema)[i]);
            }
            indices = indices.Distinct().ToList();
            pantallaInicio.label1.Visible = false;
            for (int i = 0; i < indices.Count; i++)
            {

                AddNewLabelTabla(indices[i]);
            }
        }

        public void listaResultadosClave(string clave)
        {
            //enfocado puro clave
            indices = new List<int>();

            for (int i = 0; i < Clave(clave).Count; i++)
            {
                indices.Add(Clave(clave)[i]);
            }
            indices = indices.Distinct().ToList();
            pantallaInicio.label1.Visible = false;
            for (int i = 0; i < indices.Count; i++)
            {

                AddNewLabelTabla(indices[i]);
            }
        }
       
        private LinkLabel AddNewLabelTodosLosCampos(int indice, int posicion)
        {

            LinkLabel txt = new LinkLabel();
            this.Controls.Add(txt);
            txt.LinkClicked += new LinkLabelLinkClickedEventHandler(this.clickTodosLosCampos); //poner lo que se mandara osea un void 
            txt.Top = posicion * 30;
            txt.Left = 15;      
            txt.Text = manageData.extraccionDatosTodosLosCampos(indice);
            txt.AutoSize = true;
            return txt;
        }

        private LinkLabel AddNewLabelTabla(int indice)
        {

            LinkLabel txt = new LinkLabel();
            this.Controls.Add(txt);
            txt.LinkClicked += new LinkLabelLinkClickedEventHandler(this.clickTodosLosCampos); //poner lo que se mandara osea un void 
            txt.Left = 15;
            //txt.Text = manageData.extraccionDatosTodosLosCampos(indice);
            dataGridView1.Rows.Add(manageData.extraccionDatosTitulo(indice), manageData.extraccionDatosAutor(indice));
            //dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["nombreTitulo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["nombreTitulo"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["nombre"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["nombreTitulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            txt.AutoSize = true;
            return txt;
        }

        private void clickTodosLosCampos(object sender, LinkLabelLinkClickedEventArgs e)  //hacer links dinamicos tambien!!!
        {
            // Determine which link was clicked within the LinkLabel.
            //System.Diagnostics.Debug.WriteLine(txt.Text);

            string checkSender = ((LinkLabel)sender).Text.ToString();
            for (int i = 0; i < indices.Count; i++)
            {

                if (checkSender == AddNewLabelTodosLosCampos(indices[i], i).Text)
                    System.Diagnostics.Debug.WriteLine(AddNewLabelTodosLosCampos(indices[i], i).Text);
            }

            
        }

        private List<int> Autor(string autor)
        {
            //autor
            string autorParaChecar = autor;
            autorParaChecar += " algo";
            string space = " ";
            List<string> listadoDeNombre = new List<string>();
            List<int> busquedaDeLugar = new List<int>();
            int it_separador = 0;
            string[] pronombres = new string[] { "DE", "LOS", "LAS", "LA", "EL" };
            for (int i = 0; i < autorParaChecar.Length; i++)
            {
                if (autorParaChecar[i] == space[0])
                {
                    string nombreTemp = "";
                    for (int j = it_separador; j < i; j++)
                    {

                        nombreTemp += autorParaChecar[j];
                    }
                    nombreTemp = nombreTemp.ToUpper();

                    listadoDeNombre.Add(nombreTemp);
                    for (int j = 0; j < pronombres.Length; j++)
                    {
                        if (nombreTemp == pronombres[j])
                        {

                            listadoDeNombre.Remove(nombreTemp);
                        }
                    }
                    it_separador = i + 1;
                }
            }


            for (int i = 0; i < listadoDeNombre.Count; i++)
            {
                busquedaDeLugar = manageData.Autor(listadoDeNombre[i]).Distinct().ToList();
            }
            return busquedaDeLugar;

        }

        private List<int> Titulo(string titulo)
        {
            //titulo
            string tituloParaChecar = titulo;
            tituloParaChecar += " algo";
            string space = " ";
            List<string> listadoDeNombre = new List<string>();
            List<int> busquedaDeLugar = new List<int>();
            int it_separador = 0;
            string[] pronombres = new string[] { "DE", "LOS", "LAS", "LA", "EL" };
            for (int i = 0; i < tituloParaChecar.Length; i++)
            {
                if (tituloParaChecar[i] == space[0])
                {
                    string nombreTemp = "";
                    for (int j = it_separador; j < i; j++)
                    {

                        nombreTemp += tituloParaChecar[j];
                    }
                    nombreTemp = nombreTemp.ToUpper();

                    listadoDeNombre.Add(nombreTemp);
                    for (int j = 0; j < pronombres.Length; j++)
                    {
                        if (nombreTemp == pronombres[j])
                        {

                            listadoDeNombre.Remove(nombreTemp);
                        }
                    }
                    it_separador = i + 1;
                }
            }


            for (int i = 0; i < listadoDeNombre.Count; i++)
            {
                busquedaDeLugar = manageData.Titulo(listadoDeNombre[i]).Distinct().ToList();
            }
            return busquedaDeLugar;

        }

        private List<int> Tema(string tema)
        {
            //tema
            string temaParaChecar = tema;
            temaParaChecar += " algo";
            string space = " ";
            List<string> listadoDeNombre = new List<string>();
            List<int> busquedaDeLugar = new List<int>();
            int it_separador = 0;
            string[] pronombres = new string[] { "DE", "LOS", "LAS", "LA", "EL" };
            for (int i = 0; i < temaParaChecar.Length; i++)
            {
                if (temaParaChecar[i] == space[0])
                {
                    string nombreTemp = "";
                    for (int j = it_separador; j < i; j++)
                    {

                        nombreTemp += temaParaChecar[j];
                    }
                    nombreTemp = nombreTemp.ToUpper();

                    listadoDeNombre.Add(nombreTemp);
                    for (int j = 0; j < pronombres.Length; j++)
                    {
                        if (nombreTemp == pronombres[j])
                        {

                            listadoDeNombre.Remove(nombreTemp);
                        }
                    }
                    it_separador = i + 1;
                }
            }


            for (int i = 0; i < listadoDeNombre.Count; i++)
            {
                busquedaDeLugar = manageData.Tema(listadoDeNombre[i]).Distinct().ToList();
            }
            return busquedaDeLugar;

        }

        private List<int> Clave(string clave)
        {
            //clave
            string claveParaChecar = clave;
            claveParaChecar += " algo";
            string space = " ";
            List<string> listadoDeNombre = new List<string>();
            List<int> busquedaDeLugar = new List<int>();
            int it_separador = 0;
            string[] pronombres = new string[] { "DE", "LOS", "LAS", "LA", "EL" };
            for (int i = 0; i < claveParaChecar.Length; i++)
            {
                if (claveParaChecar[i] == space[0])
                {
                    string nombreTemp = "";
                    for (int j = it_separador; j < i; j++)
                    {

                        nombreTemp += claveParaChecar[j];
                    }
                    nombreTemp = nombreTemp.ToUpper();

                    listadoDeNombre.Add(nombreTemp);
                    for (int j = 0; j < pronombres.Length; j++)
                    {
                        if (nombreTemp == pronombres[j])
                        {

                            listadoDeNombre.Remove(nombreTemp);
                        }
                    }
                    it_separador = i + 1;
                }
            }


            for (int i = 0; i < listadoDeNombre.Count; i++)
            {
                busquedaDeLugar = manageData.Clave(listadoDeNombre[i]).Distinct().ToList();
            }
            return busquedaDeLugar;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.RowIndex);
            
            tablaResultado(indices[e.RowIndex]);
        }

        private void tablaResultado(int indice)
        {
            dataGridView1.Visible = false;
            richTextBox1.Visible = true;
            richTextBox1.Text = manageData.extraccionDatosParaTabla(indice);
        }


    }
}
