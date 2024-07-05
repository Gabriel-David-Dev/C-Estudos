using System;
using System.IO;


namespace Aula200
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Gabriel\Desktop\file1.txt";

            Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(path)}");
            Console.WriteLine($"GetFileName: {Path.GetFileName(path)}");
            Console.WriteLine($"GetExtension: {Path.GetExtension(path)}");
            Console.WriteLine($"GetFullPath: {Path.GetFullPath(path)}");
            Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}");
            Console.WriteLine($"PathSeparator: {Path.PathSeparator}");
            Console.WriteLine($"GetTempPath: {Path.GetTempPath()}");
        }
    }
}   
