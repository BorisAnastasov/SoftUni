using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        RandomList list = new RandomList();

        public string RandomString()
        {
            Random random= new Random();
            string elem = this[random.Next(0, Count)];
            list.Remove(elem);
            return elem;
        }
    }
}
