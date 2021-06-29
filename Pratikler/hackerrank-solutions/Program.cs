using System;
using System.Collections.Generic;
using System.Collections;

namespace hackerrank_solutions
{
class Result
{

    

    public static void staircase(int n)
    {
        for (int i=1; i<=n; i++){
           for (int k=0; k < n-i; k++){
               Console.Write(" ");
           }
           for( int j= 0; j < i; j++){
               Console.Write("#");
           }
           Console.Write("\n");
        }
    }

}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter staircase level: ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.staircase(n);
        }

        /*

        -> Plus Minus Challenge Solution

        public static void plusMinus(List<int> arr)
    {
        int totalNegative = 0;
        int totalPositive = 0;
        int totalZeros = 0;
        
        foreach (var num in arr)
        {
            if (num == 0)
            {
                totalZeros++;
            }else if (num > 0){
                totalPositive++;
            }
            else{
                totalNegative++;
            }
        }
        
        Console.WriteLine(string.Format("{0:F6}", (decimal)totalPositive/arr.Count));
        Console.WriteLine(string.Format("{0:F6}", (decimal)totalNegative/arr.Count));
        Console.WriteLine(string.Format("{0:F6}", (decimal)totalZeros/arr.Count));
        
    }
        */
    }



    
}
