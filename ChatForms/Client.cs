﻿using Newtonsoft.Json;
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
        public string name;
        Thread listenThread;

        public Client(ChatForms chatForms)
        {
            this.chatForms = chatForms;
        }

        public void Start()
        {

            client = new TcpClient("192.168.25.76", 5000);
            listenThread = new Thread(Listen);
            listenThread.Start();
        }

        public void Listen()
        {
            while (true)
            {
                try
                {
                    NetworkStream n = client.GetStream();
                    Message message = JsonConvert.DeserializeObject<Message>(new BinaryReader(n).ReadString()); // BLOCKERANDE!!1

                    if (message.UserName == name)
                    {
                        message.UserName = "Me";
                    }

                    chatForms.Invoke(new Action<string, string>(chatForms.WriteToChatBox), message.UserName, message.UserMessage);

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
            message.Version = "1.0";
            message.UserMessage = inputUserMessage;
            name = inputUserName;

            try
            {
                NetworkStream n = client.GetStream();
                //message.UserMessage = Console.ReadLine();
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

        public void Close()
        {
            listenThread.Suspend();
            client.Close();
        }
    }
}

