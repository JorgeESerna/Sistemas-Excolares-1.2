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
        MySqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void cargadatos()
        {
            try
            {
                dataGridView1.Rows.Clear();
                mySqlConnection = new MySqlConnection("host=localhost;user=root;password=admib;database=sistema_escolar;"); // String de connexion
                mySqlConnection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT matricula as 'Expediente', UPPER(ap1) as 'Apellido P', UPPER(ap2) as 'Apellido M', UPPER(nombre) as 'Primer Nombre', fechadenacimento, correo, telefono FROM alumnos", mySqlConnecion);
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






        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string archivo;
                archivo = SaveFileDialog.FileName;
                MessageBox.Show(archivo);
                Document documento = new Document(iTextSharp.text.PageSize.LETTER.Rotate());
                PdfWriter.GetInstance(documento, new FileStream(SaveFileDialog1.FileName, FileMode.Create));
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
    }
}
