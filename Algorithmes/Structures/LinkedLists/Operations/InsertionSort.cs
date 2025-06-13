namespace Algorithmes.Structures.LinkedLists.Operations
{
    public static class InsertionSort
    {
        public static void ProcessInsertionSort(this CustomLinkedList<int> linkedList)
        {
            Node<int>? current = linkedList.Head;

            if (current == null || current.Next == null)
            {
                return;
            }

            CustomLinkedList<int> sortedLinkedList = new();

            while (current != null)
            {
                Node<int>? currentSorted = sortedLinkedList.Head;

                if (currentSorted == null)
                {
                    sortedLinkedList.AddFirst(current.Value);
                }
                else
                {
                    for (int index = 1; currentSorted != null; index++)
                    {
                        if (current.Value < currentSorted.Value)
                        {
                            sortedLinkedList.Add(current.Value, index);
                        }
                        else
                        {
                            sortedLinkedList.Add(current.Value, index + 1);
                        }

                        currentSorted = currentSorted.Next;
                    }
                }

                current = current.Next;
            }

            linkedList.Head = sortedLinkedList.Head;
        }
    }
}
