using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Printing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int i = 1;
            LocalPrintServer localPrintServer = new LocalPrintServer();
            PrintQueueCollection printQueues =localPrintServer.GetPrintQueues();
            foreach(PrintQueue printQueue in printQueues)
            {
                listView1.Items.Add(i + "-" + "Name:" + printQueue.Name + "_Status:" + printQueue.QueueStatus);
                    i++;
            }
        }
    }
}
