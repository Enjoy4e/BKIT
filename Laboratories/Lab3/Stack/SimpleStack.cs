using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;
namespace Lab3
{
    class SimpleStack<T> : SimpleList<T> where T : IComparable  
    {
        public void Push(T elem) 
        {
            Add(elem); 
        }

        public T Pop()
        {
            T elem = default(T); 

            if (this.Count == 0) return elem; 
            if (this.Count == 1) 
            {
                elem = this.first.data;
                this.first = null;
                this.last = null;
            }
            else 
            {
                SimpleListItem<T> newLast = this.GetItem(this.Count - 2);
                elem = newLast.next.data;
                this.last = newLast; 
                newLast.next = null;
            }
            this.Count--;
            return elem;
        }
    }
}
