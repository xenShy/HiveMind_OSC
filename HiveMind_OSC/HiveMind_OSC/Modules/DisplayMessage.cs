using BuildSoft.VRChat.Osc.Chatbox;
using BuildSoft.VRChat.Osc.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiveMind_OSC.Modules
{
    public class DisplayMessage
    {
        
        public static void Start()
        {
            new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        SlidingMessage(Storage.SlidingMessages.ElementAt(1), true);               
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }

                    if (Storage.ShouldTerminateDisplayMessageThread)
                        return;

                    Thread.Sleep(500);
                }
            }).Start();
        }
        public static void SlidingMessage(List<string> message, bool breakOSC)
        {
            try
            {
                for (int x = 0; x <= message.Count; x++)
                {
                    OscChatbox.SendMessage(message[x] + (breakOSC ? "\u0003 x" : ""), true);
                    Thread.Sleep(1650);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
