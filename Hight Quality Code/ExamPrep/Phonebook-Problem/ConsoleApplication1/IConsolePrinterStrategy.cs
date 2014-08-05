namespace PhoneBook
{
    using System;

    public interface IConsolePrinterStrategy
    {
        void Append(string text);

        void Print();
    }
}