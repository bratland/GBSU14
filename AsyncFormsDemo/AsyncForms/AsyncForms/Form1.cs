using System;

using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Working";
            Thread.Sleep(5000);
            label1.Text = "Done";
        }

        private async void  button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Working";
            await Task.Delay(5000);
            label1.Text = "Done";
        }
        private async void  button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Working";
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
            });
            label1.Text = "Done";
        }


        private async Task DoWorkAsync(Label label)
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                label.Text = i.ToString();
            }
            label.Text = "Done";

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Sequence";

            DoWorkAsync(label2);
            await DoWorkAsync(label3);

            label1.Text = "Done";

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Parallel";

            var tasks = new Task[2];

            tasks[0] = DoWorkAsync(label2);
            tasks[1] = DoWorkAsync(label3);

            await Task.WhenAll(tasks);

            label1.Text = "Done";

        }


    }
}
