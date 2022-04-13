using System;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // For create and write in files
            string txt = "Exemple of text to write into disk files";
            File.WriteAllText("test.txt", txt); // Params:  path – The file to write to. | contents – The string to write to the file
           
            // For display the content 
            string readTxt = "";
            readTxt = File.ReadAllText("test.txt"); // Params:  path – The file to open for reading.
            Console.WriteLine("Content of file = " + readTxt );
            
        }
    }
}

 