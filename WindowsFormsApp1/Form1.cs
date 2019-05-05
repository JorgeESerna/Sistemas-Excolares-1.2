using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using ClosedXML.Excel;
using System.Runtime.InteropServices;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;
        //MySqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void cargadatos()
        {
            try
            {
                dataGridView1.Rows.Clear();
                mySqlConnection = new MySqlConnection("host=localhost;user=root;password=admin;database=sistemas_escolar;"); // String de connexion
                mySqlConnection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT matricula as 'Expediente', UPPER(ap1) as 'Apellido P', UPPER(ap2) as 'Apellido M', UPPER(nombre) as 'Primer Nombre', Fnacimiento, correo, telefono FROM alumnos", mySqlConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargadatos();
            Vista();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_matricula.Enabled = false;
            tb_matricula.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            tb_ap1.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            tb_ap2.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            tb_name.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1[4, e.RowIndex].Value.ToString());
            tb_correo.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            tb_tel.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }






        private void bt_pdf_click(object sender, EventArgs e)
        {
            try
            {
               
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "pdf"; // nombre de la ventana
                saveFileDialog1.FileName = "*.pdf"; // nombre del archivo
                saveFileDialog1.InitialDirectory = @"C:\Users\unuse\source\repos\Sistemas-Excolares-1.2\WindowsFormsApp1prueba"; // direccion inicial
                saveFileDialog1.Filter = "archivo pdf |*.pdf"; // tipo de archivo(formato)
                saveFileDialog1.ShowDialog();
                string archivo;
                archivo = saveFileDialog1.FileName;

                MessageBox.Show(archivo);

                Document documento = new Document(iTextSharp.text.PageSize.LETTER.Rotate());
                PdfWriter.GetInstance(documento, new FileStream(saveFileDialog1.FileName, FileMode.Create));
                documento.Open();
                PdfPTable tablepdf = new PdfPTable(7);
                PdfPCell titulo = new PdfPCell(new Phrase("Base de Datos"));
                titulo.Colspan = 7;
                tablepdf.AddCell(titulo);
                tablepdf.AddCell("Matricula");
                tablepdf.AddCell("Apellido Paterno");
                tablepdf.AddCell("Apellido Materno");
                tablepdf.AddCell("Nombre");
                tablepdf.AddCell("Fecha de Nacimiento");
                tablepdf.AddCell("Correo");
                tablepdf.AddCell("Telefono");

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    tablepdf.AddCell(dataGridView1[0, i].Value.ToString());
                    tablepdf.AddCell(dataGridView1[1, i].Value.ToString());
                    tablepdf.AddCell(dataGridView1[2, i].Value.ToString());
                    tablepdf.AddCell(dataGridView1[3, i].Value.ToString());
                    tablepdf.AddCell(dataGridView1[4, i].Value.ToString());
                    tablepdf.AddCell(dataGridView1[5, i].Value.ToString());
                    tablepdf.AddCell(dataGridView1[6, i].Value.ToString());
                }




                documento.Add(tablepdf);
                documento.Close();
            }
            catch (Exception error)
            {

                MessageBox.Show(error + "Eror");
            }
        }

        private void bt_sql_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "sql"; // nombre de la ventana
            saveFileDialog1.FileName = "*.sql"; // nombre del archivo
            saveFileDialog1.InitialDirectory = @"C:\Users\Monge\source\repos\WindowsFormsApp1\prueba"; // direccion inicial
            saveFileDialog1.Filter = "archivo sql |*.sql"; // tipo de archivo(formato)
            saveFileDialog1.ShowDialog();

            string archivo;
            archivo = saveFileDialog1.FileName;
            MessageBox.Show(archivo);
        }

        private void bt_pdf_Click_1(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "pdf"; // nombre de la ventana
                saveFileDialog1.FileName = "*.pdf"; // nombre del archivo
                saveFileDialog1.InitialDirectory = @"C:\Users\unuse\source\repos\Sistemas-Excolares-1.2\WindowsFormsApp1prueba"; // direccion inicial
                saveFileDialog1.Filter = "archivo pdf |*.pdf"; // tipo de archivo(formato)
                saveFileDialog1.ShowDialog();
                string archivo;
                archivo = saveFileDialog1.FileName;

                MessageBox.Show(archivo);

                Document documento = new Document(iTextSharp.text.PageSize.LETTER.Rotate());
                PdfWriter.GetInstance(documento, new FileStream(saveFileDialog1.FileName, FileMode.Create));
                documento.Open();
                PdfPTable tablepdf = new PdfPTable(7);
                PdfPCell titulo = new PdfPCell(new Phrase("Base de Datos"));
                titulo.Colspan = 7;
                tablepdf.AddCell(titulo);
                tablepdf.AddCell("Matricula");
                tablepdf.AddCell("Apellido Paterno");
                tablepdf.AddCell("Apellido Materno");
                tablepdf.AddCell("Nombre");
                tablepdf.AddCell("Fecha de Nacimiento");
                tablepdf.AddCell("Correo");
                tablepdf.AddCell("Telefono");

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    tablepdf.AddCell(dataGridView1[0, i].Value.ToString());
                    tablepdf.AddCell(dataGridView1[1, i].Value.ToString());
                    tablepdf.AddCell(dataGridView1[2, i].Value.ToString());
                    tablepdf.AddCell(dataGridView1[3, i].Value.ToString());
                    tablepdf.AddCell(dataGridView1[4, i].Value.ToString());
                    tablepdf.AddCell(dataGridView1[5, i].Value.ToString());
                    tablepdf.AddCell(dataGridView1[6, i].Value.ToString());
                }




                documento.Add(tablepdf);
                documento.Close();
            }
            catch (Exception error)
            {

                MessageBox.Show(error + "");
            }
        }

        private void bt_csv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "csv"; // nombre de la ventana
            saveFileDialog1.FileName = "*.csv"; // nombre del archivo
            saveFileDialog1.InitialDirectory = @"C:\Users\unuse\source\repos\Sistemas_escolar\WindowsFormsApp1prueba"; // direccion inicial
            saveFileDialog1.Filter = "archivo csv |*.csv"; // tipo de archivo(formato)
            saveFileDialog1.ShowDialog();

            string archivo;
            archivo = saveFileDialog1.FileName;
            MessageBox.Show(archivo);

            StreamWriter writer = new StreamWriter(archivo);
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if ((i + 1) == dataGridView1.ColumnCount)
                {
                    writer.Write(dataGridView1.Columns[i].HeaderText + '\n');
                }

                else
                {
                    writer.Write(dataGridView1.Columns[i].HeaderText + ";");
                }

            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                writer.WriteLine((dataGridView1[0, i].Value.ToString() + ";" + dataGridView1[1, i].Value.ToString() + ";" + dataGridView1[2, i].Value.ToString() + ";" + dataGridView1[3, i].Value.ToString() + ";" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Year + "-" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Month + "-" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Day + ";" + dataGridView1[5, i].Value.ToString() + ";" + dataGridView1[6, i].Value.ToString()));
            }
            writer.Close();
        }

        private void btnredondo1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO alumnos (matricula,ap1,ap2,nombre,Fnacimento,correo,telefono) VALUES (" + tb_matricula.Text + ",'" + tb_ap1.Text + "','" + tb_ap2.Text + "','" + tb_name.Text + "','" + dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day + "','" + tb_correo.Text + "'," + tb_tel.Text + ")";
            //MessageBox.Show(query);

            try
            {
                mySqlConnection = new MySqlConnection("host=localhost;user=root;password=admin;database=sistemas_escolar;"); // String de connexion
                mySqlConnection.Open();
                mySqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Agregado con Exito");

                cargadatos();
                mySqlConnection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnredondo2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM alumnos WHERE matricula=" + tb_matricula.Text;


            try
            {
                mySqlConnection = new MySqlConnection("host=localhost;user=root;password=admin;database=sistemas_escolar;"); // String de connexion
                mySqlConnection.Open();
                mySqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Agregado con Exito");

                cargadatos();
                mySqlConnection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Vista()
        {
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                if (i % 2 == 1)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.SteelBlue;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }

        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "csv"; // nombre de la ventana
            saveFileDialog1.FileName = "*.csv"; // nombre del archivo
            saveFileDialog1.InitialDirectory = @"C:\Users\unuse\source\repos\Sistemas_escolar\WindowsFormsApp1prueba"; // direccion inicial
            saveFileDialog1.Filter = "archivo csv |*.csv"; // tipo de archivo(formato)
            saveFileDialog1.ShowDialog();

            string archivo;
            archivo = saveFileDialog1.FileName;
            MessageBox.Show(archivo);

            var workbook = new XLWorkbook();
            var hoja = workbook.Worksheets.Add("Alumnos");
            hoja.Cell(1, 1).Value = "Matricula";
            hoja.Cell(1, 1).Style.Font.Bold = true;
            hoja.Cell(1, 2).Value = "Apellido P";
            hoja.Cell(1, 2).Style.Font.Bold = true;
            hoja.Cell(1, 3).Value = "Apellido M";
            hoja.Cell(1, 3).Style.Font.Bold = true;
            hoja.Cell(1, 4).Value = "Nombre";
            hoja.Cell(1, 4).Style.Font.Bold = true;
            hoja.Cell(1, 5).Value = "fechadenacimento";
            hoja.Cell(1, 5).Style.Font.Bold = true;
            hoja.Cell(1, 6).Value = "Correo";
            hoja.Cell(1, 6).Style.Font.Bold = true;
            hoja.Cell(1, 7).Value = "Telefono";
            hoja.Cell(1, 7).Style.Font.Bold = true;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    hoja.Cell((i + 2), (k + 1)).Value = dataGridView1.Rows[i].Cells[k].Value.ToString();
                }
            }
            //hoja.Cell(1, 1).Value="lo que tu quieras";
            workbook.SaveAs(archivo);
        }

        private void bjson_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "csv"; // nombre de la ventana
            saveFileDialog1.FileName = "*.csv"; // nombre del archivo
            saveFileDialog1.InitialDirectory = @"C:\Users\unuse\source\repos\Sistemas_escolar\WindowsFormsApp1prueba"; // direccion inicial
            saveFileDialog1.Filter = "archivo csv |*.csv"; // tipo de archivo(formato)
            saveFileDialog1.ShowDialog();

            string archivo;
            archivo = saveFileDialog1.FileName;
            MessageBox.Show(archivo);
            StreamWriter writer = new StreamWriter(archivo);
            writer.WriteLine("{ \"sistema_escolar\" :");
            writer.WriteLine("\t{");
            writer.WriteLine("\t\t\"alumnos\": [");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((i + 1) == dataGridView1.Rows.Count)
                {
                    writer.WriteLine("\t\t{\n" + ("\t\t\t\"Matricula\":" + dataGridView1[0, i].Value.ToString() + ","
                        + "\n\t\t\t\"Apellido P\":" + "\"" + dataGridView1[1, i].Value.ToString() + "\","
                        + "\n\t\t\t\"Apellido M\":" + "\"" + dataGridView1[2, i].Value.ToString() + "\","
                        + "\n\t\t\t\"Nombre\":" + "\"" + dataGridView1[3, i].Value.ToString() + "\","
                        + "\n\t\t\t\"Fecha de nacmiento\":" + "\""
                        + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Year + "-" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Month + "-" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Day + "\","
                        + "\n\t\t\t\"Correo\":" + "\"" + dataGridView1[5, i].Value.ToString() + "\","
                        + "\n\t\t\t\"Telefono\":" + dataGridView1[6, i].Value.ToString() + "," + "\n\t\t}"));

                }
                else
                {
                    writer.WriteLine("\t\t{\n" + ("\t\t\t\"Matricula\":" + dataGridView1[0, i].Value.ToString() + ","
                        + "\n\t\t\t\"Apellido P\":" + "\"" + dataGridView1[1, i].Value.ToString() + "\","
                        + "\n\t\t\t\"Apellido M\":" + "\"" + dataGridView1[2, i].Value.ToString() + "\","
                        + "\n\t\t\t\"Nombre\":" + "\"" + dataGridView1[3, i].Value.ToString() + "\","
                        + "\n\t\t\t\"Fecha de nacmiento\":" + "\""
                        + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Year + "-" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Month + "-" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Day + "\","
                        + "\n\t\t\t\"Correo\":" + "\"" + dataGridView1[5, i].Value.ToString() + "\","
                        + "\n\t\t\t\"Telefono\":" + dataGridView1[6, i].Value.ToString() + "," + "\n\t\t},"));

                }
            }
            writer.WriteLine("\t\t\t\t ]");
            writer.WriteLine("\t}");
            writer.WriteLine("}");
            writer.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    }

}
    }
}
    

