using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DEQueue
{
    public class Node<T>
    {
        public Node()
        {
        }

        public Node(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }

        private Node<ArrayList> arr;
    }

    public class DEQueue<T> : IEnumerable<T>
    {
        private Node<T> head; // головной/первый элемент
        private Node<T> tail; // последний/хвостовой элемент

        public Array convertToArray()
        {
            return this.ToArray();
        }

        // Добавление элемента в конец
        public void pushBack(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            size++;
        }

        // Добавление элемента в начало
        public void pushFront(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = head;
            node.Next = temp;
            head = node;
            if (size == 0)
                tail = head;
            else
                temp.Previous = node;
            size++;
        }

        // Удаление из начала очереди
        public T popFront()
        {
            if (size == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            head = head.Next;
            size--;
            return output;
        }

        // Удаление из конца очереди
        public T popBack()
        {
            if (size == 0)
                throw new InvalidOperationException();
            T output = tail.Data;
            tail = tail.Previous;
            tail.Next = null;
            size--;
            return output;
        }

        // Посмотреть первый элемент
        public T front
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }

        // Посмотреть последний элемент
        public T back
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }

        // Размер очереди
        public int size { get; private set; }

        public bool IsEmpty { get { return size == 0; } }

        // Очищение очереди
        public void Clear()
        {
            head = null;
            tail = null;
            size = 0;
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
