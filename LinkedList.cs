using System;
using System.Collections.Generic;

namespace LinkedListAlgo
{

    class LinkedList
    {
        Node head;

        public class Node
        {
           public int data;
           public Node next;
            public Node(int d)
            {
                 data = d;
            }
        }

        public void PrintList(){
            Node n = head;

            while(n != null){
                Console.Write(n.data + " ");
                n= n.next;
            } 
        }


        public static void MainC(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            linkedList.head.next = second;
            second.next = third;

            linkedList.PrintList();
        }

    }
}

