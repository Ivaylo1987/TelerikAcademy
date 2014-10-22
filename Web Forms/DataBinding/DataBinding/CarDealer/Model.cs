namespace DataBinding.CarDealer
{
    public class Model
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}
