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


        public Form1()
        {
            InitializeComponent();

            connection = new DiscordConnection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String var;
            var = textBox1.Text;

            if (var.Length == 0)
            {
                MessageBox.Show("No blank characters", "Error");
                return;
            } else if (var.Length == 1)
            {
                MessageBox.Show("Must have 2 characters (because discord)", "Error");
                return;
            }

            connection.InitPresence(var);
        }
    }
}
