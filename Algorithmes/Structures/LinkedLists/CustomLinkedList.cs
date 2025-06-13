namespace Algorithmes.Structures.LinkedLists
{
    public class CustomLinkedList<T>
    {
        public Node<T>? Head { get; set; }
        public int Size { get; set; }


        public void AddFirst(T value)
        {
            Node<T>? current = Head;

            if (current == null)
            {
                Head = new Node<T>() { Value = value };
            }
            else
            {
                Head = new Node<T>() { Value = value, Next = current };
            }

            Size++;
        }

        public void AddLast(T value)
        {
            Node<T>? current = Head;

            if (current == null)
            {
                Head = new Node<T>() { Value = value };
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = new Node<T>() { Value = value };
            }

            Size++;
        }

        public void Add(T value, int position)
        {
            if (position < 0 || position > Size - 1)
            {
                throw new Exception();
            }

            else if (position == 0)
            {
                Head = new Node<T>() { Value = value, Next = Head };
            }
            else
            {
                Node<T>? current = Head;

                while (position > 1)
                {
                    current = current.Next;
                    position--;
                }

                current.Next = new Node<T>() { Value = value, Next = current.Next};
            }

            Size++;
        }

        public void RemoveFirst()
        {
            Node<T>? current = Head;

            if (current == null)
            {
                return;
            }

            Head = current?.Next == null ? null : current.Next;
            Size--;
        }

        public void RemoveLast()
        {
            Node<T>? current = Head;

            if (current == null)
            {
                return;
            }
            else if (current.Next == null)
            {
                Head = null;
                Size--;
                return;
            }

            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;

            Size--;
        }

        public void Remove(int position)
        {
            if (position < 0 || position > Size - 1)
            {
                throw new IndexOutOfRangeException();
            }

            Node<T>? current = Head;

            if (position == 0)
            {
                Head = current.Next;
                Size--;
                return;
            }

            while (position > 1)
            {
                current = current.Next;
                position--;
            }

            current.Next = current.Next.Next;
            Size--;
        }

        public T? Get(int position)
        {
            if (position < 0 || position > Size - 1)
            {
                throw new IndexOutOfRangeException();
            }

            Node<T>? current = Head;

            if (current == null)
            {
                return default;
            }

            if (position == 0)
            {
                return current.Value;
            }

            while (position > 1)
            {
                current = current.Next;
                position--;
            }

            return current.Next.Value;
        }

        public bool Contains(T value)
        {
            Node<T>? current = Head;

            if (current == null)
            {
                return false;
            }

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }
                else
                {
                    current = current.Next;
                }
            }

            return false;
        }


        public void Print()
        {
            Node<T> current = Head;

            while (current != null)
            {
                Console.Write($"{current.Value} -> ");
                current = current.Next;
            }

            Console.Write("null");
        }
    }
}
