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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var con = new SqlConnection(@"Data Source=.\anders;Initial Catalog=Blog;Integrated Security=True");
                var command = con.CreateCommand();
                command.CommandText = "select * from posts";
                con.Open();
                var reader = command.ExecuteReader();

                var result = new List<Post>();

                while (reader.Read())
                {
                    result.Add(new Post
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Body = reader.GetString(2)
                    });
                }
                con.Close();
                dataGridView1.DataSource = result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
