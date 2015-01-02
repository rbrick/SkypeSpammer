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
            this.Message = this.msgBox.Text;

            try
            {
                this.iterations = int.Parse(this.iterBox.Text);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message); // Write the stack trace to the console.
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
