//Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively and
//to display all files matching the mask *.exe. Use the class System.IO.Directory.

namespace _02.DirectoryTraversals
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class DirectoryTraversals
    {
        static void Main(string[] args)
        {
            string startingDir = "C:\\Windows";
            string fileExtension = "*.exe";
            var matchingFiles = new List<string>();
            matchingFiles = GetAllMatchingFiles(startingDir, fileExtension, ref matchingFiles);

            foreach (var file in matchingFiles)
            {
                Console.WriteLine(file);
            }
        }

        private static List<string> GetAllMatchingFiles(string startingDir, string fileExtension, ref List<string> matchingFiles)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(startingDir))
                {
                    foreach (string file in Directory.GetFiles(dir, fileExtension))
                    {
                        matchingFiles.Add(file);
                    }
                    GetAllMatchingFiles(dir, fileExtension, ref matchingFiles);
                }

                return matchingFiles;
            }
            catch (UnauthorizedAccessException exception)
            {
                Console.WriteLine(exception.Message);
                return matchingFiles;
            }
        }
    }
}
