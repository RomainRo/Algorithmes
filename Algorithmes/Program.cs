using Algorithmes.Structures.LinkedLists;
using Algorithmes.Structures.LinkedLists.Operations;

namespace Algorithmes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CustomLinkedList<int> linkedList = new();

            linkedList.AddFirst(1);
            linkedList.AddLast(5);
            linkedList.AddLast(3);
            linkedList.AddLast(2);
            linkedList.AddLast(4);

            linkedList.ProcessInsertionSort();

            linkedList.Print();
        }
    }
}
