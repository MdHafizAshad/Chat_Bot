using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;

namespace _3d_chat_bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axActiveHaptekX1.HyperText = @"\load [file=[standardStartup.hap]]";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bot AI = new Bot();
            AI.loadSettings();
            AI.loadAIMLFromFiles();
            AI.isAcceptingUserInput =  false;
            User myuser = new User("username", AI);
            AI.isAcceptingUserInput = true;
            Request r = new Request(textBox1.Text, myuser, AI);
            Result res = AI.Chat(r);
            textBox2.Text = "3d chat_bot: " + res.Output;
            textBox3.Text = res.Output;
            axActiveHaptekX1.HyperText = @"\speak [string = [" +textBox3.Text+"]"];

        }
    }
}
