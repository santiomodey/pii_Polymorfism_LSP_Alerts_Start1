using System;

namespace LSPLibrary
{
    /// <summary>
    /// El metodo Send no cumple con el patrón poliformismo
    /// ya que el codigo que varía segun tiene distintos destinatarios
    /// deberia estar en diferentes clases con una operación polimórfica
    /// </summary>
    public class Alert
    {
        public void Send(string type, string text)
        {
            if (type == "trello")
            {
                new TrelloCardCreator().CreateCard(text);
            }
            else if (type == "text") 
            {
                Console.WriteLine(text);
            }
        }
    }
}