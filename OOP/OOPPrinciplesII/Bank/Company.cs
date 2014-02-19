namespace Bank
{
    public class Company : Customer
    {
        public Company(string name)
            : base(name) 
        {
        }

        public int IDNumber { get; set; }
    }
}
