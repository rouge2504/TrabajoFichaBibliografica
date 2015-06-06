using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
namespace JazzProject
{
    class Importar
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
                ruta = "C:\\Users\\Rogelio\\Downloads\\BASE DE DATOS ejemplo";
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
              
                Debug.WriteLine( dt.Rows[0][2].ToString());
                //Debug.WriteLine(dt.Columns.Count);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
