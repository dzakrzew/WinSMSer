using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinSMSer.Services
{
    /// <summary>
    /// Usługa zapisująca i odczytująca wiadomości SMS z pliku JSON
    /// </summary>
    public class MessageDatabaseService
    {
        private string path;
        private List<Model.Message> messages;

        public MessageDatabaseService(string path)
        {
            this.path = path;
            Load();
        }

        /// <summary>
        /// Zwraca wszystkie wiadomości
        /// </summary>
        /// <returns></returns>
        public List<Model.Message> GetAllMessages()
        {
            var result = from Model.Message message in this.messages
                   orderby message.Date descending
                   select message;

            return result.ToList();
        }

        /// <summary>
        /// Dodaje zbiór wiadomości do bazy i zapisuje je w pliku
        /// </summary>
        /// <param name="messages"></param>
        public void AppendMessages(List<Model.Message> messages)
        {
            this.messages.AddRange(messages);
            Save();
        }

        /// <summary>
        /// Wczytywanie wiadomości z pliku
        /// </summary>
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

        /// <summary>
        /// Zapisywanie wiadomości do pliku
        /// </summary>
        private void Save()
        {
            string json = JsonConvert.SerializeObject(this.messages);
            File.WriteAllText(path, json);
        }
    }
}
