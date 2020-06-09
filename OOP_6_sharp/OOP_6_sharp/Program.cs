using System;

namespace ProgrammingLaba7
{
    public class LinkedList
    {
        Node head; // head of list 

        /* Linked list Node. This inner  
        class is made static so that 
        main() can access it */
        public class Node
        {
            public char data;
            public Node next;
            public Node(char data)
            {
                this.data = data;
                next = null;

            } // Constructor 
        }

        /* This function prints contents of  
        linked list starting from head */
        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }

        public int amountOfStars()
        {
            Node n = head;
            int starsCount = 0;
            while (n != null)
            {
                if (n.data == '*')
                {
                    starsCount += 1;
                }
                n = n.next;
            }
            return starsCount;
        }

        public void removeSymbolsAfterLattice()
        {
            Node n = head;
            while (n != null)
            {
                if (n.data == '#')
                {
                    n.next = null;
                }
                n = n.next;
            }
        }

        /* method to create a simple linked list with 3 nodes*/
        public static void Main(String[] args)
        {
            /* Start with the empty list. */
            LinkedList llist = new LinkedList();

            llist.head = new Node('*');
            Node second = new Node('#');
            Node third = new Node('s');
            Node forth = new Node('*');

            llist.head.next = second; // Link first node with the second node 
            second.next = third; // Link first node with the second node 
            third.next = forth;
            llist.printList();

            Console.WriteLine($"There are { llist.amountOfStars() } * symbols in your LinkedList");
            Console.WriteLine("After removing all elements after # our list looks someting like this");
            llist.removeSymbolsAfterLattice();
            llist.printList();
        }
    }

    /* This code contributed by PrinciRaj1992 */
}
