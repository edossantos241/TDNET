using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        private RemotingObjects.IRemotingObjects remoteObject;
        public Form1()
        {
            try
            {
                HttpChannel channel = new HttpChannel();
                ChannelServices.RegisterChannel(channel, true);
                remoteObject = (RemotingObjects.IRemotingObjects)
                    Activator.GetObject(typeof(RemotingObjects.IRemotingObjects),
                    "http://localhost:14000/HostObject");
            }
            catch
            {
                MessageBox.Show("Error connecting to the server !");
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (remoteObject != null)
            {
                String result = remoteObject.sayHello(textBox1.Text);
                MessageBox.Show("Result: " + result);
            } else
            {
                MessageBox.Show("Error: remote object not available");
            }
        }
    }
}
