namespace DesignPatterns.Creational.Builder
{
    //abstract builder
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;
        public abstract void SetSandwichType();
        public abstract void AddMeat();
        public abstract void AddVeggies();
        public abstract void AddCondiments();
        public abstract void PrepareSandwich();
        public void CreateNewSandwich() => sandwich = new Sandwich();
        public Sandwich GetSandwich() => sandwich;
    }
}
