
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9 };
            int[] maxValIndices;
            int maxVal = Maxima(testArray, out maxValIndices);
            Console.WriteLine("Maximum value {0} found at element indices:",
                maxVal);
            foreach (int index in maxValIndices)
            {
                Console.WriteLine(index);

            }
            Console.ReadKey();
        }
        static int Maxima(int[] integers, out int[] indices)
        {
            Debug.WriteLine("Maximum value search started.");
            indices = new int[1];
            int MaxVal = integers[0];
            indices[0] = 0;
            int count = 1;
            Debug.WriteLine(string.Format(
                "Maximum value initiated to {0}, at elemt index 0.", maxVal));
            for (int i = 1; i < integers.Length; i++)

            {
                Debug.WriteLine(string.Format(
                    "Now looking at element at index{0}.", i));
                if (integers[i] > maxVal)
                {
                    maxVal = integers[i];
                    count = 1;
                    indices = new int[1];
                    indices[0] = i;
                    Debug.WriteLine(string.Format(
                        "New maximum found. New value is {0}, at element index {1}.",
                        maxVal, i));
                }
                else
                {
                    if (integers[i] == maxVal)

                    {
                        count++;
                        int[] oldindices = indices;
                        indices = new int[count];
                        oldindices.CopyTo(indices, 0);
                        indices[count - 1] = i;
                        Debug.WriteLine(string.Format(
                            "Duplicate maximum found at element index{0}.", 1));

                    }

                }
            }
            Trace.WriteLine(string.Format(
                "Maximum value {0} found, with {1} occurences.", maxVal, count));
            Debug.WriteLine("Maximum value serach completed.");
            return maxVal;



        }
    }
