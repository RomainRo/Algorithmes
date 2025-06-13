using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmes.Structures.Arrays.Sort.Slow
{
    public static class BubbleSort
    {
        public static void ProcessBubbleSort(this CustomArray customArray)
        {
            int decrementation = customArray.Data.Length - 1;

            while (decrementation > 0)
            {
                bool swap = false;

                for (int i = 0; i < decrementation; i++)
                {
                    if (customArray.Data[i] > customArray.Data[i + 1])
                    {
                        (customArray.Data[i + 1], customArray.Data[i]) = (customArray.Data[i], customArray.Data[i + 1]);
                        swap = true;
                    }
                }

                if (!swap)
                {
                    break;
                }

                decrementation--;
            }
        }
    }
}
