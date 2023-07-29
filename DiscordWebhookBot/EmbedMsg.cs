using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWebhookBot
{
    public partial class EmbedMsg : Form
    {
        public EmbedMsg()
        {
            InitializeComponent();
        }

        public static void PostEmbedMsg(string uri, string Botusername,string titleDesc, string msg)
        {
            WebRequest wr = (HttpWebRequest)WebRequest.Create(uri);
            wr.ContentType = "application/json";
            wr.Method = "POST";

            using (StreamWriter sw = new StreamWriter(wr.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(new
                {
                    username = Botusername,
                    embeds = new[]
                    {
                        new
                        {
                            description = msg,
                            title = titleDesc,
                        }
                    }
                });
                sw.WriteLine(json);
            }
            HttpWebResponse response = (HttpWebResponse)wr.GetResponse();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uri = textBox1.Text;
            string name = textBox2.Text;
            string title = textBox3.Text;
            string msg = textBox4.Text;
            PostEmbedMsg(uri, name, title, msg);

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmbedMsg embedMsg = new EmbedMsg();
            embedMsg.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
