namespace PhoneBook.Commands
{
    using System;
    using System.Linq;

    public class AddPhoneCommand : PhoneBookCommand
    {
        private readonly INumberConverterStrategy converter;

        private readonly IConsolePrinterStrategy printer;

        public AddPhoneCommand(IPhonebookRepository repo, INumberConverterStrategy converter, IConsolePrinterStrategy printer)
            : base(repo)
        {
            this.converter = converter;
            this.printer = printer;
        }

        public override void Execute(string[] parameters)
        {
            string name = parameters[0];
            var phoneNumbers = parameters.Skip(1).ToList();

            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                phoneNumbers[i] = this.converter.Convert(phoneNumbers[i]);
            }
            
            bool flag = this.Repo.AddPhone(name, phoneNumbers);

            if (flag)
            {
                this.printer.Append("Phone entry created");
            }
            else
            {
                this.printer.Append("Phone entry merged");
            }
        }
    }
}
