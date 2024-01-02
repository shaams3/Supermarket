using System;
using System.Collections.Generic;
using System.Text;

namespace jo
{
    public class LinkedList
    {
        public Node head { get; set; }

        // Node structure
        public class Node
        {
            public int Data { get; set; } // Adjust data type as needed
            public Node Next { get; set; }
        }

        // Add a new node to the end of the list
        public void Add(int data)
        {
            Node newNode = new Node() { Data = data };

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        // Remove a node with the specified data
        public void Remove(int data)
        {
            if (head == null)
            {
                return; // List is empty
            }

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                return; // Node not found
            }

            current.Next = current.Next.Next;
        }

        // Update the data of a node with the specified data
        public void Update(int dataToUpdate, int newData)
        {
            if (head == null)
            {
                return; // List is empty
            }

            Node current = head;
            while (current != null && current.Data != dataToUpdate)
            {
                current = current.Next;
            }

            if (current == null)
            {
                return; // Node not found
            }

            current.Data = newData;
        }

        // Print the elements of the linked list
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }


    }
}