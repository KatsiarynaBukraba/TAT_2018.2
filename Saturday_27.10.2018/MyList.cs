using System.Collections;
using System.Collections.Generic;

namespace Saturday_27._10._2018
{
    public class MyList<T> : IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int Count { get; set; }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null) head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            Count++;
        }

        public void AddHead(T data)
        {
            Node<T> node = new Node<T>(data);

            Node<T> temp = head;
            node.Next = temp;
            head = node;
            if (Count == 0) tail = head;
            else temp.Previous = node;

            Count++;
        }

        public bool IsEmpty { get { return Count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            Node<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}
