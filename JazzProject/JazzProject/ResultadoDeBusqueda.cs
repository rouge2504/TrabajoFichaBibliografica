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
        public void listaResultados(string autor, string titulo, string tema, string tipo)
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

            for (int i = 0; i < Tipo(tipo).Count; i++)
            {
                indices.Add(Tipo(tipo)[i]);
            }


            indices = indices.Distinct().ToList();
            pantallaInicio.label1.Visible = false;
            AddNewLabelTabla(indices);
            //for (int i = 0; i < indices.Count; i++)
            //{

            //    AddNewLabelTabla(indices[i]);
            //}
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
            AddNewLabelTabla(indices);
            //for (int i = 0; i < indices.Count; i++)
            //{

            //    AddNewLabelTabla(indices[i]);
            //}
        }
        public void listaResultados(string autor, string titulo)
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


            indices = indices.Distinct().ToList();
            pantallaInicio.label1.Visible = false;
            AddNewLabelTabla(indices);
            //for (int i = 0; i < indices.Count; i++)
            //{

            //    AddNewLabelTabla(indices[i]);
            //}
        }

        public void listaResultadosAutorTipo(string autor, string tipo)
        {
            //enfocado sin clave
            indices = new List<int>();
            for (int i = 0; i < Autor(autor).Count; i++)
            {
                indices.Add(Autor(autor)[i]);
            }
            for (int i = 0; i < Tipo(tipo).Count; i++)
            {
                indices.Add(Tipo(tipo)[i]);
            }


            indices = indices.Distinct().ToList();
            pantallaInicio.label1.Visible = false;
            AddNewLabelTabla(indices);
            //for (int i = 0; i < indices.Count; i++)
            //{

            //    AddNewLabelTabla(indices[i]);
            //}
        }

        public void listaResultadosTemaTipo(string tema, string tipo)
        {
            //enfocado sin clave
            indices = new List<int>();
            for (int i = 0; i < Tema(tema).Count; i++)
            {
                indices.Add(Tema(tema)[i]);
            }
            for (int i = 0; i < Tipo(tipo).Count; i++)
            {
                indices.Add(Tipo(tipo)[i]);
            }


            indices = indices.Distinct().ToList();
            pantallaInicio.label1.Visible = false;
            AddNewLabelTabla(indices);
            //for (int i = 0; i < indices.Count; i++)
            //{

            //    AddNewLabelTabla(indices[i]);
            //}
        }

        public void listaResultadosAutor(string autor)
        {
            //enfocado puro autor
            indices = new List<int>();
            indices = Autor(autor);
            //for (int i = 0; i < Autor(autor).Count; i++)
            //{
            //    indices.Add(Autor(autor)[i]);
            //}
            indices = indices.Distinct().ToList();
            pantallaInicio.label1.Visible = false;
            AddNewLabelTabla(indices);
            //for (int i = 0; i < indices.Count; i++)
            //{

            //    AddNewLabelTabla(indices[i]);
            //}
        }

        public void listaResultadosTitulo(string titulo)
        {
            //enfocado puro titulo
            indices = new List<int>();
            indices = Titulo(titulo);
            //for (int i = 0; i < Titulo(titulo).Count; i++)
            //{
            //    indices.Add(Titulo(titulo)[i]);
            //}
          


            indices = indices.Distinct().ToList();
            pantallaInicio.label1.Visible = false;
            AddNewLabelTabla(indices);
            //for (int i = 0; i < indices.Count; i++)
            //{

            //    AddNewLabelTabla(indices[i]);
            //}
        }

        public void listaResultadosTema(string tema)
        {
            //enfocado puro titulo
            indices = new List<int>();
            indices = Tema(tema);
            //for (int i = 0; i < Tema(tema).Count; i++)
            //{
            //    indices.Add(Tema(tema)[i]);
            //}
            indices = indices.Distinct().ToList();
            pantallaInicio.label1.Visible = false;
            AddNewLabelTabla(indices);
            //for (int i = 0; i < indices.Count; i++)
            //{

            //    AddNewLabelTabla(indices[i]);
            //}
        }
      


        private void AddNewLabelTabla(List<int> indice)
        {

            //LinkLabel txt = new LinkLabel();
           // this.Controls.Add(txt);
           // txt.LinkClicked += new LinkLabelLinkClickedEventHandler(this.clickTodosLosCampos); //poner lo que se mandara osea un void 
           // txt.Left = 15;
            //txt.Text = manageData.extraccionDatosTodosLosCampos(indice);
            List<string> titulo = new List<string>();
            List<string> autor = new List<string>();
            titulo = manageData.extraccionDatosTitulo(indice);
            autor = manageData.extraccionDatosAutor(indice);
            for (int i = 0; i < indice.Count; i++)
            {
                dataGridView1.Rows.Add(titulo[i], autor[i]);
            }
            //dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["nombreTitulo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["nombreTitulo"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["nombre"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["nombreTitulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
           // txt.AutoSize = true;
            pantallaInicio.label1.Visible = false;
            
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

        private List<int> Tipo(string tipo)
        {
            //tema
            string tipoParaChecar = tipo;
            tipoParaChecar += " algo";
            string space = " ";
            List<string> listadoDeNombre = new List<string>();
            List<int> busquedaDeLugar = new List<int>();
            int it_separador = 0;
            string[] pronombres = new string[] { "DE", "LOS", "LAS", "LA", "EL" };
            for (int i = 0; i < tipoParaChecar.Length; i++)
            {
                if (tipoParaChecar[i] == space[0])
                {
                    string nombreTemp = "";
                    for (int j = it_separador; j < i; j++)
                    {

                        nombreTemp += tipoParaChecar[j];
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
                busquedaDeLugar = manageData.Tipo(listadoDeNombre[i]).Distinct().ToList();
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
            richTextBox2.Visible = true;
            button1.Visible = true;
            richTextBox1.Text = manageData.extraccionDatosParaTabla(indice);
            richTextBox2.Text = manageData.extracionDatosParaNotas (indice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox1.Text);
        }


    }
}
