using System;

namespace EX1_calculation_of_average
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[10] { 30, 30, 50, 3, 40, 10, 100, 33, 3, 9 };
            Console.WriteLine("MaxNumber = " + GetMaxNumber(values));
            Console.WriteLine("MinNumber = " + GetMinNumber(values));
            Console.WriteLine("Average = " + GetMoyenne(values));
            // Sur cet exemple, doit retourner 9.6
        }
        
        static float GetMoyenne(int[] values)
        {
            // Declaration of variables
             float result = 0;
             float average = 0;
    
             for (int i = 0; i < values.Length; i++)
             {
                 // Result = all values of the table 'values' are added.
                 result = values[i] + result;
             }
             // We divide the result variables by the total all of vlaue in table 
             average = result / values.Length;
             return average;
        }

        static float GetMaxNumber(int[] values)
        {   
            // Declaration of variable 
            int maxNumber = values.Length;
            
            foreach (int nb in values)
            {
                maxNumber = Math.Max(maxNumber, nb); // Returns the larger of two 32-bit signed integers.
            }
            return maxNumber;
        }
        
        static float GetMinNumber(int[] values)
        {   
            // Declaration of variable 
            int minNumber = values.Length;
            
            foreach (int nb in values)
            {
                minNumber = Math.Min(minNumber, nb); // Returns the smaller of two 32-bit signed integers
            }
            return minNumber;
        }
        
    }
}