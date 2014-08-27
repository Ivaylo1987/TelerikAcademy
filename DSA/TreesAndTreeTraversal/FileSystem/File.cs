namespace FileSystem
{
    class File
    {
        public File(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public long Size { get; set; }
    }
}
