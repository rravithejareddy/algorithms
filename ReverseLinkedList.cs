using System;
using System.Collections.Generic;

namespace ReverseLinkedListAlgo
{

    class LinkedList
    {
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
           Node n =  new  Node(4);

            while(n != null){
                Console.Write(n.data + " ");
                n= n.next;
            } 
        }

        public void CircularLlist(Node node, int d ){
              Node temp = node;
              Node n = new Node(d);
              temp.next = node.next;
              
              node.next = n;
              n.next = temp.next;
              
        }

        public void ReverseLinkedList(Node head){
            Node prev = null; Node curr = head; Node next = null;

            while(curr != null){
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;

        }


        public static void MainC(string[] args)
        {
            LinkedList linkedList = new LinkedList();
        





        }

    }
}

