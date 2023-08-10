using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface IEnumerable<Book> : IEnumerable
{

}
namespace IteratorsAndComparators
{
    public class Library: IEnumerable<Book>
    {
        private List<Book> Books;
        public  Library(params Book[] books)         
        { 
           this.Books = new List<Book>();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return Books.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator() 
        { 
            return GetEnumerator(); 
        
        }
    }
}
