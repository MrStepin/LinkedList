using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private Element<T> firstElement;
        private Element<T> lastElement;

        public void Add(T data)
        {
            Element<T> element = new Element<T>(data);

            if (firstElement == null)
            {
                firstElement = element;
            }
            else
            {
                lastElement.Next = element;
            }
            lastElement = element;
        }

        public void Print()
        {
            Element<T> current = firstElement;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.ReadKey();
        }

        public void Remove(int numberOfElement)
        {
            if (firstElement == null)
                return;

            if (numberOfElement == 0)
            {
                firstElement = firstElement.Next;
                if (firstElement == null)
                {
                    lastElement = null;
                }
                return;
            }

            Element<T> currentElement = firstElement;
            Element<T> previousElement = null;

            while (numberOfElement-- > 0 && currentElement != null)
            {
                previousElement = currentElement;
                currentElement = currentElement.Next;
            }

            if (currentElement == null)
                return;

            previousElement.Next = currentElement.Next;

            if (currentElement.Next == null)
            {
                lastElement = previousElement;
            }
        }

        public bool Contains(T data)
        {
            Element<T> currentElement = firstElement;
            while (currentElement != null)
            {
                if (currentElement.Data.Equals(data))
                    return true;
                currentElement = currentElement.Next;
            }
            return false;
        }
    }
}