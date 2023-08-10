using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public  class Family
    {
        private List<Person> people = new();
        public Family() 
        { 
        this.people = new List<Person>();
        
        }
        public void AddMember(Person member)
        {
            this.people.Add(member);
        }
        public Person GetOldestMember()
        {
            return this.people.MaxBy(p=>p.Age);
        }
    }
}
