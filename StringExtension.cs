using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    throw new ArgumentNullException();
                }
            }
            string[] result = array;

            for (int i = 0; i < result.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i].Length > result[j].Length)
                    {
                        string temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
        }
    }
}
