using System;
using System.IO;
using System.Collections.Generic;

namespace Aula199
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Gabriel\Desktop\teste";

            try
            { 
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string folder in folders) {
                    Console.WriteLine(folder);
                }
                Console.WriteLine();
  
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException error)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(error.Message);
            }
        }
    }
}
