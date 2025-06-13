namespace Algorithmes.Structures.Arrays.Sort.Slow
{
    public static class SelectionSort
    {
        public static void ProcessSelectionSort(this CustomArray customArray)
        {
            for (int currentIndex = 0; currentIndex < customArray.Data.Length - 1; currentIndex++)
            {
                int currentValue = customArray.Data[currentIndex];
                int minValue = customArray.Data[currentIndex];
                int minValueIndex = currentIndex;

                for (int i = currentIndex + 1; i < customArray.Data.Length; i++)
                {
                    if (customArray.Data[i] < minValue)
                    {
                        minValue = customArray.Data[i];
                        minValueIndex = i;
                    }
                }

                if (currentIndex != minValueIndex)
                {
                    customArray.Data[minValueIndex] = currentValue;
                    customArray.Data[currentIndex] = minValue;
                }
            }
        }
    }
}
