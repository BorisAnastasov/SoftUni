using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Telephony
{
    public interface ICallOthers
    {
        void Calling(string number);
        void AddingPhones(string number);
        
    }
}
