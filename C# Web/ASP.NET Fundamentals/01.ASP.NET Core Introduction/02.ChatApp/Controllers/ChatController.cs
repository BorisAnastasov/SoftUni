using ChatApp.Models.Message;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ChatApp.Controllers
{
    public class ChatController : Controller
    {
        private static List<KeyValuePair<string,string>> s_messages = new List<KeyValuePair<string,string>>();

        [HttpPost]
        public IActionResult Send(ChatViewModel chat) 
        {
            var newMessages = chat.CurrentMessage;

            s_messages.Add(
            new KeyValuePair<string, string>(newMessages.Sender, newMessages.MessageText));

            return RedirectToAction("Show");
        }

        public IActionResult Show() 
        {
            if (s_messages.Count()<1) 
            {
                return View(new ChatViewModel());
            }

            var chatModel = new ChatViewModel()
            {
                Messages = s_messages.Select(m => new MessageViewModel()
                {
                    Sender = m.Key,
                    MessageText = m.Value

                })
                .ToList()
            };

            return View(chatModel);
           
        }


    }
}
