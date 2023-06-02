using System;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T item1;
        private T item2;
        private T item3;
        
        public Guarda3()
        {
            item1 = default(T);
            item2 = default(T);
            item3 = default(T);
        }
        
        public T GetItem(int i)
        {
            if (i == 0)
                return item1;
            else if (i == 1)
                return item2;
            else if (i == 2)
                return item3;
            else
                throw new IndexOutOfRangeException();
        }
        
        public void SetItem(int i, T item)
        {
            if (i == 0)
                item1 = item;
            else if (i == 1)
                item2 = item;
            else if (i == 2)
                item3 = item;
            else
                throw new IndexOutOfRangeException();
        }
    }
}