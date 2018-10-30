using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impossible_Game
{
    public class Node<T>
    {
        public T value;
        Node<T> next;
        Node<T> prev;

        public Node(T val)
        {
            value = val;
        }

        public T GetValue()
        {
            return value;
        }

        public Node<T> GetNext()
        {
            return next;
        }

        public Node<T> GetPrev()
        {
            return prev;
        }

        public void SetNext(Node<T> node)
        {
            next = node;
        }

        public void SetPrev(Node<T> node)
        {
            prev = node;
        }
    }
}
