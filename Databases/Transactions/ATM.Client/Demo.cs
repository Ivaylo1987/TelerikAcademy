namespace ATM.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ATM.Model;
    using System.Data;
using System.Data.Entity;

    class Demo
    {
        private static bool CheckIfCardIsValid(string cardNumber, string pin)
        {
            var result = false;

            using (var db = new ATMEntities())
            {
                if (db.CardAccounts.Any(ca => ca.CardNumber == cardNumber && ca.CardPIN == pin))
                {
                    result = true;
                }
            }

            return result;
        }

        private static bool CheckIfAccounBallanceIsSufficient(string cardNumber, decimal transferSum)
        {
            var result = false;

            using (var db = new ATMEntities())
            {
                var account = db.CardAccounts.First(ca => ca.CardNumber == cardNumber);

                if (account.CardCash >= transferSum)
                {
                    result = true;
                }
            }

            return result;
        }

        private static void TransferMoney(string from, string to, decimal amount, ATMEntities db)
        {
            var accountFrom = db.CardAccounts.First(ac => ac.CardNumber == from);
            var accountTo = db.CardAccounts.First(ac => ac.CardNumber == to);

            accountFrom.CardCash = accountFrom.CardCash - amount;
            accountTo.CardCash = accountTo.CardCash + amount;
        }

        static void Main()
        {
            using (var db = new ATMEntities())
            {
                var tran = db.Database.BeginTransaction(IsolationLevel.RepeatableRead);

                var cardNumber = Console.ReadLine();
                var pin = Console.ReadLine();
                var transferCard = Console.ReadLine();

                if (!CheckIfCardIsValid(cardNumber, pin))
                {
                    tran.Rollback();
                    return;
                }

                if (!CheckIfAccounBallanceIsSufficient(cardNumber, 200))
                {
                    tran.Rollback();
                    return;
                }

                TransferMoney(cardNumber, transferCard, 200, db);

                db.SaveChanges();

                tran.Commit();
                //tran.Rollback();
            }
        }
    }
}
