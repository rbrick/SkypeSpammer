using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKYPE4COMLib;

namespace SkypeSpammer
{
    class SkypeUtils
    {
        private Skype skype;

        public SkypeUtils()
        {
            this.skype = new Skype(); // BAM
            this.skype.Attach(7, true); 
        }

        public void SendMessage(string User, string Message) {
            skype.SendMessage(User, Message);
        }

  

    }
}
