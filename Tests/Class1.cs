using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LinkedList;


namespace Tests
{
    public class Tests
    {
        LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
        int number1 = 1;
        int number5 = 5;
        int number6 = 6;
        int number7 = 7;

        [Test]
        public void CheckThatElementExist()
        {
            list.Add(number1);
            list.Add(number5);
            list.Add(number6);
            Assert.IsTrue(list.FindElement(number1));
        }

        [Test]
        public void CheckThatElementDoesNotExist()
        {
            list.Add(number1);
            list.Add(number5);
            list.Add(number6);
            Assert.IsFalse(list.FindElement(number7));
        }

        [Test]
        public void CheckRemovingElement()
        {
            list.Add(number1);
            list.Add(number5);
            list.Add(number6);
            list.Remove(2);
            Assert.IsFalse(list.FindElement(number6));
        }
    }
}
