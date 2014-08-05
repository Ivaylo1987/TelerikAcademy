namespace PhoneBook.Commands
{
    using System;

    public abstract class PhoneBookCommand : IPhoneBookCommand
    {
        private IPhonebookRepository repo;

        protected PhoneBookCommand(IPhonebookRepository repo)
        {
            this.repo = repo;
        }

        public IPhonebookRepository Repo
        {
            get
            {
                return this.repo;
            }
        }

        public abstract void Execute(string[] parameters);
    }
}