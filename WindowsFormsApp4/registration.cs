using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Desktop\2016CSE149\WindowsFormsApp4\WindowsFormsApp4\Database1.mdf;Integrated Security=True"); 
        public registration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = openFileDialog1.FileName;
            } pictureBox1.ImageLocation = openFileDialog1.FileName;
                

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            Byte[] mypic = File.ReadAllBytes(openFileDialog1.FileName);

            cmd.CommandText = "insert into regtable values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "',@pic)";
            SqlParameter prm = new SqlParameter("@pic", SqlDbType.VarBinary, mypic.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mypic);
            cmd.Parameters.Add(prm);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved");
        }

        private void registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.regtable' table. You can move, or remove it, as needed.
            this.regtableTableAdapter.Fill(this.database1DataSet.regtable);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
