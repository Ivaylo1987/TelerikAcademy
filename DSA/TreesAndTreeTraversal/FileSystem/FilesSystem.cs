namespace FileSystem
{
    using System;
    using System.IO;

    class FilesSystem
    {
        private Folder root;

        public FilesSystem(Folder root)
        {
            this.root = root;
        }

        public Folder Root
        {
            get
            {
                return this.root;
            }
        }
    }
}
