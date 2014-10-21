using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var week = new List<string> {"Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Anders", Id = 25},
                new Customer {Name = "Mikael", Id = 50}
            };

            comboBox1.DataSource = customers;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember= "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button) sender).Text;
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.KeyChar
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //textBox1.Text = ((Customer)comboBox1.SelectedItem).Name;
            //textBox2.Text = ((Customer)comboBox1.SelectedItem).Id.ToString();
            textBox1.Text = comboBox1.SelectedText;
            textBox2.Text = comboBox1.SelectedValue.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
