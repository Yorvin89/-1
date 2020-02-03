using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Блокнот.Properties;
using System.IO;



namespace Блокнот
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
           
            RichTextBox richTextBox1 = new RichTextBox();
            richTextBox1.Dock = DockStyle.Fill;
            this.Controls.Add(richTextBox1);
        }
        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void браузерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore");
        }

        private void проигрывательToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("wmplayer");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savetext = new SaveFileDialog();
            savetext.DefaultExt = ".txt";
            savetext.Filter = "TXT|*.txt";
            if (savetext.ShowDialog() == DialogResult.OK && savetext.FileName.Length > 0)
            {
                using (StreamWriter stwr = new StreamWriter(savetext.FileName))
                {
                    stwr.WriteLine(richTextBox1.Text);
                    stwr.Close();
                }
            }
        }

        private void загрузитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
            ofd.Filter = "TXT|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void калькуляторToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void бразузерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore");
        }

        private void курсВалютToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 q2 = new Form2();
            q2.ShowDialog();
        }
    }
}
