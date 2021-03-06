﻿using System;

namespace BridgeDesignPattern
{
    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class MsmqSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("MSMQ\n{0}\n{1}\n", subject, body);
        }
    }
}