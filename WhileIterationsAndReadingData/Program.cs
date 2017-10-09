using System;
using System.IO;

namespace WhileIterationsAndReadingData
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Values.txt");
            string line = "";
            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null){
                    Console.WriteLine(line);
                }
            }
            myReader.Close();
            Console.ReadLine();
        }
    }
}
