using Demo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    internal class ObjectStack
    {
        object[] arr;
        int size;
        int tos;
        public ObjectStack(int _size = 10)
        {
            size = _size;
            arr = new object[size];
            tos = -1; // Top of stack is initially empty
        }
        public int Size
        {
            get { return size; }
        }
        public bool IsEmpty()
        {
            return tos == -1; // If top of stack is -1, it is empty
        }
        public bool IsFull()
        {
            return tos == size - 1; // If top of stack is at the last index, it is full
        }
        public void Push(object item)
        {
            if (IsFull())
            {
                throw new StackFullException("stack is full"); // Throw an exception if stack is full
                //return;
            }
            arr[++tos] = item; // Increment top of stack and add item
        }
        public object Pop()
        {
            if (IsEmpty())
            {
                // Return -1 or throw an exception if stack is empty
                throw new StackEmptyException("stack is empty"); // Throw an exception if stack is empty
            }
            return arr[tos--]; // Return item at top of stack and decrement top of stack
        }
    }
}
