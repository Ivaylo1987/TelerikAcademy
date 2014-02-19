namespace Bank
{
    interface IInterest
    {
        decimal InterestRate { get; set; }
        decimal CalculateInterest(decimal periodMonths);
    }
}
