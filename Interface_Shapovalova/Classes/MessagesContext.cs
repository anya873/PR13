using Interface_Shapovalova.Interfaces;
using Interface_Shapovalova.Models;
using System;
using System.Collections.Generic;

namespace Interface_Shapovalova.Classes
{
    public class MessagesContext : Messages, IMessages
    {
        public static List<Messages> AllMessages = new List<Messages>();

        public MessagesContext() { }

        public MessagesContext(string Message, DateTime Create, int IdUser) : base(Message, Create, IdUser) { }

        public void All(out List<Messages> Messages) => Messages = AllMessages;

        public void Delete() => AllMessages.Remove(this);

        public void Save(bool Update = false)
        {
            if (Update == false) AllMessages.Add(this);
        }
    }
}