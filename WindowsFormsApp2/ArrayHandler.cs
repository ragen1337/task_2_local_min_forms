using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ArrayHandler
    {
        public static int[] RandomArrayGenerator(int Amount)
        {
            Random random = new Random();
            int[] array = new int[Amount];
            int i = 0;
            foreach (int elem in array)
            {
                array[i] = random.Next(1, 50);
                Console.WriteLine(i + ") " + array[i]);
                i++;
            }

            return array;
        }

        public static int LocalMinimumAmount(int[] array)
        {
            int amount = 0;
            int array_length = array.Length;

            if (array[0] < array[1])
                amount++;
            if (array[array_length - 1] < array[array_length - 2])
                amount++;

            for (int i = 1; i < array_length - 1; i++)
            {
                if (array[i] < array[i - 1] && array[i] < array[i + 1])
                {
                    amount++;
                    i++;
                }
            }

            return amount;
        }
    }
}
