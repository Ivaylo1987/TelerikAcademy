namespace ControlFlowConditionalLoops
{
    // Task 1
    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();

            this.Peel(potato);
            this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        // Used for Task 2
        public void Cook(Vegetable vegetable)
        {
            // ...
        }

        private Bowl GetBowl()
        {
            // ... 
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            // ...
            return new Carrot();
        }

        private Potato GetPotato()
        {
            // ...
            return new Potato();
        }

        private void Cut(Vegetable potato)
        {
            // ...
        }

        private void Peel(Vegetable vegetable)
        {
            // ...
        }

    }
}
