using System.Collections.Generic;
namespace FileSystem
{
    class Folder
    {
        public string Name { get; private set; }
        public IList<File> Files { get; set; }
        public IList<Folder> Folders { get; set; }

        public Folder(string name)
        {
            this.Name = name;
            this.Folders = new List<Folder>();
            this.Files = new List<File>();
        }
    }
}
