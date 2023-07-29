using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWebhookBot
{
    public partial class NormalMsg : Form
    {
        public NormalMsg()
        {
            InitializeComponent();
        }

        public static void sendWebhook(string uri, string msg, string BotUserName)
        {
            Http.Post(uri, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    BotUserName
                },
                {
                    "content",
                    msg
                }

            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uri = textBox1.Text;
            string Botusername = textBox2.Text;
            string msg = textBox3.Text;

            sendWebhook(uri, msg, Botusername);

            textBox2.Clear();
            textBox3.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            NormalMsg normalMsg= new NormalMsg();
            normalMsg.Close();
        }
    }
}
