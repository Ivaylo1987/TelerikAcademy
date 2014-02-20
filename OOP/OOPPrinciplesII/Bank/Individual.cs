namespace Bank
{
    public class Individual : Customer
    {
        public Individual(string name, string personalID)
            : base(name)
        {
            this.PersonalID = personalID;
        }

        public string PersonalID { get; set; }
    }
}
