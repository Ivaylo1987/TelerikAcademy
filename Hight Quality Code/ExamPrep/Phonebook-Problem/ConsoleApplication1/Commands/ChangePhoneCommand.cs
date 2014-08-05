namespace PhoneBook.Commands
{
    using System;
    using System.Linq;

    public class ChangePhoneCommand : PhoneBookCommand
    {
        private readonly INumberConverterStrategy converter;

        private readonly IConsolePrinterStrategy printer;

        public ChangePhoneCommand(IPhonebookRepository repo, INumberConverterStrategy converter, IConsolePrinterStrategy printer) : base(repo)
        {
            this.converter = converter;
            this.printer = printer;
        }

        public override void Execute(string[] parameters)
        {
            this.printer.Append(string.Empty + this.Repo.ChangePhone(this.converter.Convert(parameters[0]), this.converter.Convert(parameters[1])) + " numbers changed");
        }
    }
}