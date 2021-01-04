using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_With_Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack_using_Linkedlist list = new Stack_using_Linkedlist();
            list.Push(2);
            list.Push(3);
            list.Push(4);
            list.Push(5);
            list.Print();
          
            
            Console.ReadKey();
            list.Pop(4);
           
            
            list.Print();
            Console.ReadKey();
            list.Peek();
            Console.ReadKey();

        }
    }
   public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    public class Stack_using_Linkedlist
    {
        Node head;
        public void Push(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(data);
            return;

        }
             
        public void Pop(int data)
        {
            Node current = head;
           
            while(current.next.next!=null)
            {
              
                current = current.next; 
            }
            if(current.next.data==data)
            {
                Console.WriteLine("The value on the top of the stack is {0},that has been deleted!!!", current.next.data);
                current.next = current.next.next;
                return;
            }
            else
            {
                Console.WriteLine("The value {0} you wanna pop out is not present at the top of the stack!!!", data);
            }
             
            }
        public void Peek()
        {
            Node current = head;
            while(current.next!=null)
            {
                current = current.next;
            }

            Console.WriteLine("The value at the top of the stack is {0}", current.data);
            
        }
        

        public void Print()
        { 
            Node current = head;

            while(current!=null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
