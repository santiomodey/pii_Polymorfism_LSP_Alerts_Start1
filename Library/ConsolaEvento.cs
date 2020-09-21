using System;
namespace LSPLibrary
{
    public class ConsolaEvento : IEvent
    {
        public string EventName { get; set; }
        public void Notify()
        {
            new ConsolaAlerta().Send(this.EventName);
        }
    }
}