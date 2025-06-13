namespace Algorithmes.Structures.LinkedLists.Operations
{
    public static class ReverseList
    {
        /// <summary>
        /// Cette méthode va reverse une liste chainée, par contre elle est faite pour les Nodes qui sont des class, on pourrait faire autrement pour des Nodes sous forme de struct
        /// Les struct se manipulent en mémoire comme des valeurs et non pas comme des références.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="linkedList"></param>
        public static void ProcessReverseList<T>(this CustomLinkedList<T> linkedList)
        {
            if (linkedList.Head == null || linkedList.Head.Next == null)
            {
                return;
            }

            bool isFirstNode = true;

            Node<T>? current = linkedList.Head;
            Node<T>? next = current.Next;

            Node<T> saveReference = current.Next;

            while (saveReference != null)
            {
                saveReference = saveReference.Next;

                if (isFirstNode)
                {
                    current.Next = null;
                    isFirstNode = false;
                }

                next.Next = current;
                current = next;

                next = saveReference;
            }

            linkedList.Head = current;
        }

        public static void ProcessReverseList2<T>(this CustomLinkedList<T> linkedList)
        {
            if (linkedList.Head == null || linkedList.Head.Next == null)
            {
                return;
            }

            CustomLinkedList<T> reversedList = new();

            Node<T>? current = linkedList.Head;

            while (current != null)
            {
                reversedList.AddFirst(current.Value);
                current = current.Next;
            }

            linkedList.Head = reversedList.Head;
        }
    }
}
