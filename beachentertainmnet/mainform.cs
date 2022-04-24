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
        List<attractions> attract = new List<attractions>(4);
        DateTime selecttime;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=beachentertainment;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string nameTableAttractions;
        public Form formochka;
        List<worker> workers = new List<worker>(3);
        string nameTableWorkers;

        public mainform()
        {

            InitializeComponent();

        }
        void savetoBaseAttractions( string name, double price, string filename)
        {
            SqlCommand commandRead = new SqlCommand();
            commandRead.Connection = connection;
            commandRead.CommandText = $"INSERT INTO {nameTableAttractions} VALUES (@name_attr, @price, @ImageData)";
            commandRead.Parameters.Add("@name_attr", SqlDbType.NVarChar, 50);
            commandRead.Parameters.Add("@price", SqlDbType.Decimal, 50);
            byte[] imageData;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, imageData.Length);
                commandRead.Parameters.Add("@ImageData", SqlDbType.VarBinary, Convert.ToInt32(fs.Length));
            }
            // передаем данные в команду через параметры
            commandRead.Parameters["@name_attr"].Value = name;
            commandRead.Parameters["@price"].Value = price;
            commandRead.Parameters["@ImageData"].Value = imageData;
            commandRead.ExecuteNonQuery();
        }
        void CreateTable()
        {
            SqlCommand command = new SqlCommand($"CREATE TABLE {nameTableAttractions}(test_table_id INT PRIMARY KEY IDENTITY, name_attr NVARCHAR(50), price DECIMAL(10,2), ImageData varbinary(MAX));", connection);
            command.ExecuteNonQuery();
        }
        void CreateTableWorkers()
        {
            SqlCommand command = new SqlCommand($"CREATE TABLE {nameTableWorkers}(test_table_id INT PRIMARY KEY IDENTITY, name_Of_Worker NVARCHAR(50), post NVARCHAR(50), worker_pic VARBINARY(MAX), start_of_working DATE,end_of_working DATE,own_attraction INT,smenshik INT);", connection);
            command.ExecuteNonQuery();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            selecttime = DateTime.Today;
            listchildworkers.Displayinfo = (displayinfo)displayinfoworkers;
            listchildcalendar.Displayinfo = (displayinfo)attractionsdisplayinfo;
            listchildcalendar.selectTime = selecttime;
            listchildworkers.selectTime = selecttime;
            connection = new SqlConnection(connectionString);
            connection.Open();
            nameTableAttractions = "TestAttr1";
            nameTableWorkers = "TestWorker1";
            //CreateTableWorkers();
         
            //CreateTable();
            //pictures1.setInfo("банан", "Свободен", Properties.Resources.банан);
            //pictures2.setInfo("катамаран", "Свободен", Properties.Resources.катамаран);
            //pictures3.setInfo("гидроцикл", "В ремонте", Properties.Resources.гидроцикл1);
            //pictures4.setInfo("водная горка", "Занят", Properties.Resources.горка);
            foreach (var i in tableLayoutPanel2.Controls)
            {
                pics.Add((pictures)i);
            }
          
            richTextBox1.Text = selecttime.ToLongDateString();
            attractionFromBase();
            workersFromBase();
            pictures1.Image = attract[0].showimage();
            pictures2.Image = attract[1].showimage();
            pictures3.Image = attract[2].showimage();
            pictures4.Image = attract[3].showimage();
            writeintotables();
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
        void attractionFromBase()
        {
            SqlCommand commandWrite = new SqlCommand();
            commandWrite.CommandText = $"SELECT * FROM {nameTableAttractions}";
            commandWrite.Connection = connection;

            using (SqlDataReader reader = commandWrite.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name_attr = reader.GetString(1);
                    decimal price = reader.GetDecimal(2);
                    byte[] data = (byte[])reader.GetValue(3);
                    MemoryStream ms = new MemoryStream(data);
                    attractions attracts = new attractions(name_attr, price, Image.FromStream(ms));
                    attract.Add(attracts);
                    listchildcalendar.addToList(attracts);
                }
            }
        }
        void workersFromBase()
        {
            SqlCommand commandWrite = new SqlCommand();
            commandWrite.CommandText = $"SELECT * FROM {nameTableWorkers}";
            commandWrite.Connection = connection;

            using (SqlDataReader reader = commandWrite.ExecuteReader())
            {
                List<int> idworkers = new List<int>(4);

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name_of_worker = reader.GetString(1);
                    string post = reader.GetString(2);
                    byte[] data = (byte[])reader.GetValue(3);
                    MemoryStream ms = new MemoryStream(data);
                    DateTime startofworking = reader.GetDateTime(4);
                    DateTime endofworking = reader.GetDateTime(5);
                    int id_attr = reader.GetInt32(6);
                    int id_worker = reader.GetInt32(7);
                    //Image pictureworker = Image.FromStream(ms);
                    idworkers.Add(id_worker);
                    worker rabotyaga=new worker(name_of_worker, post, Image.FromStream(ms), startofworking, endofworking, attract[id_attr]);
                    workers.Add(rabotyaga);
                 
                    listchildworkers.addToList(rabotyaga);
                }
                for(int i =0;i<workers.Count;i++)
                {
                    workers[i].Smenshik = workers[idworkers[i]];
                }
            }
        }
        private void mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            formochka.Close();
        }
        public void clearInfo()
        {
            SqlCommand clearCommand = new SqlCommand($"DELETE FROM {nameTableAttractions};",connection);
            clearCommand.ExecuteNonQuery();
            clearCommand.CommandText = $"DELETE FROM {nameTableWorkers};";

            clearCommand.ExecuteNonQuery();

        }
        public void writeintotables()
        {
            clearInfo();
            savetoBaseAttractions("банан", 350, "банан.jpg");
            savetoBaseAttractions("катамаран", 200, "катамаран.jpg");
            savetoBaseAttractions("горка", 300, "горка.jpg");
            savetoBaseAttractions("гидроцикл", 400, "гидроцикл1.jpg");
            savetoBaseWorkers("Сан Саныч", "охранник", "worker1.jpg", new DateTime(2022, 7, 11, 8, 30, 0), new DateTime(2022, 7, 11, 20, 30, 0), 0, 2);
            savetoBaseWorkers("Карчевский", "охранник", "worker2.jpg", new DateTime(2022, 8, 11, 8, 30, 0), new DateTime(2022, 8, 11, 20, 30, 0),2, 0);
            savetoBaseWorkers("Сан Саныч", "охранник", "worker3.jpg", new DateTime(2022, 7, 11, 8, 30, 0), new DateTime(2022, 7, 11, 20, 30, 0), 3, 3);
            savetoBaseWorkers("Сан Саныч", "охранник", "worker1.jpg", new DateTime(2022, 7, 11, 8, 30, 0), new DateTime(2022, 7, 11, 20, 30, 0), 1, 1);
        }
        void savetoBaseWorkers(string nameOfWorker, string Post, string workpic, DateTime StartOfWorking, DateTime EndOfWorking, int OwnAttr, int Smenshik)
        {
            SqlCommand commandRead = new SqlCommand();
            commandRead.Connection = connection;
            commandRead.CommandText = $"INSERT INTO {nameTableWorkers} VALUES (@nameOfWorker, @post, @workpic,@startofworkingday,@endofworkingday,@ownattraction,@smenshik)";
            commandRead.Parameters.Add("@nameofworker", SqlDbType.NVarChar, 50);
            commandRead.Parameters.Add("@post", SqlDbType.NVarChar, 50);
            byte[] imageData;
            using (FileStream fs = new FileStream(workpic, FileMode.Open))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, imageData.Length);
                commandRead.Parameters.Add("@workpic", SqlDbType.VarBinary, Convert.ToInt32(fs.Length));
            }
       
            commandRead.Parameters.Add("@startofworkingday", SqlDbType.Date);
            commandRead.Parameters.Add("@endofworkingday", SqlDbType.Date);
            commandRead.Parameters.Add("@ownattraction", SqlDbType.Int, 50);
            commandRead.Parameters.Add("@smenshik", SqlDbType.Int, 50);
            // передаем данные в команду через параметры
            commandRead.Parameters["@nameOfWorker"].Value = nameOfWorker;
            commandRead.Parameters["@post"].Value = Post;
            commandRead.Parameters["@workpic"].Value = imageData;
            commandRead.Parameters["@startofworkingday"].Value = StartOfWorking;
            commandRead.Parameters["@endofworkingday"].Value = EndOfWorking;
            commandRead.Parameters["@ownattraction"].Value = OwnAttr;
            commandRead.Parameters["@smenshik"].Value = Smenshik;
            commandRead.ExecuteNonQuery();
        }
    }
    }
    


