using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypeSpammer
{
    public partial class SkypeSpammer : Form
    {
        SkypeUtils utils = new SkypeUtils();

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
            string Message = this.msgBox.Text;

            int iterations = 1;

            try
            {
                iterations = int.Parse(this.iterBox.Text);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message); // Write the stack trace to the console.
            }

            string User = this.userBox.Text;

            for (int i = 0; i < iterations; i++)
            {
                utils.SendMessage(User, Message);
            }

        }
    }
}
