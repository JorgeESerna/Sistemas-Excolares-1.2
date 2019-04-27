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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_Id.Enabled = false;
            lb_Id.Text = dataGridView1[0,e.RowIndex].Value.ToString();
            lb_precio.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            lb_url.Text = dataGridView1[2, e.RowIndex].Value.ToString();
        
        }

        private void cargaDatos()
        {
            try
            {
                dataGridView1.Rows.Clear();

                mySqlConnection = new MySqlConnection("host=localhost;user=root;password=admin;database=punto_de_venta"); //Streing de conección

                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand("SELECT * FROM productos", mySqlConnection);

                reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetUInt32(0),reader.GetString(1),reader.GetString(2),reader.GetString(3));
                }

                
                mySqlConnection.Close();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString(),"error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargaDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO alumnos (producto_id,producto_nombre,producto_precio,producto_url VALUES ("+ lb_Id.Text+",'"+ lb_precio.Text + "','"+ lb_url.Text + ";";
            

            try
            {
                mySqlConnection = new MySqlConnection("host=localhost;user=root;password=admin;database=sistemas_escolar"); //Streing de conección

                mySqlConnection.Open();
                                           
                mySqlCommand = new MySqlCommand(query, mySqlConnection);

                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Finalizado");

                cargaDatos();
                                

                mySqlConnection.Close();
                            

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString(), "error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String query = "delete from productos where producto_id=" + tb_matricula.Text;
            
            //hola mundo
            try
            {
                mySqlConnection = new MySqlConnection("host=localhost;user=root;password=admin;database=sistemas_escolar"); //Streing de conección

                mySqlConnection.Open();
                                
                mySqlCommand = new MySqlCommand(query, mySqlConnection);


                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Finalizado");

                cargaDatos();

                mySqlConnection.Close();
                              
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
            }
        }
    }
}
