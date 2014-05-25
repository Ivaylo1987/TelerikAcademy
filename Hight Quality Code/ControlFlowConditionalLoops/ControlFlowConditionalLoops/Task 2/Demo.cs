namespace ControlFlowConditionalLoops
{
    using System;
    public class Demo
    {
        public void CookPatato(Potato potato, Chef Pesho)
        {
            if (potato == null)
            {
                throw new ArgumentNullException("Potatoe does not exist!");
            }

            if (potato.HasBeenPeeled && potato.IsFresh)
            {
                Pesho.Cook(potato);
            }
        }
    }
}
