using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Telephony
{
    public class StationaryPhone : ICallOthers
    {
        private List<string> phoneNumbers;

        public StationaryPhone()
        {
            this.phoneNumbers = new List<string>();
        }
        public void Calling(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
        public void AddingPhones(string number) 
        {
            this.phoneNumbers.Add(number);   
        }
    }
}
