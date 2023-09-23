using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal interface IMessageService1
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceiveMessage();
        void DeleteMessage();

    }
    internal interface Ipayments
    {
        void MakePayment(float amount);
    }
    internal abstract class WhatsApp : IMessageService1, Ipayments
    {
        public void SendMessage(string message) { }
        public void SendAudioMessage(string message) { }
        public void SendVideoMessage(string message) { }
        public void ReceiveMessage() { }
        public void DeleteMessage() { }
        public void MakePayment(float amount) { }
        //int
    }
}

