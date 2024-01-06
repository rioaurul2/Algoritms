using System;

class Program
{
    static void Main()
    {
        int[] arrayNumbers = { 0, 1, 2, 1, 0, 2, 1, 2, 0, 1, 1 };

        //Console.WriteLine("This array is sorted by the build in 'Array.Sort()' method");

        //Array.Sort(arrayNumbers);

        //for(int i = 0; i < arrayNumbers.Length; i++)
        //{
        //    Console.Write(arrayNumbers[i]+ " ");
        //}

        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            Console.Write(arrayNumbers[i] + " ");
        }

        Console.WriteLine("");

        Sort012SArray(arrayNumbers);

        PrintArray(arrayNumbers);

    }
    static void Sort012SArray(int[] array)
    {
        int low = 0;
        int high = array.Length - 1;
        int mid = 0;

        while (mid <= high)
        {
            switch (array[mid])
            {
                case 0:
                    Swap(array, low, mid);
                    low++;
                    mid++;

                    break;
                case 1:
                    mid++;

                    break;
                case 2:
                    Swap(array, mid, high);
                    high--;

                    break;
            }
        }
    }

    static void Swap(int[] array, int i, int j)
    {
        int container = array[i];
        array[i] = array[j];
        array[j] = container;
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }

}