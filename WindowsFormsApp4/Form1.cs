using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="jagadish" && textBox2.Text=="12345")
            {
                MessageBox.Show("logged in success");
                this.Hide();
                registration r = new registration();
                r.Show();
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }
    }
}
