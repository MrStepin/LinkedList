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
        int number1 = 1;
        int number5 = 5;
        int number6 = 6;
        int number7 = 7;

        [Test]
        public void CheckThatElementExist()
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            list.Add(number1);
            list.Add(number5);
            list.Add(number6);
            Assert.IsTrue(list.Contains(number1));
        }

        [Test]
        public void CheckThatElementDoesNotExist()
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            list.Add(number1);
            list.Add(number5);
            list.Add(number6);
            Assert.IsFalse(list.Contains(number7));
        }

        [Test]
        public void CheckRemovingMiddleElement()
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            list.Add(number1);
            list.Add(number5);
            list.Add(number6);
            list.Remove(1);
            Assert.IsFalse(list.Contains(number5));
        }

        [Test]
        public void CheckRemovingLastElement()
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            list.Add(number1);
            list.Add(number5);
            list.Add(number6);
            list.Remove(2);
            Assert.IsFalse(list.Contains(number6));
        }

        [Test]
        public void CheckRemovingFirstElement()
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            list.Add(number1);
            list.Add(number5);
            list.Add(number6);
            list.Remove(0);
            Assert.IsFalse(list.Contains(number1));
        }

        [Test]
        public void CheckThatElementNotExistIFListIsEmpty()
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            Assert.IsFalse(list.Contains(number1));
        }

        [Test]
        public void CheckThatRemovingElementIsNotExist()
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            list.Add(number1);
            list.Add(number5);
            list.Add(number6);
            list.Remove(3);
            Assert.Fail();
        }
    }
}
