using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace _03.FileTraversals
{
    public class Test
    {
        static void Main()
        {
            string startingDir = "C:\\Windows";
            var root = new Folder("C:\\Windows");
            BuildTree(startingDir, root);
            long totalSize = 0;
            GetSizeOfFiles(root, ref totalSize);
            Console.WriteLine("The total size of the files is {0} bytes.", totalSize);
        }

        private static void GetSizeOfFiles(Folder dir, ref long size)
        {
            foreach (var file in dir.files)
            {
                size += file.Size;
            }

            foreach (var folder in dir.childFolders)
            {
                GetSizeOfFiles(folder, ref size);
            }
        }

        private static void BuildTree(string startingDir, Folder currentFolder)
        {
            Console.WriteLine(startingDir);
            foreach (var file in Directory.GetFiles(startingDir))
            {
                currentFolder.files.Add(new File(file, new FileInfo(file).Length));
            }

            var directories = Directory.GetDirectories(startingDir);

            for (int i = 0; i < directories.Length; i++)
            {
                try
                {
                    currentFolder.childFolders.Add(new Folder(directories[i]));

                    var files = Directory.GetFiles(directories[i]);

                    for (int j = 0; j < files.Length; j++)
                    {
                        currentFolder.childFolders[i].files.Add(new File(files[j], new FileInfo(files[j]).Length));
                    }

                    BuildTree(currentFolder.childFolders[i].Name, currentFolder.childFolders[i]);

                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Directory '{0}' cannot be accessed", directories[i]);
                }
            }
        }
    }
}
