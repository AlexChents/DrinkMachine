namespace DrinkMachine
{
    public abstract class Product
    {
        public abstract IProductComponent componentMain { get; set; }
        public abstract List<IProductComponent> componentAdditives { get; set; }
    }
}
