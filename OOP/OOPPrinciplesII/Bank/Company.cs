namespace Bank
{
    public class Company : Customer
    {
        public Company(string name, int idNumber)
            : base(name) 
        {
            this.IDNumber = idNumber;
        }

        public int IDNumber { get; set; }
    }
}
