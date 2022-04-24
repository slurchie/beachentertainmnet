using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;

namespace beachentertainmnet
{
    public partial class mainform : Form
    {
        SqlConnection connection;
        List <pictures>pics=new List<pictures>(4);
        DateTime selecttime;

        public mainform()
        {

            InitializeComponent();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=beachentertainment;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand commandAttr = new SqlCommand();
            commandAttr.Connection = connection;
            commandAttr.CommandText = "CREATE TABLE attrs(name_of_attrs VARCHAR(38), price DECIMAL(38),picture VARBINARY(MAX));";
            commandAttr.ExecuteNonQuery();
            commandAttr.CommandText = "INSERT INTO attrs(name_of_attrs, price,picture)VALUES(банан,350," + getImage("images.jpg") + ");";
            //SqlParameter ageParam = new SqlParameter("@image", getImage("images.jpg"));
            //commandAttr.Parameters.Add(ageParam);
            commandAttr.ExecuteNonQuery();
            pictures1.Image = GetnReturnPicture();
            //string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;";
            //string sqlExpression = @"CREATE TABLE Files 
            //                    (Id INT PRIMARY KEY IDENTITY, 
            //                     Title NVARCHAR(50) NOT NULL, 
            //                     FileName NVARCHAR(50) NOT NULL,
            //                     ImageData varbinary(MAX))";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.OpenAsync();
            //    SqlCommand command = new SqlCommand(sqlExpression, connection);
            //    command.ExecuteNonQueryAsync();

            //}
        }


        private void mainform_Load(object sender, EventArgs e)
        {








            pictures1.setInfo("банан", "Свободен", Properties.Resources.банан);
            pictures2.setInfo("катамаран", "Свободен", Properties.Resources.катамаран);
            pictures3.setInfo("гидроцикл", "В ремонте", Properties.Resources.гидроцикл1);
            pictures4.setInfo("водная горка", "Занят", Properties.Resources.горка);
            foreach (var i in tableLayoutPanel2.Controls)
            {
                pics.Add((pictures)i);
            }
            selecttime = DateTime.Today;
            richTextBox1.Text = selecttime.ToLongDateString();
        }

 
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
                foreach(pictures i in pics)
                i.lighten(listBox3.Items[listBox3.SelectedIndex].ToString(), listBox4.Items[listBox4.SelectedIndex].ToString());
            }
            catch
            {
                foreach (pictures i in pics)
                    i.lighten(listBox3.Items[listBox3.SelectedIndex].ToString(), "Все");
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (pictures i in pics)
                    i.lighten(listBox3.Items[listBox3.SelectedIndex].ToString(), listBox4.Items[listBox4.SelectedIndex].ToString());
            }
            catch
            {
                foreach (pictures i in pics)
                    i.lighten("Все", listBox4.Items[listBox4.SelectedIndex].ToString());
            }
          
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            selecttime= selecttime.AddDays(-1);
            richTextBox1.Text = selecttime.ToLongDateString();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            selecttime = selecttime.AddDays(1);
            richTextBox1.Text = selecttime.ToLongDateString();
        }
        static byte[] getImage(string imagePath)
        {
            byte[] imageData;
            using (FileStream fs = new FileStream(imagePath, FileMode.Open))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, imageData.Length);
                return imageData;

            }
        }
            public Image GetnReturnPicture()
            {
               
                string sql = "SELECT * FROM таблица";
                SqlCommand command = new SqlCommand(sql,connection );
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        byte[] data = (byte[])reader.GetValue(3);
                        MemoryStream ms = new MemoryStream(data);
                        return Image.FromStream(ms);
                    }
                }
            return null;
            }
          
        }
    }
    


