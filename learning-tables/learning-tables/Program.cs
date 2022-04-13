using System;
using System.Collections.Generic;
namespace learning_tables
{
    class Program
    {
        // Creation Tables
        static int[] tableInt = { 10, 4, 6 ,7, 5, 6};
        static List<string> name = new List<string>();

        static void Main()
        {
            
            // Console.WriteLine(tableInt[0]);
            // Modify entries of tables
            // tableInt[0] = 100; 
            // Console.WriteLine(tableInt[0]);
            
          // Display all entries in tables
            // for (int i = 0; i < tableInt.Length; i++)
            // {
            //     Console.WriteLine("\ni = " + i + " tab[i] = " + tableInt[i]);
            // }
            //Multiply_Tables();
            name.Add("Hello");
            name.Add("Salut");
            name.Clear();
            name.Add("Hy");
           

            foreach (string str in name)
            {
                Console.WriteLine(str);
            }

        }
        
        // Multiply all entries of tables
        static void Multiply_Tables()
        {
            // Multiply all entries of tables
            for (int i = 0; i < tableInt.Length; i++)
            {
                tableInt[i] = tableInt[i] * 2;
            }
            
            for (int i = 0; i < tableInt.Length; i++)
            {
                Console.WriteLine("\ni = " + i + " tab[i] = " + tableInt[i]);
            }
        }
    }
    
}

