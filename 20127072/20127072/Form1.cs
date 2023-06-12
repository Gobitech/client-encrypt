using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF1
{
    public partial class Form1 : Form
    {
        public string StrConn = @"Data Source=GOBI;Initial Catalog=QLSV; User ID=sa;Password=Goblin2002";
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /* SqlConnection Conn = new SqlConnection(StrConn);
             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "SP_INS_ENCRYPT_NHANVIEN";
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Connection = Conn;
             cmd.Parameters.Add("@MANV", SqlDbType.VarChar, 20).Value = "NV05";
             cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar,100).Value = "NGUYEN VAN D";
             cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar,20).Value = "NVD@";
             cmd.Parameters.Add("@LUONG", SqlDbType.Int).Value = 40000;
             cmd.Parameters.Add("@TENDN", SqlDbType.NVarChar,100).Value = "NVD";
             byte[] theBytes = Encoding.UTF8.GetBytes("545045840580458058045804580458435");
             cmd.Parameters.Add("@MATKHAU", SqlDbType.VarBinary,100).Value = theBytes;

             cmd.ExecuteNonQuery();
             Conn.Close();*/
            byte[] theBytes = Encoding.UTF8.GetBytes(Hash(textBox2.Text));
            //cmd.Parameters.Add("@MATKHAU", SqlDbType.VarBinary, 100).Value = theBytes;
            SqlConnection Conn = new SqlConnection(StrConn);
            SqlCommand cmd = new SqlCommand();
            Conn.Open();
            cmd.Connection = Conn;
            string query = "Select *from NHANVIEN where TENDN ='" + textBox1.Text.Trim() + "' and MATKHAU= @MK";
            SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
            sda.SelectCommand.Parameters.Add("@MK", SqlDbType.VarBinary, 100).Value = theBytes;
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                this.Hide();
                Form2 screen2 = new Form2();
                screen2.Show();

            }
            else
            {
                MessageBox.Show("Ten dang nhap hoac mat khau khong hop le !");
            }
            Conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
