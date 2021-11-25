using System;

namespace SLL
{
    /// <summary>
    /// A simple basic implementation of singly linked list in C#. The List class implements Add, Find and Delete functionality without using built-in .NET classes.
    /// </summary> 
    internal class LinkedList
    {        
        /// <summary>
        /// Node class
        /// </summary>
        internal class Node
        {
            /// <summary>
            /// Pointer to next node.
            /// </summary>
            internal Node Next { get; set; }

            /// <summary>
            /// Data stored in the node.
            /// </summary>
            internal int Data { get; }

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="d"></param>
            internal Node(int d)
            {
                Data = d;
            }
        }

        private Node _head;

        /// <summary>
        /// Length of the list
        /// </summary>
        internal int Length { get; private set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        internal LinkedList()
        {
            Length = 0;
            _head = null;
        }

        /// <summary>
        /// Display all nodes.
        /// </summary>
        internal void ShowNodes()
        {
            // Print all nodes till the end of the list.
            var current = _head;
            if (current == null)
            {
                Console.WriteLine("No more nodes to display.");
                Console.WriteLine();
            }
            else
            {
                ShowLength();
                while (current != null)
                {
                    Console.WriteLine("Node : " + current.Data);
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Show length of the list.
        /// </summary>
        internal void ShowLength()
        {
            var numString = "numbers";
            if (Length == 1)
            {
                numString = "number";
            }
            Console.WriteLine($"List has [{Length.ToString()}] {numString}.");
        }

        /// <summary>
        /// To insert a new Node at the end of the list.
        /// </summary>
        /// <param name="d"></param>
        internal void Add(int d)
        {
            Console.WriteLine();
            Console.WriteLine($"Add node [{d.ToString()}].");
            // Create a new Node instance with given data;
            var newNode = new Node(d);
            var current = _head;
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                // Traverse till the end of the list....
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // Add new node as the next node to the last node.
                current.Next = newNode;
            }
            Length++;
            ShowNodes();
        }

        /// <summary>
        /// Delete the node matching specified number, if it exists.
        /// </summary>
        /// <param name="d"></param>
        internal void Delete(int d)
        {
            Console.WriteLine();
            Console.WriteLine($"Delete node [{d.ToString()}].");
            // Find the node to be deleted. 
            var current = _head;

            if (current != null)
            {
                // Handle the case for 'head' node when first node matches the node to be deleted.
                if (current.Data == d)
                {
                    // If first node is not the only node
                    current = current.Next ?? null;
                    _head = current;
                    Length--;
                }
                else
                {
                    while (current.Next != null && current.Next.Data != d)
                    {
                        current = current.Next;
                    }
                    if (current.Next != null && current.Next.Data == d)
                    {
                        // Set the next pointer of the previous node to be the node next to the one that is being deleted.
                        current.Next = current.Next.Next;
                        // Delete the node
                        Length--;
                    }
                    else
                    {
                        Console.WriteLine(d + " could not be found in the list.");                        
                    }
                }
            }
            ShowNodes();
        }

        /// <summary>
        /// Find node matching the specified number.
        /// </summary>
        /// <param name="d"></param>
        /// <returns>Returns node matching specifying int.</returns>
        internal void Find(int d)
        {
            Console.WriteLine();
            Console.WriteLine($"Find node [{d.ToString()}].");
            var current = _head;
            if (current != null)
            {
                var counter = 1;
                while (current.Next != null && current.Data != d)
                {
                    current = current.Next;
                    counter++;
                }

                Console.WriteLine(current.Data == d
                    ? $"Found {d.ToString()} in the list at position [{counter.ToString()}]."
                    : $"{d.ToString()} was not found in the list.");
            }
            else
            {
                Console.WriteLine($"{d.ToString()} was not found in the list.");
            }
            ShowNodes();
        }
    }
}