namespace PhoneBook.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListPhoneBookCommand : PhoneBookCommand
    {
        private readonly IConsolePrinterStrategy printer;

        public ListPhoneBookCommand(IPhonebookRepository repo, IConsolePrinterStrategy printer) : base(repo)
        {
            this.printer = printer;
        }

        public override void Execute(string[] parameters)
        {
            try
            {
                IEnumerable<PhoneEntry> entries = this.Repo.ListEntries(int.Parse(parameters[0]), int.Parse(parameters[1]));
                foreach (var entry in entries)
                {
                    this.printer.Append(entry.ToString());
                }
            }
            catch (ArgumentException)
            {
                this.printer.Append("Invalid range");
            }
        }
    }
}