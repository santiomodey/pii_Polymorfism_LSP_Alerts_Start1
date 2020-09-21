using System;
namespace LSPLibrary
{
    public class ConsolaAlerta : IAlerta
    {
        public void Send(String texto)
        {
            Console.WriteLine(texto);
        }
    }
}