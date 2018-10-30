using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impossible_Game
{
    public class HashSet<T>
    {
        private MyList<T>[] table;
        private int ARRAY_SIZE;
        public HashSet(int size)
        {
            ARRAY_SIZE = size;
            table = new MyList<T>[ARRAY_SIZE];
        }

        public void Add(T item)
        {
            int index = Math.Abs(item.GetHashCode() % ARRAY_SIZE);
            if (table[index] == null)
            {
                table[index] = new MyList<T>();
                table[index].AddToBack(item);
                return;
            }
            for (int i = 0; i < table[index].GetLength(); i++)
            {
                if (table[index].GetNth(i).Equals(item))
                {
                    return;
                }
            }
            table[index].AddToBack(item);
        }

        public bool Contains(T item)
        {
            int index = Math.Abs(item.GetHashCode() % ARRAY_SIZE);
            if (table[index] == null)
                return false;
            for (int i = 0; i < table[index].GetLength(); i++)
            {
                if (table[index].GetNth(i).Equals(item))
                    return true;
            }
            return false;
        }

        public T Get(T item)
        {
            if (Contains(item) == false)
            {
                throw new Exception("That item is not in the hashset");
            }
            int index = Math.Abs(item.GetHashCode() % ARRAY_SIZE);
            for (int i = 0; i < table[index].GetLength(); i++)
            {
                if (table[index].GetNth(i).Equals(item))
                    return table[index].GetNth(i);
            }
            throw new Exception("That item is not in the hashset");
        }

        public void Remove(T item)
        {
            if (Contains(item) == false)
            {
                throw new Exception("That item is not in the hashset");
            }
            int index = Math.Abs(item.GetHashCode() % ARRAY_SIZE);
            for (int i = 0; i < table[index].GetLength(); i++)
            {
                if (table[index].GetNth(i).Equals(item))
                    table[index].Remove(table[index].GetNth(i));
            }
        }
    }
}