namespace PhoneBook
{
    using System;
    using System.Linq;
    using System.Text;

    public class ConsolePrinter : IConsolePrinterStrategy
    {
        private StringBuilder input = new StringBuilder();

        public void Append(string text)
        {
            this.input.AppendLine(text);
        }

        public void Print()
        {
            Console.WriteLine(this.input.ToString());
        }
    }
}
