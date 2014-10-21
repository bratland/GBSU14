using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlogModel;

namespace WinFormsDemo
{
    public partial class CommentForm : Form
    {
        public Comment Comment { get; set; }
        public CommentForm()
        {
            Comment = new Comment();
            InitializeComponent();
        }

        private void CommentForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.Comment.Date.ToString();
            textBox2.Text = this.Comment.Text;
        }
    }
}
