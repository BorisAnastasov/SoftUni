using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Telephony
{
    public class Smartphone:ICallOthers
    {
        private List<string> phoneNumbers;
        private List<string> websites;

        public Smartphone()
        {
            this.phoneNumbers = new();
            this.websites = new();
        }

        public void AddingWeb(string web)
        {
            websites.Add(web);
        }
        public void AddingPhones(string phoneNumber)
        {
            phoneNumbers.Add(phoneNumber);
        }
        public void Calling(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
        public void Browsing(string web)
        {
            Console.WriteLine($"Browsing: {web}!");
        }
    }
}
