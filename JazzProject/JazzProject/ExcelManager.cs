using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Collections;
namespace JazzProject
{      
    class ExcelManager
    {
        OleDbConnection comn;
        OleDbDataAdapter MyDataAdapter;
        DataTable dt;


        public void importarExcel(DataGridView dgv)
        {
            string ruta = "";
            try
            {

                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "BASE DE DATOS ejemplo";
               // ruta = "C:\\Users\\Rogelio\\Downloads\\BASE DE DATOS ejemplo";
                ruta = System.IO.Directory.GetCurrentDirectory();
                //if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    if (openfile1.FileName.Equals("") == false)
                //    {
                //        ruta = openfile1.FileName;
                //    }
                //}
                comn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("Select * from [Hoja1$]", comn);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);

                //Debug.WriteLine( dt.Rows[0][2].ToString());
                //Debug.WriteLine(dt.Columns.Count);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private DataTable extraccionDatos()
        {
            DataTable dataT = dt;
            string ruta = "";
            try
            {

                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "BASE DE DATOS ejemplo";
                ruta = "C:\\Users\\Rogelio\\Downloads\\BASE DE DATOS ejemplo uno";
                ruta = System.IO.Directory.GetCurrentDirectory();
                string name = "\\BASE DE DATOS ejemplo";
                //if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    if (openfile1.FileName.Equals("") == false)
                //    {
                //        ruta = openfile1.FileName;
                //    }
                //}
                comn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + name +";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("Select * from [Hoja1$]", comn);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                dataT = dt;
                //Debug.WriteLine( dt.Rows[0][2].ToString());
                //Debug.WriteLine(dt.Columns.Count);
                //dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               
            }
            return dataT;

        }

        public List<int> Autor(string chequeoDeAutor)
        {
            List<int> listaAutor = new List<int>();
            DataTable dt = extraccionDatos();
            //chequeoDeAutor = chequeoDeAutor.ToUpper();
            for (int j = 6; j < 17; j++){
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (string.IsNullOrEmpty(dt.Rows[i][j].ToString())){
                    i++;
                    if (i == dt.Columns.Count) break;
                }
                string autorString = dt.Rows[i][j].ToString(); // separar palabras
                float contador = 0;
                autorString += " algo";
                string space = " ";
                int it_separador = 0;
                List<string> listaTemp = new List<string>();
                for (int s = 0; s < autorString.Length; s++)
                {
                    if (autorString[s] == space[0])
                    {
                        string nombreTemp = "";
                        for (int r = it_separador; r < s; r++)
                        {

                            nombreTemp += autorString[r];
                        }
                        listaTemp.Add(nombreTemp);
                        it_separador = s + 1;
                    }
                }
                for (int it_string = 0; it_string < listaTemp.Count; it_string++)
                {
                    string temp_autorString;
                    temp_autorString = listaTemp[it_string];
                    if (temp_autorString.Length <= chequeoDeAutor.Length)  //para que no truene
                    {
                        for (int a = 0; a < temp_autorString.Length; a++)
                        {

                            if (temp_autorString[a] == chequeoDeAutor[a])
                            {
                                contador++;
                            }

                        }
                        contador = (contador * 100) / chequeoDeAutor.Length;
                    }
                    else if (temp_autorString.Length > chequeoDeAutor.Length)
                    {
                        for (int a = 0; a < chequeoDeAutor.Length; a++)
                        {

                            if (temp_autorString[a] == chequeoDeAutor[a])
                            {
                                contador++;
                            }

                        }
                        contador = (contador * 100) / chequeoDeAutor.Length;
                    }
                    contador /= 10;

                    if (contador > 7)
                    {
                        listaAutor.Add(i);
                    }
                }  //fin del it_String
                }  //fin del pimer for con i
        }//fin del primer for con j
            return listaAutor;  //hay que limpiar esta lista de repetidos
        }

        public List<int> Titulo(string chequeoDeTitulo)
        {
            List<int> listaTitulo = new List<int>();
            DataTable dt = extraccionDatos();
            //chequeoDeTitulo = chequeoDeTitulo.ToUpper();
     
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (string.IsNullOrEmpty(dt.Rows[i][3].ToString()))
                    {
                        i++;
                        if (i == dt.Columns.Count) break;
                    }
                    string autorString = dt.Rows[i][3].ToString(); // separar palabras
                    float contador = 0;
                    autorString += " algo";
                    string space = " ";
                    int it_separador = 0;
                    List<string> listaTemp = new List<string>();
                    for (int s = 0; s < autorString.Length; s++)
                    {
                        if (autorString[s] == space[0])
                        {
                            string nombreTemp = "";
                            for (int r = it_separador; r < s; r++)
                            {

                                nombreTemp += autorString[r];
                            }
                            listaTemp.Add(nombreTemp);
                            it_separador = s + 1;
                        }
                    }
                    for (int it_string = 0; it_string < listaTemp.Count; it_string++)
                    {
                        string temp_autorString;
                        temp_autorString = listaTemp[it_string];
                        if (temp_autorString.Length <= chequeoDeTitulo.Length)  //para que no truene
                        {
                            for (int a = 0; a < temp_autorString.Length; a++)
                            {

                                if (temp_autorString[a] == chequeoDeTitulo[a])
                                {
                                    contador++;
                                }

                            }
                            contador = (contador * 100) / chequeoDeTitulo.Length;
                        }
                        else if (temp_autorString.Length > chequeoDeTitulo.Length)
                        {
                            for (int a = 0; a < chequeoDeTitulo.Length; a++)
                            {

                                if (temp_autorString[a] == chequeoDeTitulo[a])
                                {
                                    contador++;
                                }

                            }
                            contador = (contador * 100) / chequeoDeTitulo.Length;
                        }
                        contador /= 10;

                        if (contador > 7)
                        {
                            listaTitulo.Add(i);
                        }
                    }  //fin del it_String
                }  //fin del pimer for con i
     
            return listaTitulo;  //hay que limpiar esta lista de repetidos
        }

        public List<int> Tema(string chequeoDeTema)
        {
            List<int> listaTema = new List<int>();
            DataTable dt = extraccionDatos();
            //chequeoDeTema = chequeoDeTema.ToUpper();

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (string.IsNullOrEmpty(dt.Rows[i][28].ToString()))
                {
                    i++;
                    if (i == dt.Columns.Count) break;
                }
                string autorString = dt.Rows[i][28].ToString(); // separar palabras
                float contador = 0;
                autorString += " algo";
                string space = " ";
                int it_separador = 0;
                List<string> listaTemp = new List<string>();
                for (int s = 0; s < autorString.Length; s++)
                {
                    if (autorString[s] == space[0])
                    {
                        string nombreTemp = "";
                        for (int r = it_separador; r < s; r++)
                        {

                            nombreTemp += autorString[r];
                        }
                        listaTemp.Add(nombreTemp);
                        it_separador = s + 1;
                    }
                }
                for (int it_string = 0; it_string < listaTemp.Count; it_string++)
                {
                    string temp_autorString;
                    temp_autorString = listaTemp[it_string];
                    if (temp_autorString.Length <= chequeoDeTema.Length)  //para que no truene
                    {
                        for (int a = 0; a < temp_autorString.Length; a++)
                        {

                            if (temp_autorString[a] == chequeoDeTema[a])
                            {
                                contador++;
                            }

                        }
                        contador = (contador * 100) / chequeoDeTema.Length;
                    }
                    else if (temp_autorString.Length > chequeoDeTema.Length)
                    {
                        for (int a = 0; a < chequeoDeTema.Length; a++)
                        {

                            if (temp_autorString[a] == chequeoDeTema[a])
                            {
                                contador++;
                            }

                        }
                        contador = (contador * 100) / chequeoDeTema.Length;
                    }
                    contador /= 10;

                    if (contador > 7)
                    {
                        listaTema.Add(i);
                    }
                }  //fin del it_String
            }  //fin del pimer for con i

            return listaTema;  //hay que limpiar esta lista de repetidos
        }

        public string extraccionDatosTodosLosCampos(int indice)
        {
            DataTable dt = extraccionDatos();
            string autor = dt.Rows[indice][6].ToString() + dt.Rows[indice][7].ToString() + dt.Rows[indice][8].ToString();
            string titulo = dt.Rows[indice][3].ToString();
            string subtitulo = dt.Rows[indice][4].ToString();
           // string subtitulo = dt.Rows[indice][5].ToString();
            if (string.IsNullOrEmpty(subtitulo))
            {
                subtitulo = "";
            }

            if (string.IsNullOrEmpty(autor))
            {
                autor = "sin autor";
            }
            string resultado = autor + "; " + titulo + "; " + subtitulo;
            return resultado;
        }

        public string extraccionDatosAutor(int indice)
        {
            DataTable dt = extraccionDatos();
            string autor = dt.Rows[indice][6].ToString() + " " + dt.Rows[indice][7].ToString() + " " + dt.Rows[indice][8].ToString()
                + " " + "\n" + dt.Rows[indice][9].ToString() + " " + dt.Rows[indice][10].ToString() + " " + dt.Rows[indice][11].ToString()
                 + " " + "\n" + dt.Rows[indice][12].ToString() + " " + dt.Rows[indice][13].ToString()
                  + " " + "\n" + dt.Rows[indice][14].ToString()
                  + " "+"\n" + dt.Rows[indice][15].ToString();

            if (string.IsNullOrEmpty(autor))
            {
                autor = "sin autor";
            }
            string resultado = autor;
            return resultado;
        }

        public string extraccionDatosTitulo(int indice)
        {
            DataTable dt = extraccionDatos();
            string titulo = dt.Rows[indice][3].ToString();
            // string subtitulo = dt.Rows[indice][5].ToString();
 
            string resultado = titulo;
            return resultado;
        }
    }
}
