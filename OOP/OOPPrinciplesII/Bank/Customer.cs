namespace Bank
{
    public abstract class Customer
    {
        
        protected Customer(string name)
        {
            this.Name = name;
        }
        protected string Name { get; set; }

    }
}
