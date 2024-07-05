using System;
using System.IO;

namespace Aula198
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Gabriel\Desktop\file1.txt";
            string targetPath = @"C:\Users\Gabriel\Desktop\file2.txt";

            string[] lines = File.ReadAllLines(sourcePath);

            try
            {
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException error)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(error.Message);
            }
            
        }
    }
}