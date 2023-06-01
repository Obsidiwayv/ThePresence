using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dpresence
{
    public partial class Form1 : Form
    {
        private DiscordConnection connection;
        private String state;
        private String details;
        private string appID;


        public Form1()
        {
            InitializeComponent();

            connection = new DiscordConnection();
            MusicPlayer.InitMusicPlayer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            state = textBox1.Text;
            details = PDetails.Text;
            appID = IDBox.Text;

            if (!Utils.StringIsValid(state, "state")) return;
            if (!Utils.StringIsValid(details, "details")) return;
            if (!Utils.IDisThere(appID)) return;

            if (SmallImage.Text.Length > 0 && LargeImage.Text.Length == 0)
            {
                MessageBox.Show("Must have a large image before small image");
                return;
            }

            Console.Write("ID: {0}", appID);
            
            connection.InitPresence(
                details, 
                state,
                appID,
                SmallImage.Text,
                LargeImage.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Close();
            MessageBox.Show("Disconnected rich presence", "Finished");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
