namespace ATM.Client
{
    using ATM.Model;
    using System;
    using System.Data;
    using System.Linq;

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

        private static void CreateHistoryRecord(ATMEntities db, decimal amount, string cardNumber, string transferCard)
        {
            var transactionHistoryRecords = new TransactionHistory()
            {
                Amount = amount,
                TransactionDate = DateTime.Now,
                CardNumber = cardNumber,
                TransferToCardNumber = transferCard
            };

            db.TransactionHistories.Add(transactionHistoryRecords);
        }

        static void Main()
        {
            using (var db = new ATMEntities())
            {
                var tran = db.Database.BeginTransaction(IsolationLevel.RepeatableRead);
                var amount = 200m;

                // Use this for input:
                // 1234SA78P
                // 1234
                // 456KRW81

                var cardNumber = Console.ReadLine();
                var pin = Console.ReadLine();
                var transferCard = Console.ReadLine();

                if (!CheckIfCardIsValid(cardNumber, pin))
                {
                    tran.Rollback();
                    return;
                }

                if (!CheckIfAccounBallanceIsSufficient(cardNumber, amount))
                {
                    tran.Rollback();
                    return;
                }

                TransferMoney(cardNumber, transferCard, amount, db);
                CreateHistoryRecord(db, amount, cardNumber, transferCard);

                db.SaveChanges();
                tran.Commit();
                //tran.Rollback();
            }
        }
    }
}
