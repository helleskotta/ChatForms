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
        private string name;
        private string currentVersion = "1.1";

        public Client(ChatForms chatForms)
        {
            this.chatForms = chatForms;
        }

        public void Start()
        {
            client = new TcpClient("192.168.25.76", 5000);
            Thread senderThread = new Thread(Listen);
            senderThread.Start();
        }

        public void Listen()
        {
            while (true)
            {
                try
                {
                    NetworkStream n = client.GetStream();
                    Message message = JsonConvert.DeserializeObject<Message>(new BinaryReader(n).ReadString());

                    if (message.UserName == name)
                        message.UserName = "Me";

                    switch (message.Action)
                    {
                        case "sendMessage":
                            chatForms.Invoke(new Action<string, string>(chatForms.WriteToChatBox), message.UserName, message.UserMessage);
                            break;

                        case "login":
                            
                            break;

                        default:
                            break;
                    }


                }
                catch (Exception)
                {
                    throw; //Console.WriteLine(ex.Message);
                }
            }
        }

        public void Send(string inputUserName, string inputUserMessage)
        {
            Message message = new Message();
            message.UserName = inputUserName;
            message.Version = currentVersion;
            message.UserMessage = inputUserMessage;
            name = inputUserName;
            message.Action = "sendMessage";

            try
            {
                NetworkStream n = client.GetStream();
                BinaryWriter w = new BinaryWriter(n);
                string output = JsonConvert.SerializeObject(message);
                w.Write(output);
                w.Flush();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Login(string inputUserName, string inputUserPassword)
        {
            Message message = new Message();
            message.UserName = inputUserName;
            message.Version = currentVersion;
            message.UserMessage = inputUserPassword;
            name = inputUserName;
            message.Action = "login";

            try
            {
                NetworkStream n = client.GetStream();
                BinaryWriter w = new BinaryWriter(n);
                string output = JsonConvert.SerializeObject(message);
                w.Write(output);
                w.Flush();
            }
            catch (Exception)
            {
            }
        }
    }
}

