namespace DesignPatterns.Composite
{
    using System;

    class Demo
    {
        static void Main()
        {
            var skipper = new Commander("General Skipper");
            var kovalski = new Commander("Colonel Kovalski");
            var @private = new Soldier("Private");
            var rico = new Commander("Captain Rico");

            // General Skipper commands Colonel Kovalski, Captain Ricko and Private
            skipper.AddSubordinate(kovalski);
            skipper.AddSubordinate(rico);
            skipper.AddSubordinate(@private);

            var jake = new Soldier("Jake");
            var john = new Soldier("John");
            var jacobs = new Soldier("Jacob");

            // Captain Ricko commands 3 privates
            rico.AddSubordinate(jake);
            rico.AddSubordinate(john);
            rico.AddSubordinate(jacobs);

            skipper.Display(1);
        }
    }
}
