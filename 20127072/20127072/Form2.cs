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
using System.Runtime.Serialization.Formatters.Binary;
namespace WF1
{
    public partial class Form2 : Form
    {
        public string StrConn = @"Data Source=GOBI;Initial Catalog=QLSV; User ID=sa;Password=Goblin2002";
        public Aes myAes = Aes.Create();
        public byte[] iv_bytes = new byte[16];
        // Encrypt the string to an array of bytes.
        void loaddata()
        {
            SqlConnection Conn = new SqlConnection(StrConn);
            myAes.Key = Encoding.UTF8.GetBytes("20127072000000000000000000000000");
            myAes.IV = iv_bytes;
            myAes.Padding = PaddingMode.PKCS7;
            Conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SP_SEL_ENCRYPT_NHANVIEN", Conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;


            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataColumn dtc = new DataColumn();
            dtc.ColumnName = "LƯƠNG";
            dtc.DataType = Type.GetType("System.String");
            dt.Columns.Add(dtc);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][4] = DecryptStringFromBytes_Aes((byte[])dt.Rows[i][3], myAes.Key, myAes.IV);
            }
            dt.Columns.Remove("LUONG");

            dataGridView1.DataSource = dt;



            Conn.Close();
        }
        public Form2()
        {
            InitializeComponent();
            loaddata();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

 

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
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


        private void them_Click(object sender, EventArgs e)
        {
            textBoxMaNV.Clear();
            textBoxHoten.Clear();
            textBoxEmail.Clear();
            textBoxLuong.Clear();
            textBoxTendn.Clear();
            textBoxMatkhau.Clear();      
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ghiluu_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(StrConn);

            // Decrypt the bytes to a string;

            SqlCommand cmd = new SqlCommand();
            Conn.Open();
            cmd.CommandText = "SP_INS_ENCRYPT_NHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = Conn;
            cmd.Parameters.Add("@MANV", SqlDbType.VarChar, 20).Value = textBoxMaNV.Text;
            cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 100).Value = textBoxHoten.Text;
            cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar, 20).Value = textBoxEmail.Text;

            string original = textBoxLuong.Text;
            // Create a new instance of the Aes
            // class.  This generates a new key and initialization
            // vector (IV).
            Aes myAes = Aes.Create();
            // Encrypt the string to an array of bytes.
            myAes.Key = Encoding.UTF8.GetBytes("20127072000000000000000000000000");
            myAes.IV = iv_bytes;
            myAes.Padding = PaddingMode.PKCS7;
            byte[] luong_ma_hoa = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV);
            // Decrypt the bytes to a string

            cmd.Parameters.Add("@LUONG", SqlDbType.VarBinary, 1024).Value = luong_ma_hoa;
            cmd.Parameters.Add("@TENDN", SqlDbType.NVarChar, 100).Value = textBoxTendn.Text;

            byte[] theBytes = Encoding.UTF8.GetBytes(Hash(textBoxMatkhau.Text));
            cmd.Parameters.Add("@MATKHAU", SqlDbType.VarBinary, 100).Value = theBytes;
            cmd.ExecuteNonQuery();
            Conn.Close();



           
            loaddata();



            MessageBox.Show("Thêm thành công");
        }
    }
}
