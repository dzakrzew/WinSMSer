﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinSMSer.Services
{
    public class MessageDatabaseService
    {
        private string path = "messages.json";
        private List<Model.Message> messages;

        public MessageDatabaseService()
        {
            Load();
        }

        public List<Model.Message> GetReceivedMessages()
        {
            var all = from Model.Message message in messages
                   where message.Type == Model.MessageType.Received
                   select message;

            return all.ToList();
        }

        public void AppendMessages(List<Model.Message> messages)
        {
            this.messages.AddRange(messages);
            Save();
        }

        private void Load()
        {

            try
            {
                this.messages = JsonConvert.DeserializeObject<List<Model.Message>>(File.ReadAllText(path));

                if (this.messages == null)
                {
                    this.messages = new List<Model.Message>();
                }
            }
            catch (Exception e)
            {
                this.messages = new List<Model.Message>();
            }
        }

        private void Save()
        {
            string json = JsonConvert.SerializeObject(this.messages);
            File.WriteAllText(path, json);
        }
    }
}