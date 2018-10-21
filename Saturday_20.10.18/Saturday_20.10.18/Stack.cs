using System;

namespace Saturday_20._10._18
{
    public class Stack<T>
    {
        private T[] items;
        private int count;
        const int defaultSize = 10;

        public Stack()
        {
            items = new T[defaultSize];
        }

        public Stack(int length)
        {
            items = new T[length];
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public int Count
        {
            get { return count; }
        }

        public void Push(T item)
        {
            if (count == items.Length)
                Resize(items.Length + 10);

            items[count++] = item;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty!");
            T item = items[--count];
            items[count] = default(T); 

            if (count > 0 && count < items.Length - 10)
                Resize(items.Length - 10);

            return item;
        }

        public T Peek()
        {
            return items[count - 1];
        }

        private void Resize(int max)
        {
            T[] tempItems = new T[max];
            for (int i = 0; i < count; i++)
                tempItems[i] = items[i];
            items = tempItems;
        }
    }
}
