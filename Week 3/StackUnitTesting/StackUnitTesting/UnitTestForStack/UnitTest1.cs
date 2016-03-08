using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackUnitTesting;

namespace UnitTestForStack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Stack_IsEmpty_New_Stack_ReturnsTrue()
        {
            Stack stack = new Stack();
            bool expected = true;
            bool actual = stack.isEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_IsEmpty_Pop_Until_Empty_ReturnsTrue()
        {
            Stack stack = new Stack();
            stack.Push("Testing");

            while (!stack.isEmpty())
            {
                stack.Pop();
            }

            bool expected = true;
            bool actual = stack.isEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_Pop_IsEmpty_Stack_ReturnsFalse()
        {
            Stack stack = new Stack();
            stack.Push("Testing");

            bool expected = false;
            bool actual = stack.isEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Stack_Peek_OnEmptyStack_ThrowException()
        {
            Stack stack = new Stack(); 
            stack.Peek();            
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Stack_Pop_OnEmptyStack_ThrowException()
        {
            Stack stack = new Stack();
            stack.Pop();
        }

        [TestMethod]
        public void Stack_PushPeek_ReturnLastString()
        {
            Stack stack = new Stack();
            stack.Push("Testing1");
            stack.Push("Testing2");
            stack.Push("Testing3");
            stack.Push("Testing4");
            stack.Push("Testing5");

            string expected = "Testing5";
            string actual = stack.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_PushCount_ReturnCount()
        {
            Stack stack = new Stack();
            stack.Push("Testing1");
            stack.Push("Testing2");
            stack.Push("Testing3");
            stack.Push("Testing4");
            stack.Push("Testing5");

            int expected = 5;
            int actual = stack.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_Count_EmptyStack_ReturnCount()
        {
            Stack stack = new Stack();

            int expected = 0;
            int actual = stack.Count();

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Stack_PushPopCount_EmptyStack_ReturnCount()
        {
            Stack stack = new Stack();
            stack.Push("Testing1");
            stack.Push("Testing2");

            stack.Pop();

            int expected = 1;
            int actual = stack.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_PushPopPeek_EmptyStack_ReturnLastString()
        {
            Stack stack = new Stack();
            stack.Push("Testing1");
            stack.Push("Testing2");
            stack.Push("Testing3");

            stack.Pop();

            string expected = "Testing2";
            string actual = stack.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_PushLargeAmountCount_ReturnCount()
        {
            Stack stack = new Stack();
            for (int i = 0; i < 10000000; i++)
            {
                stack.Push("Testing");
            }
           
            int expected = 10000000;
            int actual = stack.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_PushPopLargeAmount_ReturnCount()
        {
            Stack stack = new Stack();
            for (int i = 0; i < 10000000; i++)
            {
                stack.Push("Testing");
            }

            for (int i = 0; i < 10000000; i++)
            {
                stack.Pop();
            }

            int expected = 0;
            int actual = stack.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Stack_Push_PopPastEmpty_ThrowException()
        {
            Stack stack = new Stack();
            stack.Push("Testing1");
            stack.Push("Testing2");
            stack.Push("Testing3");
            stack.Push("Testing4");
            stack.Push("Testing5");

            //Loop one more than items in stack
            for (int i = 0; i < 6; i++)
            {
                stack.Pop();
            }                        
        }
    }


}
