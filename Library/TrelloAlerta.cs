using System;

namespace LSPLibrary
{
    public class TrelloAlerta : IAlerta
    {
        public void Send(String texto)
        {
        new TrelloCardCreator().CreateCard(texto);
        }
    }
}