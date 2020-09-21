using System;
namespace LSPLibrary
{
    public class TrelloEvento : IEvent
    {
        public string EventName { get; set; }
        public void Notify()
        {
            new TrelloAlerta().Send(this.EventName);
        }
    }
}