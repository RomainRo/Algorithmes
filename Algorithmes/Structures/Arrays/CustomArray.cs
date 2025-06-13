namespace Algorithmes.Structures.Arrays
{
    public class CustomArray
    {
        public int[] Data {  get; set; } = new int[0];

        public void AddItemAtBeginning(int item)
        {
            int[] array = new int[Data.Length + 1];
            array[0] = item;

            for (int i = 0; i < Data.Length; i++)
            {
                array[i+1] = Data[i];
            }

            Data = array;
        }

        public void AddItemAtEnd(int item)
        {
            int[] array = new int[Data.Length + 1];
            array[^1] = item;

            for (int i = 0; i < Data.Length; i++)
            {
                array[i] = Data[i];
            }

            Data = array;
        }

        public void AddItemAtPosition(int item, int position)
        {
            if (position < 0 || position > Data.Length)
            {
                throw new Exception();
            }

            int[] array = new int[Data.Length + 1];

            int i = 0;
            int j = 0;

            while (i < Data.Length)
            {
                if (i == position)
                {
                    array[j] = item;
                    j++;
                }

                array[j] = Data[i];

                i++;
                j++;
            }

            Data = array;
        }

        public void RemoveItemAtBeginning()
        {
            if (Data.Length == 0)
            {
                return;
            }

            int[] array = new int[Data.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Data[i + 1];
            }

            Data = array;
        }

        public void RemoveItemAtEnd()
        {
            if (Data.Length == 0)
            {
                return;
            }

            int[] array = new int[Data.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Data[i];
            }

            Data = array;
        }

        public void RemoveItemAtPosition(int position)
        {
            if (Data.Length == 0)
            {
                return;
            }

            int[] array = new int[Data.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (i < position)
                {
                    array[i] = Data[i];
                }
                else if (i >= position)
                {
                    array[i] = Data[i + 1];
                }
            }

            Data = array;
        }
    }
}
