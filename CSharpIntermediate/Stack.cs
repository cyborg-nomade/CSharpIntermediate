using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Stack
    {
        private List<object> Members { get; } = new();

        public void Push(object obj)
        {
            Members.Add(obj);
        }

        public object Pop()
        {
            if (Members.Count > 0)
            {
                var poppedMember = Members[^1];
                Members.RemoveAt(Members.Count - 1);
                return poppedMember;
            }
            else
            {
                Console.WriteLine("There are no members in this stack");
                return -1;
            }

        }

        public void Clear()
        {
            Members.Clear();
        }

    }
}