namespace PhoneBook
{
    using System;
    using System.Linq;
    using PhoneBook.CommandFactories;

    public class ApplicationEntry
    {
        public static void Main()
        {
            var printer = new ConsolePrinter();
            var commandParser = new InputParser();
            var converter = new NumberConverter();
            var phoneBookRepo = new PhoneBookRepo();
            var commandFactory = new CommandFactory(phoneBookRepo, converter, printer);

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "End" || inputLine == null)
                {
                    break;
                }

                var commandInfo = commandParser.Parse(inputLine);

                var currentCommand = commandFactory.CreateCommand(commandInfo.Name, commandInfo.Parameters.Count());

                currentCommand.Execute(commandInfo.Parameters);
            }

            printer.Print();
        }
    }
}