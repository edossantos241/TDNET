using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace HostApplication
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                HttpChannel channel = new HttpChannel(14000);
                ChannelServices.RegisterChannel(channel, false);
                RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(HostObject), "HostObject", WellKnownObjectMode.SingleCall);
                Console.WriteLine("Remote object ready at server side, using HTTP !");
                Console.ReadLine();
            } catch
            {
                Console.WriteLine("Error creating/registering the channel !");
            }
        }
    }
}
