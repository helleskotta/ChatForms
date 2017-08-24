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
        List<Message> messages = new List<Message>();

        private TcpClient server;
        private ChatForms chatForms;
        private string name;
        private string currentVersion = "1.1";
        public bool loginSucceeded = false;
        public bool createUserSucceeded = false;

        // Stäng alla trådar i klienten
        public void QuitClient()
        {
            lock (messages)
            {
                if (messages.Count == 0)
                {
                    messages.Add(new Message { UserMessage = "quit" });
                }
                else
                {
                    Message message = messages.ElementAt(0);
                    message.UserMessage = "quit";
                }

                Monitor.PulseAll(messages);
            }

            server.Close();
        }

        public Client(ChatForms chatForms)
        {
            this.chatForms = chatForms;
        }

        public void Start()
        {
            server = new TcpClient("192.168.25.76", 5000);
            //Thread senderThread = new Thread(Listen);
            //senderThread.Start();

            Thread listenWithQueueThread = new Thread(ListenWithQueue);
            listenWithQueueThread.Start();

            Thread AddMessagesToQueueThread = new Thread(AddMessagesToQueue);
            AddMessagesToQueueThread.Start();
        }

        private void AddMessagesToQueue()
        {
            bool quit = false;

            while (!quit)
            {
                try
                {
                    NetworkStream n = server.GetStream();
                    Message message = JsonConvert.DeserializeObject<Message>(new BinaryReader(n).ReadString());

                    lock (messages)
                    {
                        messages.Add(message);
                        Monitor.PulseAll(messages);
                    }

                    quit = message.UserMessage.ToLower() == "quit";
                }
                catch
                {
                    quit = true;
                }
            }
        }

        private void ListenWithQueue()
        {
            bool quit = false;
            Message message;

            while (!quit)
            {
                try
                {
                    lock (messages)
                    {
                        while (messages.Count == 0)
                        {
                            Monitor.Wait(messages);
                        }

                        message = messages.ElementAt(0);

                        quit = message.UserMessage.ToLower() == "quit";

                        if (!quit)
                        {

                            if (message.UserMessage.ToLower() != "quit")
                                messages.RemoveAt(0);

                            if (message.UserName == name)
                                message.UserName = "Me";

                            switch (message.Action)
                            {
                                case "sendMessage":
                                    chatForms.Invoke(new Action<string, string>(chatForms.WriteToChatBox), message.UserName, message.UserMessage);
                                    break;

                                case "login":
                                    loginSucceeded = Convert.ToBoolean(message.UserMessage);
                                    break;

                                case "usersOnline":
                                    string[] contactList = message.UserMessage.Split(';');
                                    //chatForms.Invoke(new Action<string[]>(chatForms.DisplayContacts), contactList);
                                    chatForms.DisplayContacts(contactList);
                                    break;

                                case "createUser":
                                    createUserSucceeded = Convert.ToBoolean(message.UserMessage);
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw; //Console.WriteLine(ex.Message);
                }
            }
        }

        #region Bortkommenterad kod
        //public void Listen()
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            NetworkStream n = client.GetStream();
        //            Message message = JsonConvert.DeserializeObject<Message>(new BinaryReader(n).ReadString());

        //            if (message.UserName == name)
        //                message.UserName = "Me";

        //            switch (message.Action)
        //            {
        //                case "sendMessage":
        //                    chatForms.Invoke(new Action<string, string>(chatForms.WriteToChatBox), message.UserName, message.UserMessage);
        //                    break;

        //                case "login":
        //                    loginSucceeded = Convert.ToBoolean(message.UserMessage);
        //                    break;

        //                default:
        //                    break;
        //            }


        //        }
        //        catch (Exception)
        //        {
        //            throw; //Console.WriteLine(ex.Message);
        //        }
        //    }
        //}
        #endregion

        // Skicka meddelande
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
                NetworkStream n = server.GetStream();
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

        // Logga in användare
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
                NetworkStream n = server.GetStream();
                BinaryWriter w = new BinaryWriter(n);
                string output = JsonConvert.SerializeObject(message);
                w.Write(output);
                w.Flush();
            }
            catch (Exception)
            {
            }
        }

        // Skapa användare
        public void Create(string inputUserName, string inputUserPassword)
        {
            Message message = new Message();
            message.UserName = inputUserName;
            message.Version = currentVersion;
            message.UserMessage = inputUserPassword;
            name = inputUserName;
            message.Action = "createUser";

            try
            {
                NetworkStream n = server.GetStream();
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

