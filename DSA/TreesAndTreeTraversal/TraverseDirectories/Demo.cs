namespace TraverseDirectories
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    class Demo
    {
        private static StringBuilder FindExeFiles(IEnumerable<DirectoryInfo> directories)
        {
            var result = new StringBuilder();

            foreach (var directory in directories)
            {
                try
                {
                    var files = directory.EnumerateFiles("*.exe");
                    foreach (var file in files)
                    {
                        result.AppendLine(file.Name);
                    }

                    var subDirectories = directory.EnumerateDirectories();

                    result.Append(FindExeFiles(subDirectories));
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

            var allExeFiles = FindExeFiles(startDirectory).ToString();
            Console.WriteLine(allExeFiles);
            
        }
    }
}
