using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BlogModel;

namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var customers = new List<BlogEntry>
            {
                new BlogEntry {Title = "Anders", Id = 25, Comments = new List<Comment> { new Comment{ Text = "Hammare", Date = DateTime.Now}}},
                new BlogEntry {Title = "Mikael", Id = 50, Comments = new List<Comment> { new Comment{ Text = "Spik", Date = DateTime.Now.AddDays(-2)}}}
            };

            comboBox1.DataSource = customers;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember= "Id";
        }

    


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ((BlogEntry) comboBox1.SelectedItem).Comments;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Cool man!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Validating(object sender, CancelEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            var comments = new CommentForm();
            comments.Comment = ((BlogEntry) comboBox1.SelectedItem).Comments.First();
            comments.ShowDialog();
        }

    }
}
