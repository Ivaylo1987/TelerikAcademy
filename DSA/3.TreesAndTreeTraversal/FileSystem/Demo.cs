namespace FileSystem
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Demo
    {
        private static string Separator(int length)
        {
            return new string('-', length);
        }

        private static void ShowDirectoriesTree(Folder root, int separatorLength)
        {
            foreach (var subFolder in root.Folders)
            {
                Console.WriteLine(Separator(separatorLength) + subFolder.Name);
                ShowDirectoriesTree(subFolder, separatorLength + 1);
            }

            foreach (var file in root.Files)
            {
                Console.WriteLine(Separator(separatorLength) + file.Name);
            }
        }

        private static Folder BuildHierarchy(DirectoryInfo directory)
        {
            var currentFolder = new Folder(directory.Name);

            var subDirectories = directory.EnumerateDirectories();
            var files = directory.EnumerateFiles();

            foreach (var file in files)
            {
                var currentFile = new File(file.Name);
                currentFile.Size = file.Length;
                currentFolder.Files.Add(currentFile);
            }

            foreach (var dir in subDirectories)
            {
                currentFolder.Folders.Add(BuildHierarchy(dir));
            }

            return currentFolder;
        }

        static void Main()
        {
            var directory = new DirectoryInfo(@"E:\Docs\GitRepos\TelerikAcademy\Databases");
            var root = BuildHierarchy(directory);
            var fileSystem = new FilesSystem(root);

            ShowDirectoriesTree(fileSystem.Root, 1);
        }
    }
}
