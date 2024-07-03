using System.Collections;

namespace LinkedList.Model
{
    public class LinkedList<T> : IEnumerable
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public LinkedList(T data)
        {
            var item = new Item<T>(data);

            SetHeadAndTail(item);
        }
        public void Add(T data)
        {
            var item = new Item<T>(data);
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(item);
            }
        }
        public void Remove(T data)
        {
            var current = Head.Next;
            var previous = Head;
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = current;
                    Count--;
                    return;
                }
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;

                }
            }
        }
        private void SetHeadAndTail(Item<T> data)
        {
            Head = data;
            Tail = data;
            Count = 1;
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public void AppendHead(T data)
        {
            var previous = new Item<T>(data);
            previous.Next = Head;
            Head = previous;
            Count++;
        }
        public void InsertAfter(T target, T data)
        {
            var current = Head;
            var next = new Item<T>(data);
            if (Head != null)
            {
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        next.Next = current.Next;
                        current.Next = next;
                        Count++;
                        return;
                    }

                    current = current.Next;
                }
            }
            else
            {
                //Нужно решить что делать, добавлять в начало или ничего не вставлять
            }
        }
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }
    }
}
