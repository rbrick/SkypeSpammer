using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SkypeSpammer
{
    public partial class SkypeSpammer : Form
    {
        SkypeUtils utils = new SkypeUtils();

        private int iterations;
        private string User;
        private string Message;

        public SkypeSpammer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // null
        }

        private void spamBtn_Click(object sender, EventArgs e)
        {
            if (this.msgBox.Text == "")
            {
                MessageBox.Show("Message cannot be empty!");
                return;
            }

            this.Message = this.msgBox.Text;

            try
            {
                this.iterations = int.Parse(this.iterBox.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Iteration must be a number!");
                return;
            }

            if (this.userBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty!");
                return;
            }

            this.User = this.userBox.Text;
            
            Thread spamThread = new Thread(new ThreadStart(SpamTask));

            spamThread.Start();

        }

        private void SpamTask()
        {
            for (int i = 0; i < iterations; i++)
            {
                utils.SendMessage(User, Message);
            }
        }
    }

    
}
