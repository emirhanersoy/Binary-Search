using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {

        public static int binarySearch(int[]a, int key)
        {
            int left, right, mid;
            left = 0;
            right = a.Length - 1;

            while (left < right)
            {
                mid=(left+right)/2;

                if (a[mid] < key)
                    left = mid+1;  
                

                else if (a[mid] > key)
                    right = mid-1;
                

                else {
                    Console.WriteLine(key + " is found");
                    return mid;
                }
            

            }

            Console.WriteLine(key + " is not found");
            return -1;


        }

        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 5, 6, 7 ,8,9,10};
            binarySearch(array, 3);
            Console.ReadKey();

        }
    }
}
