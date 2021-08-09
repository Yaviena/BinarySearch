using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[100];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = i + 1;
            }
            Console.WriteLine(BinarySearching(tab, 88));
        }
        public static string BinarySearching(int[] array, int item)
        {
            Array.Sort(array);

            int mid, guess, step = 0;
            int low = 0;
            int high = array.Length - 1;

            //while ((low <= high) && (array[^1] >= item))
            while ((low <= high) && (array[array.Length - 1] >= item))
            {
                mid = (low + high) / 2;
                guess = array[mid];
                step++;

                Console.WriteLine($"step: {step} | low: {low} | mid: {mid} | high: {high} | guess: {guess}");

                if (guess == item)
                {
                    return "The item is on the list. You guess in " + step + " round.";
                }
                if (guess < item)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return "\nThe item is not on the list. now You have know this in " + step + " rounds.";
        }
    }
}
