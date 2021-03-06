﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Stretch Goals: Using Generics, which would include implementing GetType() http://msdn.microsoft.com/en-us/library/system.object.gettype(v=vs.110).aspx
namespace SinglyLinkedLists
{
    public class SinglyLinkedListNode : IComparable
    {
        // Used by the visualizer.  Do not change.
        public static List<SinglyLinkedListNode> allNodes = new List<SinglyLinkedListNode>();

        // READ: http://msdn.microsoft.com/en-us/library/aa287786(v=vs.71).aspx
        private SinglyLinkedListNode next;
        public SinglyLinkedListNode Next
        {
            get { return this.next; }
            set 
            {
                if (this == value)
                {
                    throw new System.ArgumentException("No can do");
                }
                else
                {
                    this.next = value;
                }
            }
        }
        private string value;
        public string Value
        {
            get { return value; }
        }

        public static bool operator <(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) < 0;
        }

        public static bool operator >(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) > 0;
        }

        public SinglyLinkedListNode(string value)
        {
            this.value = value;

            // Used by the visualizer:
            allNodes.Add(this);
        }

        // READ: http://msdn.microsoft.com/en-us/library/system.icomparable.compareto.aspx
        public int CompareTo(Object obj)
        {
            SinglyLinkedListNode thisNode = obj as SinglyLinkedListNode;
            if (thisNode != null)
            {
                return this.Value.CompareTo(thisNode.Value);
            }
            else
	        {
                throw new ArgumentException("Object is not a Node");
	        }
        }

        public bool IsLast()
        {
            return (next != null) ? false : true;
        }

        public override bool Equals(object obj)
        {
            SinglyLinkedListNode x = obj as SinglyLinkedListNode;
            return (x != null) ? this.Value.Equals(x.Value) : false;
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}