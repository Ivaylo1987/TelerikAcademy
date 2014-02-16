namespace School
{
    public abstract class Person : IComment
    {
        public string Name { get; private set; }

        public string Comment { get; set; }

    }
}
