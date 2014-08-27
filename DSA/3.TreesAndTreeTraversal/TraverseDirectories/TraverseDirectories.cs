namespace TraverseDirectories
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    class TraverseDirectories
    {
        private static StringBuilder FindFiles(IEnumerable<DirectoryInfo> directories, string filePattern)
        {
            var result = new StringBuilder();

            foreach (var directory in directories)
            {
                try
                {
                    var files = directory.EnumerateFiles(filePattern);
                    foreach (var file in files)
                    {
                        result.AppendLine(file.Name);
                    }

                    var subDirectories = directory.EnumerateDirectories();

                    result.Append(FindFiles(subDirectories, filePattern));
                }
                catch (UnauthorizedAccessException)
                {
                    
                    continue;
                }
                
            }

            return result;
        }

        static void Main()
        {
            var startDirectory = new DirectoryInfo(@"C:\Windows").EnumerateDirectories();

            var allExeFiles = FindFiles(startDirectory, "*.exe").ToString();
            Console.WriteLine(allExeFiles);
            
        }
    }
}
