using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
   
    public class Stack<T>
    {
       
        private List<T> _items = new List<T>();

        public int Count => _items.Count;

       
        public void Push(T item)
        {
            
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

           
            _items.Add(item);
        }

      
        public T Pop()
        {
           
            var item = _items.LastOrDefault();

           
            if (item == null)
            {
                throw new NullReferenceException("Стек пустий. Нема елементів для получення.");
            }

           
            _items.RemoveAt(_items.Count - 1);

          
            return item;
        }

       
        public T Peek()
        {
            
            var item = _items.LastOrDefault();

           
            if (item == null)
            {
                throw new NullReferenceException("Стек пустий. Нема елементів для получення.");
            }

            return item;
        }
    }
}