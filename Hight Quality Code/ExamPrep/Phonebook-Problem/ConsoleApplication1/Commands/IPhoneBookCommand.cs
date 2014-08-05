namespace PhoneBook.Commands
{
    public interface IPhoneBookCommand
    {
        void Execute(string[] parameters);
    }
}