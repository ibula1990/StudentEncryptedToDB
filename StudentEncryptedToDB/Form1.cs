using ClassForEncryptDecrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEncryptedToDB
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-BLIQA1L\SQLEXPRESS01;Database=Student;Trusted_Connection=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtEncName.Text = EncryptDecrypt.Encrypt(txtName.Text, txtkeyName.Text );
            txtEncAddres.Text = EncryptDecrypt.Encrypt(txtAddress.Text,txtKeyAddress.Text);
            txtEncStream.Text = EncryptDecrypt.Encrypt(txtStream.Text, txtkeyStream.Text);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "SaveStudent";
            cmd.Parameters.AddWithValue("@Name", txtEncName.Text);
            cmd.Parameters.AddWithValue("@Address", txtEncAddres.Text);
            cmd.Parameters.AddWithValue("@Stream", txtEncStream.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            

            MessageBox.Show("Saved Successfully ");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEncStream.Hide();
            txtEncName.Hide();
            txtEncAddres.Hide();
        }
    }
}
