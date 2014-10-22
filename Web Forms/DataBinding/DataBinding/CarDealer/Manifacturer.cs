namespace DataBinding.CarDealer
{
    using System.Collections.Generic;

    public class Manufacturer
    {
        public Manufacturer(string name)
        {
            this.Models = new HashSet<Model>();
            this.Name = name;
        }

        public string Name { get; set; }

        public ICollection<Model> Models { get; set; }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}