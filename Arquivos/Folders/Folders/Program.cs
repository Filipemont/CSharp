using System;
using System.IO;
using System.Collections.Generic;

namespace Folders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Windows\temp\myfolder";

            try
            {

                //var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string folder in folders)
                {                    
                    Console.WriteLine(folder);
                }
                //var files = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + @"\newFolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}