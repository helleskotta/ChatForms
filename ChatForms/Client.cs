using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebLibrary;

namespace ChatForms
{
    public class Client
    {
        private TcpClient client;
        private ChatForms chatForms;
        private Form2 form2;

        public Client(ChatForms chatForms)
        {
            this.chatForms = chatForms;
        }

        public Client(Form2 form2)
        {
            this.form2 = form2;
        }

        public void Start()
        {

            client = new TcpClient("192.168.25.76", 5000);

            Thread senderThread = new Thread(Listen);
            senderThread.Start();
        }

        public void Listen()
        {
            Message message = new Message();

            try
            {
                while (true)
                {
                    NetworkStream n = client.GetStream();
                    message = JsonConvert.DeserializeObject<Message>(new BinaryReader(n).ReadString());
                    chatForms.WriteToChatBox(message.UserName, message.UserMessage);
                    chatForms.WriteToUserName(message.UserName);
                    //Console.WriteLine($"{message.UserName}: {message.UserMessage}");
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
        }

        public void Send(string inputUserName, string inputUserMessage)
        {
            Message message = new Message();
            message.UserName = inputUserName;
            message.Version = "1.0";
            message.UserMessage = inputUserMessage;

            try
            {

                NetworkStream n = client.GetStream();
                //message.UserMessage = Console.ReadLine();
                BinaryWriter w = new BinaryWriter(n);
                string output = JsonConvert.SerializeObject(message);
                w.Write(output);
                w.Flush();


            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
        }
    }
}

