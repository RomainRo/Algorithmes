namespace Algorithmes.Structures.Arrays.Sort.Slow
{
    public static class InsertionSort
    {
        public static void ProcessInsertionSort(this CustomArray customArray)
        {
            for (int currentIndex = 1; currentIndex < customArray.Data.Length; currentIndex++)
            {
                int referenceValue = customArray.Data[currentIndex];

                int i = 0;

                for (i = currentIndex - 1; i >= 0 && referenceValue < customArray.Data[i]; i--)
                {
                    customArray.Data[i+1] = customArray.Data[i];
                }

                customArray.Data[i + 1] = referenceValue;
            }
        }
    }
}
