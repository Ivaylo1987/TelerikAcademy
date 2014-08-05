namespace PhoneBook.CommandFactories
{
    using System;
    using System.Collections.Generic;
    using PhoneBook.Commands;

    public class CommandFactory : ICommandFactory
    {
        private const string AddPhoneCommandName = "AddPhone";
        private const string ChangePhoneCommandName = "ChangePhone";
        private const string ListPhoneBookCommand = "List";

        private readonly IPhonebookRepository commandRepo;
        private readonly INumberConverterStrategy converter;
        private readonly IConsolePrinterStrategy printer;

        private IDictionary<string, IPhoneBookCommand> commandList;

        public CommandFactory(IPhonebookRepository commandRepo, INumberConverterStrategy converter, IConsolePrinterStrategy printer)
        {
            this.commandRepo = commandRepo;
            this.converter = converter;
            this.printer = printer;
            this.commandList = new Dictionary<string, IPhoneBookCommand>();
        }

        public IPhoneBookCommand CreateCommand(string name, int commandParamsCount)
        {
            if (name.StartsWith(AddPhoneCommandName) && (commandParamsCount >= 2))
            {
                if (this.commandList.ContainsKey(AddPhoneCommandName))
                {
                    return this.commandList[AddPhoneCommandName];
                }

                var addCommand = new AddPhoneCommand(this.commandRepo, this.converter, this.printer);
                this.commandList.Add(AddPhoneCommandName, addCommand);

                return addCommand;
            }
            else if ((name == ChangePhoneCommandName) && (commandParamsCount == 2))
            {
                if (this.commandList.ContainsKey(ChangePhoneCommandName))
                {
                    return this.commandList[ChangePhoneCommandName];
                }

                var changeCommand = new ChangePhoneCommand(this.commandRepo, this.converter, this.printer);
                this.commandList.Add(ChangePhoneCommandName, changeCommand);

                return changeCommand;
            }
            else if ((name == ListPhoneBookCommand) && (commandParamsCount == 2))
            {
                if (this.commandList.ContainsKey(ListPhoneBookCommand))
                {
                    return this.commandList[ListPhoneBookCommand];
                }

                var listCommand = new ListPhoneBookCommand(this.commandRepo, this.printer);
                this.commandList.Add(ListPhoneBookCommand, listCommand);

                return listCommand;
            }
            else
            {
                throw new ArgumentException("Invalid command!");
            }
        }
    }
}