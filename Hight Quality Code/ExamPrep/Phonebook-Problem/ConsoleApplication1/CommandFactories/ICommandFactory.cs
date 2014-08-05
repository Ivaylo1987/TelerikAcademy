namespace PhoneBook.CommandFactories
{
    using System;
    using PhoneBook.Commands;

    public interface ICommandFactory
    {
        IPhoneBookCommand CreateCommand(string name, int commandParamsCount);
    }
}