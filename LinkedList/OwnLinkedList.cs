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
            Element<T> currentElement = firstElement;
            Element<T> previousElement = null;
            int counter = 0;

            while (currentElement != null)
            {
                if (counter == numberOfElement)
                {
                    if (previousElement != null)
                    {
                        previousElement.Next = currentElement.Next;
                        if (currentElement.Next == null)
                        {
                            lastElement = previousElement;
                        }
                    }
                    else
                    {
                        firstElement = firstElement.Next;
                        if (firstElement == null)
                        {
                            lastElement = null;
                        }
                    }

                }
                counter += 1;
                previousElement = currentElement;
                currentElement = currentElement.Next;
            }
        }

        public bool FindElement(T data)
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