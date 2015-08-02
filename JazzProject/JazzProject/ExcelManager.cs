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
using System.Drawing;
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
                string autorString = dt.Rows[i][j].ToString();
                
            }
                }
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
                    if (chequeoDeAutor[0] == '\u0022' && chequeoDeAutor[chequeoDeAutor.Length - 1] == '\u0022')
                    {
                        if (contador > 9)
                        {
                            listaAutor.Add(i);
                        }
                    }
                    else
                    {
                        if (contador > 7)
                        {
                            listaAutor.Add(i);
                        }
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
                        if (chequeoDeTitulo[0] == '\u0022' && chequeoDeTitulo[chequeoDeTitulo.Length - 1] == '\u0022')
                        {
                            if (contador > 9)
                            {
                                listaTitulo.Add(i);
                            }
                        }
                        else
                        {
                            if (contador > 7)
                            {
                                listaTitulo.Add(i);
                            }
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
                    if (chequeoDeTema[0] == '\u0022' && chequeoDeTema[chequeoDeTema.Length - 1] == '\u0022')
                    {
                        if (contador > 9)
                        {
                            listaTema.Add(i);
                        }
                    }
                    else
                    {
                        if (contador > 7)
                        {
                            listaTema.Add(i);
                        }
                    }
                }  //fin del it_String
            }  //fin del pimer for con i

            return listaTema;  //hay que limpiar esta lista de repetidos
        }

        public List<int> Tipo(string chequeoDeTipo)
        {
            List<int> listaTipo = new List<int>();
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
                    if (temp_autorString.Length <= chequeoDeTipo.Length)  //para que no truene
                    {
                        for (int a = 0; a < temp_autorString.Length; a++)
                        {

                            if (temp_autorString[a] == chequeoDeTipo[a])
                            {
                                contador++;
                            }

                        }
                        contador = (contador * 100) / chequeoDeTipo.Length;
                    }
                    else if (temp_autorString.Length > chequeoDeTipo.Length)
                    {
                        for (int a = 0; a < chequeoDeTipo.Length; a++)
                        {

                            if (temp_autorString[a] == chequeoDeTipo[a])
                            {
                                contador++;
                            }

                        }
                        contador = (contador * 100) / chequeoDeTipo.Length;
                    }
                    contador /= 10;
                    if (chequeoDeTipo[0] == '\u0022' && chequeoDeTipo[chequeoDeTipo.Length - 1] == '\u0022')
                    {
                        if (contador > 9)
                        {
                            listaTipo.Add(i);
                        }
                    }
                    else
                    {
                        if (contador > 7)
                        {
                            listaTipo.Add(i);
                        }
                    }
                }  //fin del it_String
            }  //fin del pimer for con i

            return listaTipo;  //hay que limpiar esta lista de repetidos
        }
    



        public string extraccionDatosParaTabla(int indice)
        {
            DataTable dt = extraccionDatos();
            string[] autor = new string[3];
            for (int i = 0; i < 2; i++)
            {
                autor[i] = Gramatica(dt.Rows[indice][6 + (i * 3)].ToString()) + Gramatica(dt.Rows[indice][7 + (i * 3)].ToString()) + Gramatica(Concatenar(", ", dt.Rows[indice][8 + (i * 3)].ToString()));
                if (string.IsNullOrEmpty(autor[i]))
                {
                    autor[i] = "";
                }
            }
            autor[2] = Gramatica(Concatenar(dt.Rows[indice][12].ToString()) + Gramatica(dt.Rows[indice][13].ToString()));
            string tipo = dt.Rows[indice][2].ToString();
            string titulo = Gramatica(Concatenar(dt.Rows[indice][3].ToString()));
            string subtitulo = Concatenar(dt.Rows[indice][4].ToString());
            string coord = Concatenar("(Coord.) ", Concatenar(dt.Rows[indice][16].ToString()) + Concatenar(dt.Rows[indice][17].ToString()) + Concatenar(dt.Rows[indice][18].ToString()));
            string traduccion = Concatenar("trad. de ", dt.Rows[indice][19].ToString());
            string edicion = Concatenar("ed. ", dt.Rows[indice][20].ToString());
            string lugar = Concatenar(dt.Rows[indice][21].ToString());
            string año = Concatenar(dt.Rows[indice][22].ToString());
            string editorial = Concatenar(dt.Rows[indice][23].ToString());
            string serie = Concatenar(dt.Rows[indice][24].ToString());
            string volumen = Concatenar("t. ",dt.Rows[indice][25].ToString());
            string paginas = Concatenar("p. ", dt.Rows[indice][27].ToString());


            FontFamily family = new FontFamily("Times New Roman");

            Font font = new Font(family, 16.0f,
            FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);

            string resultado = "";
            if (tipo == "LIBRO" || tipo == "DICCIONARIO" || tipo == "COLECCIÓN" || tipo == "LEY" || tipo == "CUADERNILLO")
            {
                if (!string.IsNullOrEmpty(autor[2]) && !string.IsNullOrEmpty(autor[1]))
                {
                    resultado = autor[0] + " et al, " + coord + titulo + subtitulo + traduccion + edicion + lugar + editorial + año + serie + volumen + paginas + ".";
                }
                if (string.IsNullOrEmpty(autor[2]) && !string.IsNullOrEmpty(autor[1]))
                {
                    resultado = autor[0] + " y " + Concatenar(autor[1]) + coord + titulo + subtitulo + traduccion + edicion + lugar + editorial + año + serie + volumen + paginas + ".";
                }
                if (string.IsNullOrEmpty(autor[2]) && string.IsNullOrEmpty(autor[1]))
                {
                    resultado = autor[0] + ", " + coord + titulo + subtitulo + traduccion + edicion + lugar + editorial + año + serie + volumen + paginas + ".";
                }
            }
            if (tipo == "ARTÍCULO")
            {
                if (!string.IsNullOrEmpty(autor[2]) && !string.IsNullOrEmpty(autor[1]))
                {
                    resultado = autor[0] + " et al, " + "\u0022" + "Articulo" + "\u0022 " + coord + titulo + subtitulo + traduccion + edicion + lugar + editorial + año + serie + volumen + paginas + ".";
                }
                if (string.IsNullOrEmpty(autor[2]) && !string.IsNullOrEmpty(autor[1]))
                {
                    resultado = autor[0] + " y " + autor[1] + "\u0022" + "Articulo" + "\u0022 " + coord + titulo + subtitulo + traduccion + edicion + lugar + editorial + año + serie + volumen + paginas + ".";
                }
                if (string.IsNullOrEmpty(autor[2]) && string.IsNullOrEmpty(autor[1]))
                {
                    resultado = autor[0] + ", " + "\u0022" + "Articulo" + "\u0022 " + coord + titulo + subtitulo + traduccion + edicion + lugar + editorial + año + serie + volumen + paginas + ".";
                }
            }
            if (tipo == "REVISTA" )
            {
                    resultado = coord + titulo + subtitulo + traduccion + lugar + serie + Concatenar(dt.Rows[indice][35].ToString()) + volumen + Concatenar(dt.Rows[indice][34].ToString()) + Concatenar(dt.Rows[indice][33].ToString()) + editorial+ año + paginas + edicion +".";
                
            }

            return resultado;
        }

        public string extracionDatosParaNotas(int indice)
        {
            DataTable dt = extraccionDatos();
            string clasificacion = dt.Rows[indice][28].ToString();
            //string prestado = dt.Rows[indice][40].ToString();
            string ISBN_ISSN = "";// = dt.Rows[indice][31].ToString() + dt.Rows[indice][32].ToString();
            string prestado = "";
            string web = dt.Rows[indice][37].ToString();
            if (string.IsNullOrEmpty(dt.Rows[indice][31].ToString()) || string.IsNullOrEmpty(dt.Rows[indice][32].ToString()))
            {
                ISBN_ISSN = "";
            }
            else if (!string.IsNullOrEmpty(dt.Rows[indice][31].ToString()) || string.IsNullOrEmpty(dt.Rows[indice][32].ToString()))
            {
                ISBN_ISSN = dt.Rows[indice][31].ToString();
            }
            else if (string.IsNullOrEmpty(dt.Rows[indice][31].ToString()) || !string.IsNullOrEmpty(dt.Rows[indice][32].ToString()))
            {
                ISBN_ISSN = dt.Rows[indice][32].ToString();
            }
            else if (!string.IsNullOrEmpty(dt.Rows[indice][31].ToString()) || !string.IsNullOrEmpty(dt.Rows[indice][32].ToString()))
            {
                ISBN_ISSN = dt.Rows[indice][31].ToString() + " - " + dt.Rows[indice][32].ToString();
            }
            if (dt.Rows[indice][40].ToString() == "SI")
            {
                prestado = dt.Rows[indice][42].ToString() + ", " + dt.Rows[indice][41].ToString();
            }
            else if (dt.Rows[indice][40].ToString() == "NO" || string.IsNullOrEmpty(dt.Rows[indice][40].ToString()))
            {
                prestado = "";
            }
       
            string resultado = "";

            if (string.IsNullOrEmpty(clasificacion) && string.IsNullOrEmpty(ISBN_ISSN)
                && string.IsNullOrEmpty(web) && string.IsNullOrEmpty(prestado))
            {
                 resultado = "No hay notas";
            }
            else if (!string.IsNullOrEmpty(clasificacion) && !string.IsNullOrEmpty(ISBN_ISSN)
                && !string.IsNullOrEmpty(web) && !string.IsNullOrEmpty(prestado))
            {
                resultado = clasificacion + "\n" + "Notas:\n" + ISBN_ISSN + "\n" + web + "\n" + prestado;
            }
            else if (string.IsNullOrEmpty(clasificacion) && !string.IsNullOrEmpty(ISBN_ISSN)
                && !string.IsNullOrEmpty(web) && !string.IsNullOrEmpty(prestado))
            {
                resultado = "Notas:\n" + ISBN_ISSN + "\n" + web + "\n" + prestado;
            }
            else if (string.IsNullOrEmpty(clasificacion) && string.IsNullOrEmpty(ISBN_ISSN)
                && !string.IsNullOrEmpty(web) && !string.IsNullOrEmpty(prestado))
            {
                resultado = "Notas:\n" + web + "\n" + prestado;
            }
            else if (string.IsNullOrEmpty(clasificacion) && string.IsNullOrEmpty(ISBN_ISSN)
                && string.IsNullOrEmpty(web) && !string.IsNullOrEmpty(prestado))
            {
                resultado = "\n" + "Notas:\n" + prestado;
            }
            else if (!string.IsNullOrEmpty(clasificacion) && !string.IsNullOrEmpty(ISBN_ISSN)
                && !string.IsNullOrEmpty(web) && string.IsNullOrEmpty(prestado))
            {
                resultado = clasificacion + "\n" + "Notas:\n" + ISBN_ISSN + "\n" + web;
            }
            else if (!string.IsNullOrEmpty(clasificacion) && !string.IsNullOrEmpty(ISBN_ISSN)
                && string.IsNullOrEmpty(web) && string.IsNullOrEmpty(prestado))
            {
                resultado = clasificacion + "\n" + "Notas:\n" + ISBN_ISSN;
            }
            else if (!string.IsNullOrEmpty(clasificacion) && string.IsNullOrEmpty(ISBN_ISSN)
                && string.IsNullOrEmpty(web) && string.IsNullOrEmpty(prestado))
            {
                resultado = clasificacion;
            }
            else if (string.IsNullOrEmpty(clasificacion) && string.IsNullOrEmpty(ISBN_ISSN)
                && !string.IsNullOrEmpty(web) && string.IsNullOrEmpty(prestado))
            {
                resultado = "Notas:\n" + " Web: " +web;
            }

            else if (string.IsNullOrEmpty(clasificacion) && !string.IsNullOrEmpty(ISBN_ISSN)
                && string.IsNullOrEmpty(web) && string.IsNullOrEmpty(prestado))
            {
                resultado = "Notas:\n" + ISBN_ISSN;
            }

            return resultado;
        }

        private string Concatenar(string palabra)
        {
            
            if (string.IsNullOrEmpty(palabra))
            {
                palabra = "";
            }
            else
            {
                palabra += ", ";
            }
            return palabra;
        }

        private string Concatenar(string palabraPoner, string palabra)
        {

            if (string.IsNullOrEmpty(palabra))
            {
                palabra = "";
            }
            else
            {
                palabra = palabraPoner + palabra +", ";
            }
            return palabra;
        }

        public List<string> extraccionDatosAutor(List<int> indice)
        {
            DataTable dt = extraccionDatos();
           // string autor = dt.Rows[indice][6].ToString() + " " + dt.Rows[indice][7].ToString() + " " + dt.Rows[indice][8].ToString();
            List<string> autor = new List<string>();

            for (int i = 0; i < indice.Count; i++)
            {
                autor.Add(dt.Rows[indice[i]][6].ToString() + " " + dt.Rows[indice[i]][7].ToString() + " " + dt.Rows[indice[i]][8].ToString());
                if (!string.IsNullOrEmpty(dt.Rows[indice[i]][9].ToString()))
                {
                    autor[i] = autor[i] + " " + "\n" + dt.Rows[indice[i]][9].ToString() + " " + dt.Rows[indice[i]][10].ToString() + " " + dt.Rows[indice[i]][11].ToString();
                }

                if (!string.IsNullOrEmpty(dt.Rows[indice[i]][12].ToString()))
                {
                    autor[i] = autor[i] + " " + "\n" + dt.Rows[indice[i]][12].ToString() + " " + dt.Rows[indice[i]][13].ToString();
                }

                if (!string.IsNullOrEmpty(dt.Rows[indice[i]][14].ToString()))
                {
                    autor[i] = autor[i] + " " + "\n" + dt.Rows[indice[i]][14].ToString();
                }

                if (!string.IsNullOrEmpty(dt.Rows[indice[i]][15].ToString()))
                {
                    autor[i] = autor[i] + " " + "\n" + dt.Rows[indice[i]][15].ToString();
                }

                if (string.IsNullOrEmpty(autor[i]))
                {
                    autor[i] = "sin autor";
                }

            } //fin del for
            //string resultado = autor;
            return autor;
            //return resultado;
        }
        public List<string> busquedaPrestados()
        {
            List<string> prestados = new List<string>();
            DataTable dt = extraccionDatos();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (dt.Rows[i][40].ToString() == "SI")
                {
                    prestados.Add(dt.Rows[i][40].ToString() + " " + dt.Rows[i][41].ToString() + " " + dt.Rows[i][42].ToString() + " " + dt.Rows[i][41].ToString());

                }
            }
            return prestados;
        }
 
        public List <string> extraccionDatosTitulo(List<int> indice)
        {
            DataTable dt = extraccionDatos();

            //List<string> clasificacion = new List<string>();
            //List<string> tema = new List<string>();
            //List<string> tipo = new List<string>();
            //List<string> titulo = new List<string>();
            //List<string> subtitulo = new List<string>();
            //List<string> articulo = new List<string>();
            List<string> resultado = new List<string>();

            for (int i = 0; i < indice.Count; i++)
            {

                string clasificacion = dt.Rows[indice[i]][28].ToString();
                string tema = dt.Rows[indice[i]][39].ToString();
                string tipo = dt.Rows[indice[i]][2].ToString();
                string titulo = dt.Rows[indice[i]][3].ToString();
                string subtitulo = dt.Rows[indice[i]][4].ToString();
                string articulo = dt.Rows[indice[i]][5].ToString();
        
                //string resultado = "";
                //clasificacion.Add(dt.Rows[i][28].ToString());
                //tema.Add(dt.Rows[i][39].ToString());
                // tipo.Add(dt.Rows[i][2].ToString());
                // titulo.Add(dt.Rows[i][3].ToString());
                // subtitulo.Add(dt.Rows[i][4].ToString());
                // articulo.Add(dt.Rows[i][5].ToString());

                 if (!string.IsNullOrEmpty(clasificacion) && !string.IsNullOrEmpty(tema) && !string.IsNullOrEmpty(titulo)
                     && !string.IsNullOrEmpty(subtitulo) && !string.IsNullOrEmpty(articulo))
                {
                    resultado.Add(clasificacion + " y " + tema + "\n" + tipo + " " + '\u0022' + titulo + '\u0022' + ", " + subtitulo + ", " + articulo);

                }
                 if (string.IsNullOrEmpty(clasificacion) && !string.IsNullOrEmpty(tema) && !string.IsNullOrEmpty(titulo)
                     && !string.IsNullOrEmpty(subtitulo) && !string.IsNullOrEmpty(articulo))
                {
                    resultado.Add( tema + "\n" + tipo + " " + '\u0022' + titulo + '\u0022' + ", " + subtitulo + ", " + articulo);

                }
                 if (!string.IsNullOrEmpty(clasificacion) && string.IsNullOrEmpty(tema) && !string.IsNullOrEmpty(titulo)
                     && !string.IsNullOrEmpty(subtitulo) && !string.IsNullOrEmpty(articulo))
                {
                    resultado.Add(clasificacion + "\n" + tipo + " " + '\u0022' + titulo + '\u0022' + ", " + subtitulo + ", " + articulo);

                }
                 if (!string.IsNullOrEmpty(clasificacion) && string.IsNullOrEmpty(tema) && !string.IsNullOrEmpty(titulo)
                     && !string.IsNullOrEmpty(subtitulo) && string.IsNullOrEmpty(articulo))
                {
                    resultado.Add( clasificacion + "\n" + tipo + " " + '\u0022' + titulo + '\u0022' + ", " + subtitulo);

                }
                 if (string.IsNullOrEmpty(clasificacion) && string.IsNullOrEmpty(tema) && !string.IsNullOrEmpty(titulo)
                     && !string.IsNullOrEmpty(subtitulo) && !string.IsNullOrEmpty(articulo))
                {
                    resultado.Add(tipo + " " + '\u0022' + titulo + '\u0022' + ", " + subtitulo + ", " + articulo);

                }
                 if (string.IsNullOrEmpty(clasificacion) && string.IsNullOrEmpty(tema) && !string.IsNullOrEmpty(titulo)
                     && string.IsNullOrEmpty(subtitulo) && !string.IsNullOrEmpty(articulo))
                {
                    resultado.Add(tipo + " " + '\u0022' + titulo + '\u0022' + ", " + articulo);

                }
                 if (string.IsNullOrEmpty(clasificacion) && string.IsNullOrEmpty(tema) && !string.IsNullOrEmpty(titulo)
                     && string.IsNullOrEmpty(subtitulo) && string.IsNullOrEmpty(articulo))
                {
                    resultado.Add(tipo + " " + '\u0022' + titulo + '\u0022');

                }
                 if (string.IsNullOrEmpty(clasificacion) && string.IsNullOrEmpty(tema) && !string.IsNullOrEmpty(titulo)
                     && !string.IsNullOrEmpty(subtitulo) && string.IsNullOrEmpty(articulo))
                {
                    resultado.Add( tipo + " " + '\u0022' + titulo + '\u0022' + ", " + subtitulo);

                }
                 if (!string.IsNullOrEmpty(clasificacion) && string.IsNullOrEmpty(tema) && !string.IsNullOrEmpty(titulo)
                     && string.IsNullOrEmpty(subtitulo) && string.IsNullOrEmpty(articulo))
                 {
                     resultado.Add(tipo + " " + '\u0022' + titulo + '\u0022');

                 }
                 if (!string.IsNullOrEmpty(clasificacion) && string.IsNullOrEmpty(tema) && !string.IsNullOrEmpty(titulo)
                      && string.IsNullOrEmpty(subtitulo) && !string.IsNullOrEmpty(articulo))
                 {
                     resultado.Add(tipo + " " + '\u0022' + titulo + '\u0022');

                 }
            } // fin del for
            //string resultado = titulo;
            //string regresoResultado = resultado;
           // return regresoResultado;
            return resultado;
        }

        private string Gramatica(string palabra)
        {

            if (string.IsNullOrEmpty(palabra))
            {
                return "";
            }
            string palabraParaChecar = palabra;
            palabraParaChecar += " algo";
            string space = " ";
            List<string> listadoDeNombre = new List<string>();
            string nombre = "";
            //List<int> busquedaDeLugar = new List<int>();
            int it_separador = 0;

            for (int i = 0; i < palabraParaChecar.Length; i++)
            {
                if (palabraParaChecar[i] == space[0])
                {
                    string nombreTemp = "";
                    nombreTemp = palabraParaChecar[it_separador].ToString();
                    for (int j = it_separador + 1; j < i; j++)
                    {
                        nombreTemp += palabraParaChecar[j].ToString().ToLower();
                    }
                    //nombreTemp = nombreTemp.ToUpper();

                    listadoDeNombre.Add(nombreTemp);


                    it_separador = i + 1;
                }
            }
            for (int i = 0; i < listadoDeNombre.Count; i++)
            {
                if (i < listadoDeNombre.Count - 1)
                {
                    nombre += listadoDeNombre[i] + " ";
                }
                else if (i >= listadoDeNombre.Count - 1)
                {
                    nombre += listadoDeNombre[i];
                }
        
            }
            return nombre;
        }
    }
}
