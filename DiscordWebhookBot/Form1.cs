using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace DiscordWebhookBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NormalMsg normalMsg = new NormalMsg();
            normalMsg.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmbedMsg embedMsg = new EmbedMsg();
            embedMsg.ShowDialog();
            Close();
        }
    }
}
