using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        // Write Your Code Here
        int numSwaps = 0;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n - 1; j++)
            {
                if(a[j] > a[j + 1])
                {
                    int saved = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = saved;
                    numSwaps++;
                }
            }
            if(numSwaps == 0)
            {
                break;
            }    
        }

        Console.WriteLine("Array is sorted in " + numSwaps + " swaps.");
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: " + a[n - 1]);
    }
}