namespace Bank
{
    public class Individual : Customer
    {
        public Individual(string name)
            : base(name)
        {
        }

        public string PersonalID { get; set; }
    }
}
