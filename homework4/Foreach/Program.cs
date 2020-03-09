using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{

    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    delegate void Func(string n);

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> n;
            n = this.head;
            while (n != null)
            {
                action(n.Data);
                n = n.Next;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }

            int max = int.MinValue;
            intlist.ForEach(n => max = (max > n) ? max : n);
            Console.WriteLine(max);
            int min = int.MaxValue;
            intlist.ForEach(n => min = (min < n) ? min : n);
            Console.WriteLine(min);
            int total = 0;
            intlist.ForEach(n => total += n);
            Console.WriteLine(total);

        }

    }
}