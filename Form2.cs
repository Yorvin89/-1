using System;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Блокнот
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public static string Sberbank()  
        {

            System.Net.WebClient wc = new System.Net.WebClient();
            String Response = wc.DownloadString("https://yandex.ru/");
            // <span class="inline-stocks__value_inner">63,28</span>
            // </span></span></span><span class="inline-stocks__value_inner">63,28</span></span>
            String Rata = System.Text.RegularExpressions.Regex.Match(Response, @"<span class=""inline-stocks__value_inner"">([0-9]+\,[0-9]+)</span></span>").Groups[1].Value;
            return "курс валюты " + Rata + " р. \r\n";
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Sberbank();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

