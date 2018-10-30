using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impossible_Game
{
    public class MyList<T>
    {
        private Node<T> head;
        private int size;
        public MyList()
        {
            head = new Node<T>(default(T));
            head.SetNext(head);
            head.SetPrev(head);
            size = 0;
        }

        public void AddToBack(T value)
        {
            Node<T> node = new Node<T>(value);
            node.SetNext(head);
            node.SetPrev(head.GetPrev());
            head.GetPrev().SetNext(node);
            head.SetPrev(node);
            size += 1;
        }

        public void Remove(T value)
        {
            if (size == 0)
                throw new Exception("List is empty");
            Node<T> runner = head.GetNext();
            int x = 0;
            while (x < size)
            {
                if (runner.GetValue().Equals(value))
                {
                    runner.GetNext().SetPrev(runner.GetPrev());
                    runner.GetPrev().SetNext(runner.GetNext());
                    size -= 1;
                    return;
                }
                x += 1;
                runner = runner.GetNext();
            }
            throw new Exception("List does not contain value");
        }

        public T GetNth(int n)
        {
            if (size == 0)
                throw new Exception("List is empty");
            Node<T> runner = head.GetNext();
            int x = 0;
            while (x < n)
            {
                runner = runner.GetNext();
                x += 1;
            }
            return runner.GetValue();
        }

        public bool Contains(T value)
        {
            if (size == 0)
                throw new Exception("List is empty");
            Node<T> runner = head.GetNext();
            int x = 0;
            while (x < size)
            {
                if (runner.GetValue().Equals(value))
                {
                    return true;
                }
                x += 1;
                runner = runner.GetNext();
            }
            return false;
        }

        public int GetLength()
        {
            return size;
        }
    }
}