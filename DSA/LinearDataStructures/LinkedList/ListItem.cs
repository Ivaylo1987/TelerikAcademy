namespace LinkedList
{
    using System;

    class ListItem<T>
    {
        public T Value { get; private set; }
        public ListItem<T> NextItem { get; set; }
        public ListItem(T value)
        {
            this.Value = value;
        }
    }
}
